﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RepairReason11.  ISO2002 ID# _6BGpVZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the instruction is in repair.
/// </summary>
public partial record RepairReason11
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejected or repair status.
    /// </summary>
    public required RepairReason13Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
