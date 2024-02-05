using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using BeneficialStrategies.Iso20022.Choices.SupervisingAuthorityIdentification1Choice;
using BeneficialStrategies.Iso20022.SchemaValidation;
using Xunit.Abstractions;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// This class should be inherited by
/// </summary>
/// <typeparam name="TMessageType"></typeparam>
/// <typeparam name="TMessageDocType"></typeparam>
public abstract class TestPublishedOuterRecordSample<TMessageType, TMessageDocType> : TestPublishedSample<TMessageType>
    where TMessageType : IOuterRecord<TMessageType, TMessageDocType>, IOuterRecord, ISerializeInsideARootElement
    where TMessageDocType : IOuterDocument<TMessageType>
{
    protected Iso20022SchemaSet iso20022SchemaSet = new();
    protected TestPublishedOuterRecordSample(ITestOutputHelper output) : base(output)
    {
    }

    [Fact(DisplayName = "_M. Example XML passes ISO validation.")]
    public void SuppliedSamplePassesValidation()
    {
        var xdoc = this.loadedXDocument ?? throw new InvalidOperationException("XDocument for sample is not loaded.");
        var rootElement = xdoc.Root ?? throw new InvalidOperationException("No root element in sample data.");
        var xmlNamespace = TMessageType.IsoXmlNamspace;
        var errors = this.iso20022SchemaSet.GetIsoValidateErrors(xmlNamespace, rootElement.ToString());
        foreach (var error in errors)
        {
            this.output.WriteLine($@"{error.OffendingObject} {error.Info.Severity} {error.Info.Message}");
        }
        Assert.True(errors.Count() == 0, "One or more errors in sample data, see output.");
    }

    [Fact]
    public void SerializedOutputValidatesWithIsoSchema()
    {
        var doc = Sample.ToDocument();
        var settings = new DataContractSerializerSettings
        {
            DataContractResolver = new Iso20022DataContractResolver(),
            PreserveObjectReferences = false,
            SerializeReadOnlyTypes = true,

            
        };
        var serializer = new DataContractSerializer(doc.GetType(), settings );
        var memoryStream = new MemoryStream();
        serializer.WriteObject(memoryStream, doc);
        memoryStream.Position = 0;
        // Get it in an XDocument
        XDocument xdoc = XDocument.Load(memoryStream);
        var errorCount = 0;
        xdoc.Validate(this.iso20022SchemaSet, (o, e) =>
        {
            errorCount++;
            this.output.WriteLine($@"{o?.GetType().Name} {e.Severity} {e.Message}");
        });
        var currentDirectory = new DirectoryInfo(System.Environment.CurrentDirectory);
        var outputDirectory = currentDirectory.CreateSubdirectory(typeof(TMessageType).Name);
        var actualFilePath = Path.Combine(outputDirectory.FullName, "Actual.xml");
        xdoc.Save(actualFilePath);
        this.output.WriteLine($@"Output has been place in {actualFilePath}");
        Assert.True(errorCount == 0, $"There were {errorCount} errors, see output.");
    }
}


public class Iso20022DataContractResolver : DataContractResolver
{
    private XmlDictionary xmlDictionary = new XmlDictionary();
    private XmlDictionaryString rootNamespace;
    public Iso20022DataContractResolver()
    {
        rootNamespace = xmlDictionary.Add("urn:iso:std:iso:20022:tech:xsd:pain.001.001.11");
    }
    public override Type? ResolveName(string typeName, string? typeNamespace, Type? declaredType, DataContractResolver knownTypeResolver)
    {
        return knownTypeResolver.ResolveName(typeName, typeNamespace, declaredType, this);
    }

    public override bool TryResolveType(Type type, Type? declaredType, DataContractResolver knownTypeResolver, out XmlDictionaryString? typeName, out XmlDictionaryString? typeNamespace)
    {
        XmlDictionaryString? possibleTypeName;
        XmlDictionaryString? possibleTypeNamespace;
        var resolved = knownTypeResolver.TryResolveType(type, declaredType, this, out possibleTypeName, out possibleTypeNamespace);
        typeName = possibleTypeName;
        typeNamespace = this.rootNamespace;
        return resolved;
    }
}

// public class AllowAllContractResolver : DataContractResolver
// {
//     public override bool TryResolveType(Type dataContractType, Type? declaredType, DataContractResolver knownTypeResolver, out XmlDictionaryString? typeName, out XmlDictionaryString? typeNamespace)
//     {
//         if (!knownTypeResolver.TryResolveType(dataContractType, declaredType, this, out typeName, out typeNamespace))
//         {
//             var dictionary = new XmlDictionary();
//             if ( dataContractType?.FullName is not null )
//                 typeName = dictionary.Add(dataContractType.FullName);
//             if ( dataContractType?.Assembly?.FullName is not null ) typeNamespace = dictionary.Add(dataContractType.Assembly.FullName);
//         }
//         return true;
//     }

//     public override Type ResolveName(string typeName, string? typeNamespace, Type? declaredType, DataContractResolver knownTypeResolver)
//     {
//         return knownTypeResolver.ResolveName(typeName, typeNamespace, declaredType, null) ?? Type.GetType(typeName + ", " + typeNamespace);
//     }
// }
