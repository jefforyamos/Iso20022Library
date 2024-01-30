﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessError.  ISO2002 ID# _fFDdU9cZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountOrBusinessError5Choice;

/// <summary>
/// Reason the requested business information is not given.
/// </summary>
public partial record BusinessError : IAccountOrBusinessError5Choice
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
