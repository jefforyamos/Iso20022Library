﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProcessedStatus.  ISO2002 ID# _RiYWwdp-Ed-ak6NoX_4Aeg_-416590020.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionDeactivationCancellationStatus1Choice;

/// <summary>
/// Provides information about the processing status of the cancellation request.
/// </summary>
public partial record ProcessedStatus : CorporateActionDeactivationCancellationStatus1Choice_
{
    #nullable enable
    /// <summary>
    /// The processing status.
    /// </summary>
    public required ProcessedStatus2FormatChoice_ Status { get; init; } 
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
