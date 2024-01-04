using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using BeneficialStrategies.Iso20022.SchemaValidation;
using Xunit.Abstractions;

namespace BeneficialStrategies.Iso20022.Common.Framework;

public static class TestingExtensionMethods
{
    private static XmlWriterSettings StandardIndentedSettings = new XmlWriterSettings
    {
        Indent = true,
        OmitXmlDeclaration = true,
        Async = true,
        ConformanceLevel = ConformanceLevel.Fragment,
        NewLineHandling = NewLineHandling.Replace,
        NewLineChars = "\r\n"
    };

    /// <summary>
    /// Take the state of this object, serialize it to a string, then deserialize it to a copy and compare for equality.
    /// </summary>
    /// <typeparam name="T">Data type of the record to serialize.</typeparam>
    /// <param name="dataObjectToSerialize">Record instance whose state will be serialized.</param>
    /// <param name="ouputForXmlSerialization">Optional value if output of the intermediate value is desired.</param>
    /// <returns></returns>
    public static async Task<T> AssertSerializationRoundTripWorks<T>(this T dataObjectToSerialize, ITestOutputHelper? ouputForXmlSerialization = null)
        where T : IIsoXmlSerilizable<T>
    {
        // Serialize to the stringbuilder
        var sb = new StringBuilder();
        using (var xmlWriter = XmlWriter.Create(sb, StandardIndentedSettings))
        {
            await dataObjectToSerialize.SerializeAsync(xmlWriter);
            await xmlWriter.FlushAsync();
        }
        ouputForXmlSerialization?.WriteLine(sb.ToString());
        // Deserialize from the stringbuilder
        using var stringReader = new StringReader(sb.ToString());
        using var xmlReader = XmlReader.Create(stringReader, new XmlReaderSettings { Async = true });
        var copy = await T.DeserializeAsync(xmlReader);
        // Contents must be identical
        Assert.Equal(dataObjectToSerialize, copy);
        return copy;
    }

    /// <summary>
    /// Tests whether the serialized Xml exactly matches the value of an artifact obtained elsewhere for the purpose of testing.
    /// </summary>
    /// <typeparam name="T">Data type of the record being serialized.</typeparam>
    /// <param name="dataObjectToSerialize">Record instance providing state that is being serialized.</param>
    /// <param name="knownValidXml">XML snippet we know to be correct.</param>
    /// <param name="ouputForXmlSerialization">Optional, shows intermediate results if output is provided.</param>
    /// <returns></returns>
    public static async Task AssertSerializationMatchesArtifact<T>(this T dataObjectToSerialize, string knownValidXml, ITestOutputHelper? ouputForXmlSerialization = null)
       where T : IIsoXmlSerilizable<T>
    {
        var xDoc = new XmlDocument();
        xDoc.LoadXml(knownValidXml);
        var sbExpected = new StringBuilder();
        using (var xmlWriter = XmlWriter.Create(sbExpected, StandardIndentedSettings))
        {
            xDoc.WriteTo(xmlWriter);
            await xmlWriter.FlushAsync();
        }
        var sbActual = new StringBuilder();
        using (var xmlWriter = XmlWriter.Create(sbActual, StandardIndentedSettings))
        {
            await dataObjectToSerialize.SerializeAsync(xmlWriter);
            await xmlWriter.FlushAsync();
        }
        ouputForXmlSerialization?.WriteLine(sbActual.ToString());
        Assert.Equal(sbExpected.ToString(), sbActual.ToString());
    }

    private static string GetSampleXmlWithWhitespaceNormalized(string knownValidXml)
    {
        var xDoc = new XmlDocument();
        xDoc.LoadXml(knownValidXml);
        var sbExpected = new StringBuilder();
        using (var xmlWriter = XmlWriter.Create(sbExpected, StandardIndentedSettings))
        {
            xDoc.WriteTo(xmlWriter);
            xmlWriter.Flush();
        }
        return sbExpected.ToString();
    }

    public static async Task AssertJsonSerializationRoundTrip<T>(this T dataObjectToSerialize, ITestOutputHelper? outputHelper = null)
        where T : Iso20022Certified<T>
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PreferredObjectCreationHandling = System.Text.Json.Serialization.JsonObjectCreationHandling.Populate
        };
        var myJson = JsonSerializer.Serialize(dataObjectToSerialize, options);
        outputHelper?.WriteLine(myJson);
        var memStream = new MemoryStream(Encoding.UTF8.GetBytes(myJson));
        var copy = await JsonSerializer.DeserializeAsync<T>(memStream, options, CancellationToken.None);
        Assert.Equal(dataObjectToSerialize, copy);
    }

    // Dangerous per https://learn.microsoft.com/en-us/dotnet/standard/serialization/binaryformatter-security-guide
    public static void AssertBinaryFormatterRoundTrip<T>(this T dataObjectToSerialize, ITestOutputHelper? outputHelper = null)
       where T : Iso20022Certified<T>
    {
#pragma warning disable SYSLIB0011
        var memoryStream = new MemoryStream();
        var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
        binaryFormatter.Serialize(memoryStream, dataObjectToSerialize);
        memoryStream.Position = 0;
        var copy = binaryFormatter.Deserialize(memoryStream);
        Assert.Equal(dataObjectToSerialize, copy);
#pragma warning restore SYSLIB0011
    }

    public static string ExtractStringContentsAndResetPointer(this MemoryStream memoryStream)
    {
        memoryStream.Position = 0;
        using var textReader = new StreamReader(memoryStream, null, true, -1, true);
        var returnValue = textReader.ReadToEnd();
        memoryStream.Position = 0;
        return returnValue;
    }

    public static void AssertDataContractSerializerRoundTrip<T>(this T dataObjectToSerialize, ITestOutputHelper? outputHelper = null)
       where T : Iso20022Certified<T>
    {
        var serializer = new System.Runtime.Serialization.DataContractSerializer(typeof(T));
        var memoryStream = new MemoryStream();
        serializer.WriteObject(memoryStream, dataObjectToSerialize);
        var valueInStream = memoryStream.ExtractStringContentsAndResetPointer();
        outputHelper?.WriteLine($"The dataserializer has used this as the contents of the serialization: \r\n {valueInStream}\r\n");

        // memoryStream.Position = 0;
        // using (var textReader = new StreamReader(memoryStream, null, true, -1, true))
        // {
        //     outputHelper?.WriteLine($"The dataserializer has used this as the contents of the serialization: \r\n {textReader.ReadToEnd()}\r\n");
        // }
        memoryStream.Position = 0;
        var copy = serializer.ReadObject(memoryStream);
        Assert.Equal(dataObjectToSerialize, copy);
    }

    public static void AssertDataContractSerializerDeserializesValidISO20022<T>(this T dataObjectToSerialize, string knownValidXml, ITestOutputHelper? outputHelper = null)
       where T : Iso20022Certified<T>
    {
        var normalizedXml = GetSampleXmlWithWhitespaceNormalized(knownValidXml);
        outputHelper?.WriteLine($"DataContractSerializer is attempting to deserialize this: \r\n {normalizedXml} \r\n");
        var settings = new System.Runtime.Serialization.DataContractSerializerSettings { };
        var serializer = new System.Runtime.Serialization.DataContractSerializer(typeof(T), settings);
        var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(normalizedXml));
        memoryStream.Flush();
        memoryStream.Position = 0;
        var copy = serializer.ReadObject(memoryStream);
        // memoryStream.Position = 0;
        // var copyText = new StreamReader(memoryStream).ReadToEnd();
        // Debug.Assert(knownValidXml == copyText); // Just making sure stream contents are right
        Assert.Equal(dataObjectToSerialize, copy);
    }

    public static void AssertXmlSerializerRoundTrip<T>(this T dataObjectToSerialize, ITestOutputHelper? outputHelper = null)
     where T : Iso20022Certified<T>
    {
        var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
        var memoryStream = new MemoryStream();
        serializer.Serialize(memoryStream, dataObjectToSerialize);
        memoryStream.Position = 0;
        var copy = serializer.Deserialize(memoryStream);
        Assert.Equal(dataObjectToSerialize, copy);
    }

    public static void AssertXmlSerializerDeserializesValidIso20022<T>(this T dataObjectToSerialize, string knownValidXml, ITestOutputHelper? outputHelper = null)
     where T : Iso20022Certified<T>
    {
        var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
        var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(knownValidXml));
        memoryStream.Flush();
        memoryStream.Position = 0;
        var copy = serializer.Deserialize(memoryStream);
        Assert.Equal(dataObjectToSerialize, copy);
    }

    public static void AssertBinaryWriterAndReaderRoundTrip<T>(this T dataObjectToSerialize, ITestOutputHelper? outputHelper = null)
        where T : Iso20022Certified<T>
    {
        var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
        var memoryStream = new MemoryStream();
        serializer.Serialize(memoryStream, dataObjectToSerialize);
        memoryStream.Position = 0;
        var copy = serializer.Deserialize(memoryStream);
        Assert.Equal(dataObjectToSerialize, copy);
    }

    public record ValErrorRec ( object? OffendingObject, ValidationEventArgs Info);

    public static IEnumerable<ValErrorRec> GetIsoValidateErrors(this Iso20022SchemaSet schemaSet, string outerNamespace, string innerContent)
    {
        Assert.True(schemaSet.NameTable.Get(outerNamespace) != null, $"The outer namespace {outerNamespace} is not supported.");
        var doc = CreateXDocumentWithInnerContent(outerNamespace, innerContent);
        var list = new List<ValErrorRec>();
        doc.Validate(schemaSet, (o, e) => 
        { 
            var rec = new ValErrorRec(o,e);
            list.Add( rec );
        }
        );
        return list;
    }

    private static XDocument CreateXDocumentWithInnerContent(string outerNamespace, string innerContent)
    {
        return XDocument.Parse(@$"
        <Document xmlns=""{outerNamespace}"">
            {innerContent}
        </Document>");   
    }

    public static void AssertNoIsoValidateErrors(this Iso20022SchemaSet schemaSet, string outerNamespace, string innerContent, ITestOutputHelper? outputHelper = null)
    {
        var errors = schemaSet.GetIsoValidateErrors(outerNamespace,innerContent);
        foreach(var err in errors)
        {
            outputHelper?.WriteLine($"{err.OffendingObject}={err.Info.Severity}:{err.Info.Message}");
        }
        Assert.False(errors.Any(), "Errors occurred, validation failed.  See output for details");
    }


}
