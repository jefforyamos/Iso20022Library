﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _UZ9n4Np-Ed-ak6NoX_4Aeg_851758260.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus3Choice;

/// <summary>
/// Specifies the reason of the PendingStatus.
/// </summary>
public partial record Reason : IPendingStatus3Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction has a pending status.
    /// </summary>
    public required IPendingReason1Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
