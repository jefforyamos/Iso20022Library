﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountPricePerFinancialInstrumentQuantity.  ISO2002 ID# _ssPABaFWEeSK_vfd3NHBGg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormatSD2Choice;

/// <summary>
/// Price expressed as a ratio: amount price per financial instrument quantity.
/// </summary>
public partial record AmountPricePerFinancialInstrumentQuantity : PriceFormatSD2Choice_
{
    #nullable enable
    /// <summary>
    /// Type of amount price.
    /// </summary>
    public required AmountPriceType1Code AmountPriceType { get; init; } 
    /// <summary>
    /// Value of the price.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    public required FinancialInstrumentQuantity15Choice_ FinancialInstrumentQuantity { get; init; } 
    #nullable disable
}
