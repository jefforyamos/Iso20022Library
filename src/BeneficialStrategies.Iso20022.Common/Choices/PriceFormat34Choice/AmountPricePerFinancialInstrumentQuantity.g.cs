﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountPricePerFinancialInstrumentQuantity.  ISO2002 ID# _msc3dSXxEeO4bIO_HtGo9Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat34Choice;

/// <summary>
/// Price expressed as a ratio: amount price per financial instrument quantity.
/// </summary>
public partial record AmountPricePerFinancialInstrumentQuantity : IPriceFormat34Choice
{
    #nullable enable
    /// <summary>
    /// Type of amount price.
    /// </summary>
    public required AmountPriceType1Code AmountPriceType { get; init; } 
    /// <summary>
    /// Value of the price.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    public required IFinancialInstrumentQuantity1Choice FinancialInstrumentQuantity { get; init; } 
    #nullable disable
}
