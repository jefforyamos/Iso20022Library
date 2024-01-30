﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _6QDE15NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepairStatus17Choice;

/// <summary>
/// Specifies the reason of the repair status.
/// </summary>
public partial record Reason : IRepairStatus17Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair status.
    /// </summary>
    public required IRepairReason14Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
