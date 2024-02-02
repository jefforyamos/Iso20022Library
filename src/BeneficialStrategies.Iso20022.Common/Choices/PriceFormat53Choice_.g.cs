﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceFormat53Choice.  ISO2002 ID# _che0cZKQEeWHWpTQn1FFVg.
//

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a percentage price or an amount price or an unspecified price or an amount price per amount or an amount price per financial instrument quantity.
/// </summary>
[KnownType(typeof(PriceFormat53Choice.PercentagePrice))]
[KnownType(typeof(PriceFormat53Choice.AmountPrice))]
[KnownType(typeof(PriceFormat53Choice.NotSpecifiedPrice))]
[KnownType(typeof(PriceFormat53Choice.AmountPricePerFinancialInstrumentQuantity))]
[KnownType(typeof(PriceFormat53Choice.AmountPricePerAmount))]
[KnownType(typeof(PriceFormat53Choice.IndexPoints))]
[DataContract]
public abstract partial record PriceFormat53Choice_
{
}
