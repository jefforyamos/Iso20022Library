using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Framework;

/// <summary>
/// Should be implemented on all messages that are the main incoming or outgoing message of the hierarchy.  
/// </summary>
public interface IOuterRecord
{
}


public interface IOuterRecord<TSelf, TMessageDocType> : IOuterRecord
    where TMessageDocType : IOuterDocument<TSelf>
    where TSelf : IOuterRecord
{
    TMessageDocType ToDocument();

}

public interface ISerializeInsideARootElement
{
       /// <summary>
    /// Returns the normal root element for this record type.
    /// </summary>
    static abstract XName RootElement { get; }

    static abstract string IsoXmlNamspace { get; }

}