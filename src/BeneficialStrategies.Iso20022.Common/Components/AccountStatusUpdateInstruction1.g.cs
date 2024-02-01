﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountStatusUpdateInstruction1.  ISO2002 ID# _et6_QHi5EeaRm5xIK6nGuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction for a change to an account status and reason for the change.
/// </summary>
public partial record AccountStatusUpdateInstruction1
{
    #nullable enable
    
    /// <summary>
    /// Type of status change instructed for the account status.
    /// </summary>
    public required AccountStatusUpdateInstruction1Choice_ UpdateInstruction { get; init; } 
    /// <summary>
    /// Reason for the instruction to change the account status.
    /// </summary>
    public AccountStatusUpdateInstructionReason1Choice_? UpdateInstructionReason { get; init; } 
    
    #nullable disable
}
