﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptedStatus1.  ISO2002 ID# _6xutiYeUEemJ1cSJJmVYRQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice between a reason or no reason for the corporate action instruction processing accepted status.
/// </summary>
public partial record AcceptedStatus1
{
    #nullable enable
    
    /// <summary>
    /// Reason not specified.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    
    #nullable disable
}
