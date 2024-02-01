﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _UUAJ09p-Ed-ak6NoX_4Aeg_-805776505.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus3Choice;

/// <summary>
/// Specifies the reason of the CancellationStatus.
/// </summary>
public partial record Reason : CancellationStatus3Choice_
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction is cancelled.
    /// </summary>
    public required CancellationReason3Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
