﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RejectedStatus.  ISO2002 ID# _RiPM1Np-Ed-ak6NoX_4Aeg_-878703757.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionInformationStatus1Choice;

/// <summary>
/// Provides information about the rejection status.
/// </summary>
public partial record RejectedStatus : CorporateActionInformationStatus1Choice_
{
    #nullable enable
    /// <summary>
    /// The rejection reason.
    /// </summary>
    public RejectionReason15FormatChoice_? Reason { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
