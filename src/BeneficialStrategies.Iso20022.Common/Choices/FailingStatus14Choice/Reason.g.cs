﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _f99yDTi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FailingStatus14Choice;

/// <summary>
/// Specifies the reason of the failing status.
/// </summary>
public partial record Reason : FailingStatus14Choice_
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction has a failing status.
    /// </summary>
    public required FailingReason17Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
