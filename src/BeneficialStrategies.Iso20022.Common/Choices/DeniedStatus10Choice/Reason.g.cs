﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _hJx7uVhgEeS8HfHHd4stCA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeniedStatus10Choice;

/// <summary>
/// Specifies the reason of the DeniedStatus.
/// </summary>
public partial record Reason : IDeniedStatus10Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the request has a denied status.
    /// </summary>
    public required IDeniedReason7Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
