﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _2cgUcZEjEeakHoV5BVecAQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.LendingTransactionMethod2Choice;

/// <summary>
/// Lending transaction method expressed as a ISO20022 code.
/// </summary>
public partial record Code : ILendingTransactionMethod2Choice
{
    public required LendingTransactionMethod1Code Value { get; init; }
}
