﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for EventStatus.  ISO2002 ID# _Q1O85dp-Ed-ak6NoX_4Aeg_109671588.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionProcessingStatus1Choice;

/// <summary>
/// Specifies the status of the details of the event.
/// </summary>
public partial record EventStatus : CorporateActionProcessingStatus1Choice_
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
