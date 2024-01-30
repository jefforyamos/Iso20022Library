﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProcessedStatus.  ISO2002 ID# _RiPM1tp-Ed-ak6NoX_4Aeg_-1805228847.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionMovementStatus1Choice;

/// <summary>
/// Provides information about the processing status of the movement.
/// </summary>
public partial record ProcessedStatus : ICorporateActionMovementStatus1Choice
{
    #nullable enable
    /// <summary>
    /// The processing status.
    /// </summary>
    public required IProcessedStatus3FormatChoice Status { get; init; } 
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
