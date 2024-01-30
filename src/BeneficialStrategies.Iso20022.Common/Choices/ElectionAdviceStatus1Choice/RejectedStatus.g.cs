﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RejectedStatus.  ISO2002 ID# _RiiHwdp-Ed-ak6NoX_4Aeg_-1292537504.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ElectionAdviceStatus1Choice;

/// <summary>
/// Provides information about the rejection status.
/// </summary>
public partial record RejectedStatus : IElectionAdviceStatus1Choice
{
    #nullable enable
    /// <summary>
    /// The rejection reason.
    /// </summary>
    public IRejectionReason18FormatChoice? Reason { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
