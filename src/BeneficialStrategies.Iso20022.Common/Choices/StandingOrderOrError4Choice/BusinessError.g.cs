﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessError.  ISO2002 ID# _khrGsxbvEeOy-PlRuFSUzQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrError4Choice;

/// <summary>
/// Reason the requested business information is not given.
/// </summary>
public partial record BusinessError : StandingOrderOrError4Choice_
{
    #nullable enable
    /// <summary>
    /// Specification of the error, in coded or proprietary form.
    /// </summary>
    public required ErrorHandling2Choice_ Error { get; init; } 
    /// <summary>
    /// Specification of the error, in free format.
    /// </summary>
    public IsoMax140Text? Description { get; init; } 
    #nullable disable
}
