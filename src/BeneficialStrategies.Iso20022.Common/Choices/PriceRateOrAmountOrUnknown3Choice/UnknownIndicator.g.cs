﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UnknownIndicator.  ISO2002 ID# _gdOxnc33Eee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmountOrUnknown3Choice;

/// <summary>
/// Indicates whether the market price is unknown.
/// </summary>
public partial record UnknownIndicator : IPriceRateOrAmountOrUnknown3Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
