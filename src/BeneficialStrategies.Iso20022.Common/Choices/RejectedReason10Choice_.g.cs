﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectedReason10Choice.  ISO2002 ID# _2dRqY1hnEeSsH9MSoogb7Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
/// </summary>
[KnownType(typeof(RejectedReason10Choice.Code))]
[KnownType(typeof(RejectedReason10Choice.Proprietary))]
public abstract partial record RejectedReason10Choice_ : IIsoXmlSerilizable<RejectedReason10Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectedReason10Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RejectedReason10Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RejectedReason10Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectedReason10Choice choice.")
        };
    }
}
