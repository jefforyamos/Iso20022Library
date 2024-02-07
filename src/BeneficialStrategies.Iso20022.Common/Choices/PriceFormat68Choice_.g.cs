﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceFormat68Choice.  ISO2002 ID# _plY1dTi7Eeydid5dcNPKvg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a percentage price or an amount price or an amount price per amount or an amount price per financial instrument quantity.
/// </summary>
[KnownType(typeof(PriceFormat68Choice.PercentagePrice))]
[KnownType(typeof(PriceFormat68Choice.AmountPrice))]
[KnownType(typeof(PriceFormat68Choice.AmountPricePerFinancialInstrumentQuantity))]
[KnownType(typeof(PriceFormat68Choice.AmountPricePerAmount))]
[KnownType(typeof(PriceFormat68Choice.IndexPoints))]
public abstract partial record PriceFormat68Choice_ : IIsoXmlSerilizable<PriceFormat68Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PriceFormat68Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PctgPric" => PriceFormat68Choice.PercentagePrice.Deserialize(elementWithPayload),
             "AmtPric" => PriceFormat68Choice.AmountPrice.Deserialize(elementWithPayload),
             "AmtPricPerFinInstrmQty" => PriceFormat68Choice.AmountPricePerFinancialInstrumentQuantity.Deserialize(elementWithPayload),
             "AmtPricPerAmt" => PriceFormat68Choice.AmountPricePerAmount.Deserialize(elementWithPayload),
             "IndxPts" => PriceFormat68Choice.IndexPoints.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PriceFormat68Choice choice.")
        };
    }
}
