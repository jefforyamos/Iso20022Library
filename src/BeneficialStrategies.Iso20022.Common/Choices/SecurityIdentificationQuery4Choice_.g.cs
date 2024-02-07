﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecurityIdentificationQuery4Choice.  ISO2002 ID# _PHYIYZNeEeytjZlcgApf6A.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Query based on various identification of the security.
/// </summary>
[KnownType(typeof(SecurityIdentificationQuery4Choice.ISIN))]
[KnownType(typeof(SecurityIdentificationQuery4Choice.AlternativeInstrumentIdentification))]
[KnownType(typeof(SecurityIdentificationQuery4Choice.NotAvailable))]
[KnownType(typeof(SecurityIdentificationQuery4Choice.UniqueProductIdentifier))]
[KnownType(typeof(SecurityIdentificationQuery4Choice.Index))]
[KnownType(typeof(SecurityIdentificationQuery4Choice.Basket))]
[KnownType(typeof(SecurityIdentificationQuery4Choice.NotReported))]
public abstract partial record SecurityIdentificationQuery4Choice_ : IIsoXmlSerilizable<SecurityIdentificationQuery4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SecurityIdentificationQuery4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "ISIN" => SecurityIdentificationQuery4Choice.ISIN.Deserialize(elementWithPayload),
             "AltrntvInstrmId" => SecurityIdentificationQuery4Choice.AlternativeInstrumentIdentification.Deserialize(elementWithPayload),
             "NotAvlbl" => SecurityIdentificationQuery4Choice.NotAvailable.Deserialize(elementWithPayload),
             "UnqPdctIdr" => SecurityIdentificationQuery4Choice.UniqueProductIdentifier.Deserialize(elementWithPayload),
             "Indx" => SecurityIdentificationQuery4Choice.Index.Deserialize(elementWithPayload),
             "Bskt" => SecurityIdentificationQuery4Choice.Basket.Deserialize(elementWithPayload),
             "NotRptd" => SecurityIdentificationQuery4Choice.NotReported.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SecurityIdentificationQuery4Choice choice.")
        };
    }
}
