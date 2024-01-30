﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CashSSIPurpose.  ISO2002 ID# _3LyNoUiNEeOdL6nMHefDgg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MarketIdentificationOrCashPurpose1Choice;

/// <summary>
/// Underlying reason for the payment SSI instruction, expressed as a code.
/// </summary>
public partial record CashSSIPurpose : IMarketIdentificationOrCashPurpose1Choice
{
    public required ExternalMarketArea1Code Value { get; init; }
}
