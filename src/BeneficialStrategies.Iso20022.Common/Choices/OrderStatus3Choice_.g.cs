﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OrderStatus3Choice.  ISO2002 ID# _uvD4kUH7EeaV3ab_pHzFIQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of status for an order.
/// </summary>
[KnownType(typeof(OrderStatus3Choice.Status))]
[KnownType(typeof(OrderStatus3Choice.Cancelled))]
[KnownType(typeof(OrderStatus3Choice.ConditionallyAccepted))]
[KnownType(typeof(OrderStatus3Choice.Rejected))]
[KnownType(typeof(OrderStatus3Choice.Suspended))]
[KnownType(typeof(OrderStatus3Choice.PartiallySettled))]
public abstract partial record OrderStatus3Choice_ : IIsoXmlSerilizable<OrderStatus3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static OrderStatus3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Sts" => OrderStatus3Choice.Status.Deserialize(elementWithPayload),
             "Canc" => OrderStatus3Choice.Cancelled.Deserialize(elementWithPayload),
             "CondlyAccptd" => OrderStatus3Choice.ConditionallyAccepted.Deserialize(elementWithPayload),
             "Rjctd" => OrderStatus3Choice.Rejected.Deserialize(elementWithPayload),
             "Sspd" => OrderStatus3Choice.Suspended.Deserialize(elementWithPayload),
             "PrtlySttld" => OrderStatus3Choice.PartiallySettled.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid OrderStatus3Choice choice.")
        };
    }
}
