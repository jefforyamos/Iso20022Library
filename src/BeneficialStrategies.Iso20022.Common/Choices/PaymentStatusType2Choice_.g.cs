﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentStatusType2Choice.  ISO2002 ID# _CuMfQSYMEei7VPGVFTQkxA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Indicates the status of the payment, either as a raw status, or as a detailed status.
/// </summary>
[KnownType(typeof(PaymentStatusType2Choice.RawStatus))]
[KnownType(typeof(PaymentStatusType2Choice.DetailedStatus))]
public abstract partial record PaymentStatusType2Choice_ : IIsoXmlSerilizable<PaymentStatusType2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PaymentStatusType2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "RawSts" => PaymentStatusType2Choice.RawStatus.Deserialize(elementWithPayload),
             "DtldSts" => PaymentStatusType2Choice.DetailedStatus.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PaymentStatusType2Choice choice.")
        };
    }
}
