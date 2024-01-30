﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptedStatusReason10.  ISO2002 ID# _cgn4CZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies reasons for the accepted status.
/// </summary>
public partial record AcceptedStatusReason10
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction or instruction cancellation has been accepted.
    /// </summary>
    public required IAcceptedReason11Choice ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
