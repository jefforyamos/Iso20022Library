﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CancelledStatusReason6.  ISO2002 ID# _X0CsYeJxEd-Q6MzBzY5WkA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies reasons for the cancelled status.
/// </summary>
public partial record CancelledStatusReason6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction or instruction cancellation has been cancelled.
    /// </summary>
    public required CancelledReason3Choice_ ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
