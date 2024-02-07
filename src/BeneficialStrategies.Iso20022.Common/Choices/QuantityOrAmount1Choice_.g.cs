﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for QuantityOrAmount1Choice.  ISO2002 ID# _Q-K2cNp-Ed-ak6NoX_4Aeg_1028055556.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a quantity expressed in units, face amount or amortised amount and a quantity expressed as an amount.
/// </summary>
[KnownType(typeof(QuantityOrAmount1Choice.Quantity))]
[KnownType(typeof(QuantityOrAmount1Choice.Amount))]
public abstract partial record QuantityOrAmount1Choice_ : IIsoXmlSerilizable<QuantityOrAmount1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static QuantityOrAmount1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Qty" => QuantityOrAmount1Choice.Quantity.Deserialize(elementWithPayload),
             "Amt" => QuantityOrAmount1Choice.Amount.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid QuantityOrAmount1Choice choice.")
        };
    }
}
