﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Special.  ISO2002 ID# __aOTk65OEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TimeToMaturity2Choice;

/// <summary>
/// Provides the time to maturity when no period is provide.
/// </summary>
public partial record Special : ITimeToMaturity2Choice
{
    public required SpecialPurpose2Code Value { get; init; }
}
