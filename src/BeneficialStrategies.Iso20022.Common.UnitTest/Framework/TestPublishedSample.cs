using System.Reflection;
using System.Xml.Linq;
using Xunit.Abstractions;
using BeneficialStrategies.Iso20022.Framework;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022;

public abstract class TestPublishedSample<TMessageType>
{
    protected readonly ITestOutputHelper output;
    protected string? locatatedResourceFile;
    protected string expectedResourceName;
    protected Assembly assembly;
    protected XDocument? loadedXDocument;
    protected Exception? xmlLoadException;
    protected Exception? dataContractSerializerCreateException;
    protected DataContractSerializer? dataContractSerializer;
    protected Exception? xmlSerializerCreateException;
    protected System.Xml.Serialization.XmlSerializer? xmlSerializer;
    protected abstract TMessageType Sample { get; }

    protected TestPublishedSample(ITestOutputHelper output)
    {
        this.output = output;
        this.expectedResourceName = this.GetType() + ".xml";
        this.assembly = GetType().Assembly;
        this.locatatedResourceFile = this.assembly.GetManifestResourceNames().First(s => s.EndsWith(this.expectedResourceName,StringComparison.CurrentCultureIgnoreCase));
        try
        {
            using ( var readStream = GetEmbeddedResourceStream())
                this.loadedXDocument = XDocument.Load(readStream);
        }
        catch( Exception ex) { this.xmlLoadException = ex; }
        try
        {
            this.dataContractSerializer = new(typeof(TMessageType));
        }
        catch ( Exception ex) { this.dataContractSerializerCreateException = ex; }
        try 
        {
            this.xmlSerializer = new(typeof(TMessageType));
        }
        catch ( Exception ex ) { this.xmlSerializerCreateException = ex; }
    }

    protected Stream GetEmbeddedResourceStream()
    {
        return this.assembly.GetManifestResourceStream(this.locatatedResourceFile ?? throw new InvalidOperationException("Resource file not located.")) 
            ?? throw new InvalidOperationException("Resource was located but could not be read.");
    }
    
    [Fact(DisplayName = "_A. Read Embedded Resource file")]
    public void ReadEmbeddedResource()
    {
        Assert.True(this.locatatedResourceFile is not null, $@"Could not locate resource.  <EmbeddedResource Include=""pain/{this.expectedResourceName}"" /> " );
    }

    [Fact(DisplayName = "_B. Xml in sample is valid")]
    public void EmbeddedResourceXmlIsValid()
    {
        ReadEmbeddedResource(); // Prerequisite
        if ( this.xmlLoadException is not null ) throw this.xmlLoadException;
        Assert.NotNull(this.loadedXDocument);
    }

    [Fact(DisplayName = "_C. DataContractSerializer Created")]
    public void DataContractSerializer_Created()
    {
        if ( this.dataContractSerializerCreateException is not null ) throw this.dataContractSerializerCreateException;
    }

    [Fact(DisplayName = "_D. XmlSerializer Created")]
    public void XmlSerializer_Created()
    {
        if ( this.xmlSerializerCreateException is not null ) throw this.xmlSerializerCreateException;
    }

    [Fact(DisplayName = "DataContractSerializer - Serialize,deserialize, compare")]
    public void DataContractSerializer_SerializeDeserializeCompare()
    {
        var memoryStream = new MemoryStream();
        var original = Sample;
        Assert.NotNull(this.dataContractSerializer);
        this.dataContractSerializer?.WriteObject(memoryStream, original);
        var valueInStream = memoryStream.ExtractStringContentsAndResetPointer();
        this.output?.WriteLine($"The dataserializer has used this as the contents of the serialization: \r\n {valueInStream}\r\n");
        // memoryStream.Position = 0;
        // using (var textReader = new StreamReader(memoryStream, null, true, -1, true))
        // {
        //     outputHelper?.WriteLine($"The dataserializer has used this as the contents of the serialization: \r\n {textReader.ReadToEnd()}\r\n");
        // }
        memoryStream.Position = 0;
        var copy = this.dataContractSerializer?.ReadObject(memoryStream);
        Assert.Equal(original, copy);
    }

    [Fact(DisplayName = "XmlSerializer - Serialize, deserialize, compare")]
    public void XmlSerializer_SerializeDeserializeCompare()
    {
        var memoryStream = new MemoryStream();
        var original = Sample;
        Assert.NotNull(this.xmlSerializer);
        this.xmlSerializer?.Serialize(memoryStream, original);
        memoryStream.Position = 0;
        var copy = this.xmlSerializer?.Deserialize(memoryStream);
        Assert.Equal(original, copy);
    }
}