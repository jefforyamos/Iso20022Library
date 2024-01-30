﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OperationalError.  ISO2002 ID# _-DiXczpvEemk2e6qGBk8IQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CollateralValueReportOrError5Choice;

/// <summary>
/// Indicates whether an operational error has been issued during the processing of the related request.
/// </summary>
public partial record OperationalError : ICollateralValueReportOrError5Choice
{
    #nullable enable
    /// <summary>
    /// Specification of the error, in coded or proprietary form.
    /// </summary>
    public required IErrorHandling3Choice Error { get; init; } 
    /// <summary>
    /// Specification of the error, in free format.
    /// </summary>
    public IsoMax140Text? Description { get; init; } 
    #nullable disable
}
