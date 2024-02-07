﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionAndRepairReason2Choice.  ISO2002 ID# _UWrqYtp-Ed-ak6NoX_4Aeg_1498536988.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the rejection or repair reason.
/// </summary>
[KnownType(typeof(RejectionAndRepairReason2Choice.Code))]
[KnownType(typeof(RejectionAndRepairReason2Choice.Proprietary))]
public abstract partial record RejectionAndRepairReason2Choice_ : IIsoXmlSerilizable<RejectionAndRepairReason2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectionAndRepairReason2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RejectionAndRepairReason2Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RejectionAndRepairReason2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectionAndRepairReason2Choice choice.")
        };
    }
}
