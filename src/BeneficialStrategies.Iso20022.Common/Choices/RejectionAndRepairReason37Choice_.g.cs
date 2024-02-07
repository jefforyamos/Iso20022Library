﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionAndRepairReason37Choice.  ISO2002 ID# _nOHI8ytVEeyhipY4f42fZQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the rejection or repair reason.
/// </summary>
[KnownType(typeof(RejectionAndRepairReason37Choice.Code))]
[KnownType(typeof(RejectionAndRepairReason37Choice.Proprietary))]
public abstract partial record RejectionAndRepairReason37Choice_ : IIsoXmlSerilizable<RejectionAndRepairReason37Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectionAndRepairReason37Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RejectionAndRepairReason37Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RejectionAndRepairReason37Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectionAndRepairReason37Choice choice.")
        };
    }
}
