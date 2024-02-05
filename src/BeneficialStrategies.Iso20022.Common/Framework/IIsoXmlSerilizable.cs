
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Framework;

/// <summary>
/// Denotes the container as being self-serializable in a ISO20022-compliant syntax.
/// </summary>
/// <typeparam name="TSelf">The type we are decorating with this interface.</typeparam>
public interface IIsoXmlSerilizable<TSelf> : Iso20022Certified<TSelf>, ISerializeInsideARootElement
{
    /// <summary>
    /// Serialize this instance to the xml writer in ISO20022 format.
    /// </summary>
    /// <param name="xmlWriter"></param>
    /// <returns></returns>
    Task SerializeAsync(XmlWriter xmlWriter);

    void Serialize(XmlWriter writer, string xmlNamespace);

    /// <summary>
    /// Deserializes the specified element into an instance of this record.
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    static abstract TSelf Deserialize(XElement element);

    /// <summary>
    /// Deserializes from the reader by placing the subtree in a <seeAlso cref="XElement"/> and calling <see cref="Deserialize(XElement)"/>.
    /// </summary>
    /// <param name="reader"></param>
    /// <returns></returns>
    static abstract Task<TSelf> DeserializeAsync(XmlReader reader);
}

