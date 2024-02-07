﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SubBalanceQuantity9Choice.  ISO2002 ID# _ciAo3Ti8Eeydid5dcNPKvg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between formats for the balance information.
/// </summary>
[KnownType(typeof(SubBalanceQuantity9Choice.Quantity))]
[KnownType(typeof(SubBalanceQuantity9Choice.Proprietary))]
[KnownType(typeof(SubBalanceQuantity9Choice.QuantityAndAvailability))]
public abstract partial record SubBalanceQuantity9Choice_ : IIsoXmlSerilizable<SubBalanceQuantity9Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SubBalanceQuantity9Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Qty" => SubBalanceQuantity9Choice.Quantity.Deserialize(elementWithPayload),
             "Prtry" => SubBalanceQuantity9Choice.Proprietary.Deserialize(elementWithPayload),
             "QtyAndAvlbty" => SubBalanceQuantity9Choice.QuantityAndAvailability.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SubBalanceQuantity9Choice choice.")
        };
    }
}
