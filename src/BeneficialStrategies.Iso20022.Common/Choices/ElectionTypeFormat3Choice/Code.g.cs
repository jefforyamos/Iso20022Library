﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _TzuzcUEGEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ElectionTypeFormat3Choice;

/// <summary>
/// Standard code to specify the effect on the holdings of electing a corporate action option.
/// </summary>
public partial record Code : ElectionTypeFormat3Choice_
{
    public required ElectionMovementType2Code Value { get; init; }
}
