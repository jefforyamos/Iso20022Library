﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _0ka00glIEeGATtfOBToyew_709869042.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RepairStatus8Choice;

/// <summary>
/// Specifies the reason of the repair status.
/// </summary>
public partial record Reason : IRepairStatus8Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair status.
    /// </summary>
    public required IRepairReason1Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
