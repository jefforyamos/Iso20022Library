﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CancellationStatusReport.  ISO2002 ID# _n7iikkgrEeaD2L_hzZaE0w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Status26Choice;

/// <summary>
/// Status report details of a bulk or multiple or switch order cancellation message.
/// </summary>
public partial record CancellationStatusReport : IStatus26Choice
{
    #nullable enable
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Cancellation status of the order cancellation.
    /// </summary>
    public required ICancellationStatus22Choice CancellationStatus { get; init; } 
    /// <summary>
    /// Party that initiates the status of the order cancellation.
    /// </summary>
    public PartyIdentification113? StatusInitiator { get; init; } 
    #nullable disable
}
