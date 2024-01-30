﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ISA.  ISO2002 ID# _L26-t_sqEeCXvelB0HU7AQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ISAPortfolio3Choice;

/// <summary>
/// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax. 
/// The Individual Savings Account (ISA) is provided only by UK based financial institutions.
/// </summary>
public partial record ISA : IISAPortfolio3Choice
{
    #nullable enable
    /// <summary>
    /// ISA that was issued during the current fiscal year.
    /// </summary>
    public ICurrentYearType2Choice? CurrentYear { get; init; } 
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    public IPreviousYearChoice? PreviousYears { get; init; } 
    #nullable disable
}
