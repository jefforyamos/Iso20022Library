﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionAndRepairReason26Choice.  ISO2002 ID# _zsG9YTs_EeWRTLSN0i0tng.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the rejection or repair reason.
/// </summary>
[KnownType(typeof(RejectionAndRepairReason26Choice.Code))]
[KnownType(typeof(RejectionAndRepairReason26Choice.Proprietary))]
public abstract partial record RejectionAndRepairReason26Choice_ : IIsoXmlSerilizable<RejectionAndRepairReason26Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectionAndRepairReason26Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RejectionAndRepairReason26Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RejectionAndRepairReason26Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectionAndRepairReason26Choice choice.")
        };
    }
}
