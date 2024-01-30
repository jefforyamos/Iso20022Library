﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessError.  ISO2002 ID# _7-uWs6MgEeCJ6YNENx4h-w_169698143.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrError2Choice;

/// <summary>
/// Reason the requested business information is not given.
/// </summary>
public partial record BusinessError : IStandingOrderOrError2Choice
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
