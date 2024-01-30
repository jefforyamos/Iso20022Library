﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _KCJi2TnuEeWfSKvvZlhRKg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectionOrRepairStatus29Choice;

/// <summary>
/// Specifies the reason of the rejection or repair status.
/// </summary>
public partial record Reason : IRejectionOrRepairStatus29Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejected or repair status.
    /// </summary>
    public IRejectionAndRepairReason23Choice? Code { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
