﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecurityIdentification11Choice.  ISO2002 ID# _RCMa0dp-Ed-ak6NoX_4Aeg_191397587.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between ISIN and an alternative format for the identification of a security. ISIN is the preferred format.
/// </summary>
[KnownType(typeof(SecurityIdentification11Choice.ISIN))]
[KnownType(typeof(SecurityIdentification11Choice.OtherIdentification))]
public abstract partial record SecurityIdentification11Choice_ : IIsoXmlSerilizable<SecurityIdentification11Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SecurityIdentification11Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "ISIN" => SecurityIdentification11Choice.ISIN.Deserialize(elementWithPayload),
             "OthrId" => SecurityIdentification11Choice.OtherIdentification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SecurityIdentification11Choice choice.")
        };
    }
}
