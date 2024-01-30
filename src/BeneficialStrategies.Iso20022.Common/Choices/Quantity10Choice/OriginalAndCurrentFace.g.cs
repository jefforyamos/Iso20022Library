﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OriginalAndCurrentFace.  ISO2002 ID# _WsJF5dp-Ed-ak6NoX_4Aeg_-845510532.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity10Choice;

/// <summary>
/// Original and current value of an asset-back instrument.
/// </summary>
public partial record OriginalAndCurrentFace : IQuantity10Choice
{
    #nullable enable
    /// <summary>
    /// Quantity expressed as an amount representing the face amount, that is, the principal of a debt instrument.
    /// </summary>
    public required IsoRestrictedFINImpliedCurrencyAndAmount FaceAmount { get; init; } 
    /// <summary>
    /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond's principal amount.
    /// </summary>
    public required IsoRestrictedFINImpliedCurrencyAndAmount AmortisedValue { get; init; } 
    #nullable disable
}
