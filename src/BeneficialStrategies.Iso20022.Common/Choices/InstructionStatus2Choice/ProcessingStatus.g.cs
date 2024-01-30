﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProcessingStatus.  ISO2002 ID# _RWwVkNp-Ed-ak6NoX_4Aeg_-1271508072.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus2Choice;

/// <summary>
/// Status advising on the processing of the instruction.
/// </summary>
public partial record ProcessingStatus : IInstructionStatus2Choice
{
    #nullable enable
    /// <summary>
    /// Status on the processing of the instructions.
    /// </summary>
    public required Status3Code Status { get; init; } 
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
