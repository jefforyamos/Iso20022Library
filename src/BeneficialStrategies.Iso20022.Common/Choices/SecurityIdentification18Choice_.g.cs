﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecurityIdentification18Choice.  ISO2002 ID# _b9RfIQOJEeWs3sTa9Sj6Lg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
/// </summary>
[KnownType(typeof(SecurityIdentification18Choice.ISIN))]
[KnownType(typeof(SecurityIdentification18Choice.AlternativeInstrumentIdentification))]
public abstract partial record SecurityIdentification18Choice_ : IIsoXmlSerilizable<SecurityIdentification18Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SecurityIdentification18Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "ISIN" => SecurityIdentification18Choice.ISIN.Deserialize(elementWithPayload),
             "AltrntvInstrmId" => SecurityIdentification18Choice.AlternativeInstrumentIdentification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SecurityIdentification18Choice choice.")
        };
    }
}
