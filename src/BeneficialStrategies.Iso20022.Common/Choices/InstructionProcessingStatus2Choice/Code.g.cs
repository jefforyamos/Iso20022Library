﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UYBuMdp-Ed-ak6NoX_4Aeg_-1515031038.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus2Choice;

/// <summary>
/// Provides the status of an instruction.
/// </summary>
public partial record Code : IInstructionProcessingStatus2Choice
{
    public required InstructionProcessingStatus1Code Value { get; init; }
}
