﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Period.  ISO2002 ID# __aOTka5OEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TimeToMaturity2Choice;

/// <summary>
/// Provides the period for the time to maturity.
/// </summary>
public partial record Period : ITimeToMaturity2Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the start of the maturity period.
    /// </summary>
    public MaturityTerm2? Start { get; init; } 
    /// <summary>
    /// Specifies the end of the maturity period.
    /// </summary>
    public MaturityTerm2? End { get; init; } 
    #nullable disable
}
