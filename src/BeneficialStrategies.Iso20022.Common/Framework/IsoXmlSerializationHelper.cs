
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Common.Framework;

/// <summary>
/// Used to simplify frequently-repeated operations in serialization and deserialization.
/// Leverages <seealso cref="XElement"/> so we can utilize linq to resolve property values without worrying about the exact ordering of elements. 
/// </summary>
/// <typeparam name="TTypeToSerialize">The outer data type we are serializing or deserializing.</typeparam>
public static class IsoXmlSerializationHelper<TTypeToSerialize> 
    where TTypeToSerialize : IIsoXmlSerilizable<TTypeToSerialize>
{
    /// <summary>
    /// Initializes the container element with the right namespaces info.  It then provokes the <see cref="TTypeToSerialize"/> to deserialize the contents.
    /// </summary>
    /// <param name="reader"></param>
    /// <returns></returns>
    public static async Task<TTypeToSerialize> DeserializeAsync(XmlReader reader)
    {
        XElement root = await XElement.LoadAsync(reader, new LoadOptions { }, CancellationToken.None);
        return TTypeToSerialize.Deserialize(root);
    }

    /// <summary>
    /// Retrieves a member value as stored in a child element value.
    /// </summary>
    /// <param name="rootElement"></param>
    /// <param name="selectedChildElement"></param>
    /// <returns></returns>
    /// <exception cref="IsoDeserializationMissingElementException"></exception>
    public static string GetStringValue(XElement rootElement, XName selectedChildElement)
    {
        return rootElement.Element(selectedChildElement)?.Value
            ?? throw new IsoDeserializationMissingElementException(typeof(TTypeToSerialize), selectedChildElement.LocalName);
    }

    /// <summary>
    /// Provokes the appropriate child record type to deserialize its own contents based on the supplied element.
    /// </summary>
    /// <typeparam name="TMemberType"></typeparam>
    /// <param name="rootElement"></param>
    /// <returns></returns>
    /// <exception cref="IsoDeserializationMissingElementException"></exception>
    public static TMemberType GetChildMember<TMemberType>(XElement rootElement)
        where TMemberType : IIsoXmlSerilizable<TMemberType>
    {
        XElement elementToDeserialize = rootElement.Element(TMemberType.RootElement)
            ?? throw new IsoDeserializationMissingElementException(typeof(TTypeToSerialize), TMemberType.RootElement.LocalName);
        return TMemberType.Deserialize(elementToDeserialize);
    }

    /// <summary>
    /// Creates the fully qualified name of the member.
    /// </summary>
    /// <param name="localName">The local name of the element or attribute we are serializing.</param>
    /// <returns></returns>
    public static XName CreateXName(string localName) => XName.Get(localName, string.Empty);

    /// <summary>
    /// Writes the specified value to the xml as an element with a value.
    /// </summary>
    /// <param name="xmlWriter"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Task WriteElementStringAsync(XmlWriter xmlWriter, XName name, string value)
    {
        return xmlWriter.WriteElementStringAsync(null, name.LocalName, null, value);
    }
}
