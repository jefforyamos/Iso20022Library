﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VoteTypeAndQuantity1.  ISO2002 ID# _X_oUcPNBEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of vote that can be provided for a resolution in a general meeting.
/// </summary>
public partial record VoteTypeAndQuantity1
{
    #nullable enable
    
    /// <summary>
    /// Types of vote instruction allowed for resolutions to be voted on in general meeting.
    /// </summary>
    public required VoteInstructionType1Choice_ VoteInstructionType { get; init; } 
    /// <summary>
    /// Quantity of vote expressed for the specified type of vote instruction.
    /// </summary>
    public required IsoNumber VoteQuantity { get; init; } 
    
    #nullable disable
}
