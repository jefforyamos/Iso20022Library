﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RejectionStatus.  ISO2002 ID# _RCpGx9p-Ed-ak6NoX_4Aeg_-1261069059.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus4Choice;

/// <summary>
/// Status advising on the rejection of the instruction.
/// </summary>
public partial record RejectionStatus : InstructionStatus4Choice_
{
    #nullable enable
    /// <summary>
    /// Reason advising the rejection of the instruction.
    /// </summary>
    public required InstructionRejectionStatus1Choice_ Reason { get; init; } 
    /// <summary>
    /// Additional information about the reason.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
