﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for VariableInterestRate.  ISO2002 ID# _Qk1wdNp-Ed-ak6NoX_4Aeg_1389639465.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate1Choice;

/// <summary>
/// Provides details about the variable rate.
/// </summary>
public partial record VariableInterestRate : IInterestRate1Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the index taken into account to calculate the variable interest rate.
    /// </summary>
    public required IsoMax35Text Index { get; init; } 
    /// <summary>
    /// Used to express differences in interest rates, for example, a difference of 0.10% is equivalent to a change of 10 basis points.
    /// </summary>
    public IsoNumber? BasisPointSpread { get; init; } 
    #nullable disable
}
