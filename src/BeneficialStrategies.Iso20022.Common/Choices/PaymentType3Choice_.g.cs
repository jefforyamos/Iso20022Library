﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentType3Choice.  ISO2002 ID# _72PJGKMgEeCJ6YNENx4h-w_1987696295.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a payment type from a predefined list and a proprietary payment type.
/// </summary>
[KnownType(typeof(PaymentType3Choice.Code))]
[KnownType(typeof(PaymentType3Choice.Proprietary))]
public abstract partial record PaymentType3Choice_ : IIsoXmlSerilizable<PaymentType3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PaymentType3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => PaymentType3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => PaymentType3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PaymentType3Choice choice.")
        };
    }
}
