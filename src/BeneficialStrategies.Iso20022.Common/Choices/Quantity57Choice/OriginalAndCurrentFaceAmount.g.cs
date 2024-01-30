﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OriginalAndCurrentFaceAmount.  ISO2002 ID# _pf0Ywzi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Quantity57Choice;

/// <summary>
/// Signed face amount and amortised value of security.
/// </summary>
public partial record OriginalAndCurrentFaceAmount : IQuantity57Choice
{
    #nullable enable
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Quantity expressed as an amount representing the face amount, that is, the principal, of a debt instrument.
    /// </summary>
    public required IsoRestrictedFINImpliedCurrencyAndAmount FaceAmount { get; init; } 
    /// <summary>
    /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond's principal amount.
    /// </summary>
    public required IsoRestrictedFINImpliedCurrencyAndAmount AmortisedValue { get; init; } 
    #nullable disable
}
