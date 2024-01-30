﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptedStatusReason11.  ISO2002 ID# _6HWbl5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies reasons for the accepted status.
/// </summary>
public partial record AcceptedStatusReason11
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction has been accepted.
    /// </summary>
    public required IAcceptedReason12Choice ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
