﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProcessedStatus.  ISO2002 ID# _RiiHw9p-Ed-ak6NoX_4Aeg_1800632270.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ElectionCancellationStatus1Choice;

/// <summary>
/// Provides information about the processing status of the request.
/// </summary>
public partial record ProcessedStatus : IElectionCancellationStatus1Choice
{
    #nullable enable
    /// <summary>
    /// The processing status.
    /// </summary>
    public required IProcessedStatus5FormatChoice Status { get; init; } 
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
