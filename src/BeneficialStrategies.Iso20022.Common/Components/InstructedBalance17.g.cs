﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructedBalance17.  ISO2002 ID# _pf2NhTi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about total instructed balance.
/// </summary>
public partial record InstructedBalance17
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    public required IBalanceFormat14Choice TotalInstructedBalance { get; init; } 
    /// <summary>
    /// Daily total of all accepted instructions for given day.  Cover protect instructions will be included in this total balance.
    /// </summary>
    public SignedQuantityFormat13? TotalAcceptedInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of cancelled instructions for a given day.
    /// </summary>
    public SignedQuantityFormat13? TotalCancelledInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of pending instructions in pending status.  It includes cancel pending instructions.
    /// </summary>
    public SignedQuantityFormat13? TotalPendingInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of rejected instructions.
    /// </summary>
    public SignedQuantityFormat13? TotalRejectedInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of all protect instructions sent in a given day.
    /// </summary>
    public SignedQuantityFormat13? TotalProtectInstructionBalance { get; init; } 
    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    public InstructedCorporateActionOption18? OptionDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
