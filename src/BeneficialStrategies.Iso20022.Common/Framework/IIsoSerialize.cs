
using System.Xml;

namespace BeneficialStrategies.Iso20022.Common.Framework;



public interface IIsoSerialize<TSelf>
{
    static abstract string RootElementLocalName { get; }
    Task SerializeAsync(XmlWriter writer);
    static abstract Task<TSelf> DeserializeAsync(XmlReader reader);
}
