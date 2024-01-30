﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessError.  ISO2002 ID# _kzT6Ee5NEeCisYr99QEiWA_-1877087360.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AuditTrailOrBusinessError1Choice;

/// <summary>
/// Business error resulting from a rejection.
/// </summary>
public partial record BusinessError : IAuditTrailOrBusinessError1Choice
{
    #nullable enable
    /// <summary>
    /// Specification of the error, in coded or proprietary form.
    /// </summary>
    public required IErrorHandling1Choice Error { get; init; } 
    /// <summary>
    /// Specification of the error, in free format.
    /// </summary>
    public IsoMax140Text? Description { get; init; } 
    #nullable disable
}
