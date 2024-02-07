﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionAndRepairReason41Choice.  ISO2002 ID# _diXTqTi8Eeydid5dcNPKvg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the rejection or repair reason.
/// </summary>
[KnownType(typeof(RejectionAndRepairReason41Choice.Code))]
[KnownType(typeof(RejectionAndRepairReason41Choice.Proprietary))]
public abstract partial record RejectionAndRepairReason41Choice_ : IIsoXmlSerilizable<RejectionAndRepairReason41Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectionAndRepairReason41Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RejectionAndRepairReason41Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RejectionAndRepairReason41Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectionAndRepairReason41Choice choice.")
        };
    }
}
