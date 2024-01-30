﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _JoF7gTnXEeWLJsP1cO-amg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionProcessingStatus5Choice;

/// <summary>
/// Specifies the status of the details of the corporate action event.
/// </summary>
public partial record Code : ICorporateActionProcessingStatus5Choice
{
    #nullable enable
    /// <summary>
    /// Indicates whether the details provided about an event are complete or incomplete.
    /// </summary>
    public required EventCompletenessStatus1Code EventCompletenessStatus { get; init; } 
    /// <summary>
    /// Indicates the status of the occurrence of an event.
    /// </summary>
    public required EventConfirmationStatus1Code EventConfirmationStatus { get; init; } 
    #nullable disable
}
