﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionReason48Choice.  ISO2002 ID# _ds03Tzi8Eeydid5dcNPKvg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the rejection reason.
/// </summary>
[KnownType(typeof(RejectionReason48Choice.Code))]
[KnownType(typeof(RejectionReason48Choice.Proprietary))]
public abstract partial record RejectionReason48Choice_ : IIsoXmlSerilizable<RejectionReason48Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectionReason48Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RejectionReason48Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RejectionReason48Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectionReason48Choice choice.")
        };
    }
}
