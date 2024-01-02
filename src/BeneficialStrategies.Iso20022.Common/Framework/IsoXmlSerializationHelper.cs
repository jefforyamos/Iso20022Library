
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Common.Framework;

public static class IsoXmlSerializationHelper<TTypeToSerialize>
    where TTypeToSerialize : IIsoXmlSerilizable<TTypeToSerialize>
{

    public static async Task<TTypeToSerialize> DeserializeAsync(XmlReader reader)
    {
        XElement root = await XElement.LoadAsync(reader, new LoadOptions { }, CancellationToken.None);
        return TTypeToSerialize.Deserialize(root);
    }

    public static string GetStringValue(XElement rootElement, XName selectedChildElement)
    {
        return rootElement.Element(selectedChildElement)?.Value
            ?? throw new IsoDeserializationMissingElementException(typeof(TTypeToSerialize), selectedChildElement.LocalName);
    }

    public static XName CreateXName(string localName) => XName.Get(localName, string.Empty);

    public interface IMemberInstructions
    {
        Task SerializeAsync(XmlWriter writer);
    }

   public static Task WriteElementStringAsync(XmlWriter xmlWriter, XName name, string value)
    {
        return xmlWriter.WriteElementStringAsync(null, name.LocalName, null, value);
    }
}
