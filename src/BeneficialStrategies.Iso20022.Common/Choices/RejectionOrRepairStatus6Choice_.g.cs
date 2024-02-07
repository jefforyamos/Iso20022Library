﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionOrRepairStatus6Choice.  ISO2002 ID# _UUAJ19p-Ed-ak6NoX_4Aeg_-153082693.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies whether the status is provided with a reason or not.
/// </summary>
[KnownType(typeof(RejectionOrRepairStatus6Choice.NoSpecifiedReason))]
[KnownType(typeof(RejectionOrRepairStatus6Choice.Reason))]
public abstract partial record RejectionOrRepairStatus6Choice_ : IIsoXmlSerilizable<RejectionOrRepairStatus6Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectionOrRepairStatus6Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => RejectionOrRepairStatus6Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => RejectionOrRepairStatus6Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectionOrRepairStatus6Choice choice.")
        };
    }
}
