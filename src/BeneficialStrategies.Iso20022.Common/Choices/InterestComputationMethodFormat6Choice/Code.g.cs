﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _oDMjMyDuEeahCJeThTBhHA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InterestComputationMethodFormat6Choice;

/// <summary>
/// Standard code to specify the method used to compute accruing interest of a financial instrument.
/// </summary>
public partial record Code : IInterestComputationMethodFormat6Choice
{
    public required InterestComputationMethod1Code Value { get; init; }
}
