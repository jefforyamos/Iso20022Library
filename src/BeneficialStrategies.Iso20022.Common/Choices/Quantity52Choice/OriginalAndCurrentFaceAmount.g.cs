﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OriginalAndCurrentFaceAmount.  ISO2002 ID# _OovFmRuyEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity52Choice;

/// <summary>
/// Face amount and amortised value of security.
/// </summary>
public partial record OriginalAndCurrentFaceAmount : IQuantity52Choice
{
    #nullable enable
    /// <summary>
    /// Quantity expressed as an amount representing the face amount, that is, the principal of a debt instrument.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount FaceAmount { get; init; } 
    /// <summary>
    /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond's principal amount.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount AmortisedValue { get; init; } 
    #nullable disable
}
