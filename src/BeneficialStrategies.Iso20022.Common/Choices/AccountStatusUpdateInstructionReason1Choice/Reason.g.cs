﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _NHQjM3i8EeaRm5xIK6nGuQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountStatusUpdateInstructionReason1Choice;

/// <summary>
/// Reason for the instruction to change the account status.
/// </summary>
public partial record Reason : IAccountStatusUpdateInstructionReason1Choice
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
