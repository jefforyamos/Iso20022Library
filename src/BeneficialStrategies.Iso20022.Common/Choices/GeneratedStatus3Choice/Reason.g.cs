﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _1ItJwf7sEeCvPoRGOxRobQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GeneratedStatus3Choice;

/// <summary>
/// Specifies the reason of the GeneratedStatus.
/// </summary>
public partial record Reason : IGeneratedStatus3Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the transaction was generated.
    /// </summary>
    public required IGeneratedReasons1Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
