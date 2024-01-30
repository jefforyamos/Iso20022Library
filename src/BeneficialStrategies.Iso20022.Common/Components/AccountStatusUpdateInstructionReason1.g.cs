﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountStatusUpdateInstructionReason1.  ISO2002 ID# _qkYIgXi8EeaRm5xIK6nGuQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for an update to an account status.
/// </summary>
public partial record AccountStatusUpdateInstructionReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the instruction to change the account status.
    /// </summary>
    public IAccountStatusUpdateInstructionReason2Choice? Code { get; init; } 
    /// <summary>
    /// Additional information about the reason for the instruction to change the account status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
