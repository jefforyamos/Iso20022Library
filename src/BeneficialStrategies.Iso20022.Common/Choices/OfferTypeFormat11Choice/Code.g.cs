﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _cta95ZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OfferTypeFormat11Choice;

/// <summary>
/// Standard code to specify the conditions that apply to the offer.
/// </summary>
public partial record Code : IOfferTypeFormat11Choice
{
    public required OfferType3Code Value { get; init; }
}
