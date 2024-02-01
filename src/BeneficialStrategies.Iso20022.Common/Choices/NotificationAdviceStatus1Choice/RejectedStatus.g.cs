﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RejectedStatus.  ISO2002 ID# _Ri1Ct9p-Ed-ak6NoX_4Aeg_348378582.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NotificationAdviceStatus1Choice;

/// <summary>
/// Provides information about the rejection status.
/// </summary>
public partial record RejectedStatus : NotificationAdviceStatus1Choice_
{
    #nullable enable
    /// <summary>
    /// The rejection reason.
    /// </summary>
    public RejectionReason6FormatChoice_? Reason { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
