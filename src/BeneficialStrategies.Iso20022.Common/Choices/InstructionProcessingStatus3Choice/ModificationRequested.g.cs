﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ModificationRequested.  ISO2002 ID# _UZg799p-Ed-ak6NoX_4Aeg_-41941340.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus3Choice;

/// <summary>
/// Modification request from your counterparty for this transaction is pending waiting for your cancellation request or your consent.
/// </summary>
public partial record ModificationRequested : IInstructionProcessingStatus3Choice
{
    #nullable enable
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #nullable disable
}
