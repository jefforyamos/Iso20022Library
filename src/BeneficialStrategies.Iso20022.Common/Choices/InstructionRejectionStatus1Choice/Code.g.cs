﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RCfVxtp-Ed-ak6NoX_4Aeg_-867514428.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionRejectionStatus1Choice;

/// <summary>
/// Reason advising the rejection of the instruction in the form of a code.
/// </summary>
public partial record Code : IInstructionRejectionStatus1Choice
{
    public required RejectionReason1Code Value { get; init; }
}
