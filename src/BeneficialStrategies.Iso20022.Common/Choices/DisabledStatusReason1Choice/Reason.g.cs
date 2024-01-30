﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _R5FfA0zAEeafiMTDrtSnyw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DisabledStatusReason1Choice;

/// <summary>
/// Reason for the disabled account status.
/// </summary>
public partial record Reason : IDisabledStatusReason1Choice
{
    #nullable enable
    /// <summary>
    /// Reason for the disabled account status.
    /// </summary>
    public required IDisabledStatusReason2Choice Code { get; init; } 
    /// <summary>
    /// Additional information about the reason for the disabled account status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
