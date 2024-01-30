﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _g7Miw2CJEeabZtzjEVWYCQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingOpeningStatusReason1Choice;

/// <summary>
/// Reason for the pending account opening status.
/// </summary>
public partial record Reason : IPendingOpeningStatusReason1Choice
{
    #nullable enable
    /// <summary>
    /// Reason for the pending account opening status.
    /// </summary>
    public required IPendingOpeningStatusReason2Choice Code { get; init; } 
    /// <summary>
    /// Additional information about the reason for the pending account opening status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
