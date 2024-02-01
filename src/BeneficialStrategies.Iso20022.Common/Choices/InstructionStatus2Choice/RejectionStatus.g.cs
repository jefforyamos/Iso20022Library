﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RejectionStatus.  ISO2002 ID# _RWwVkdp-Ed-ak6NoX_4Aeg_-1258577092.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus2Choice;

/// <summary>
/// Status advising on the rejection of the instruction.
/// </summary>
public partial record RejectionStatus : InstructionStatus2Choice_
{
    #nullable enable
    /// <summary>
    /// Reason advising the rejection of the instruction.
    /// </summary>
    public required RejectionReason1Code Reason { get; init; } 
    /// <summary>
    /// This code can be used in case another reason is required.
    /// </summary>
    public required IsoExtended350Code ExtendedReason { get; init; } 
    /// <summary>
    /// Additional information about the reason.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
