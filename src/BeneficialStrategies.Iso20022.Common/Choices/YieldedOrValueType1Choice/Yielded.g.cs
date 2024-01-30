﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Yielded.  ISO2002 ID# _RdBVp9p-Ed-ak6NoX_4Aeg_599544874.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.YieldedOrValueType1Choice;

/// <summary>
/// Indicates whether the price is expressed as a yield.
/// </summary>
public partial record Yielded : IYieldedOrValueType1Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
