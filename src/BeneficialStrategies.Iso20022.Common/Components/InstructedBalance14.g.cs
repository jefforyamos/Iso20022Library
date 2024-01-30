﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructedBalance14.  ISO2002 ID# _2IO4s-6KEeqc-LCjwLsUVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about total instructed balance.
/// </summary>
public partial record InstructedBalance14
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    public required IBalanceFormat5Choice TotalInstructedBalance { get; init; } 
    /// <summary>
    /// Daily total of all accepted instructions for given day.  Cover protect instructions will be included in this total balance.
    /// </summary>
    public SignedQuantityFormat6? TotalAcceptedInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of cancelled instructions for a given day.
    /// </summary>
    public SignedQuantityFormat6? TotalCancelledInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of pending instructions in pending status.  It includes cancel pending instructions.
    /// </summary>
    public SignedQuantityFormat6? TotalPendingInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of rejected instructions.
    /// </summary>
    public SignedQuantityFormat6? TotalRejectedInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of all protect instructions sent in a given day.
    /// </summary>
    public SignedQuantityFormat6? TotalProtectInstructionBalance { get; init; } 
    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    public InstructedCorporateActionOption15? OptionDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
