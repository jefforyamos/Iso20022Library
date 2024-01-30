﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for InstructionCancellationIdentification.  ISO2002 ID# _RCWL1tp-Ed-ak6NoX_4Aeg_2114144001.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionType1Choice;

/// <summary>
/// Identifies the meeting instruction cancellation request message for which the status is provided.
/// </summary>
public partial record InstructionCancellationIdentification : IInstructionType1Choice
{
    #nullable enable
    /// <summary>
    /// String of characters that uniquely identifies a message.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    #nullable disable
}
