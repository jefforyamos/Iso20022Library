﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _rTiaRS87EeKNZpaVtgp8Wg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OfferTypeFormat3Choice;

/// <summary>
/// Standard code to specify the conditions that apply to the offer.
/// </summary>
public partial record Code : IOfferTypeFormat3Choice
{
    public required OfferType2Code Value { get; init; }
}
