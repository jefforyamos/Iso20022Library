﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _2a7mCTp5EeWVrPy0StzzSg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FailingStatus9Choice;

/// <summary>
/// Specifies the reason of the failing status.
/// </summary>
public partial record Reason : FailingStatus9Choice_
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction has a failing status.
    /// </summary>
    public required FailingReason7Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
