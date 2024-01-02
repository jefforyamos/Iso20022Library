using System.Text;
using System.Xml;
using Xunit.Abstractions;

namespace BeneficialStrategies.Iso20022.Common;

public static class TestingExtensionMethods
{
    private static XmlWriterSettings StandardIndentedSettings = new XmlWriterSettings
    {
        Indent = true,
        OmitXmlDeclaration = true,
        Async = true,
        ConformanceLevel = ConformanceLevel.Fragment,
        NewLineHandling = NewLineHandling.Replace
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
}
