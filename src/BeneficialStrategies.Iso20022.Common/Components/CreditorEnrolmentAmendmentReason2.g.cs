﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditorEnrolmentAmendmentReason2.  ISO2002 ID# _UiRoIeH7Eeqbls7Gk4-ckA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the amendment of the creditor enrolment.
/// </summary>
public partial record CreditorEnrolmentAmendmentReason2
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the amendment request.
    /// </summary>
    public RTPPartyIdentification1? Originator { get; init; } 
    /// <summary>
    /// Specifies the reason for the amendment request.
    /// </summary>
    public required CreditorEnrolmentAmendmentReason1Choice_ Reason { get; init; } 
    /// <summary>
    /// Further details on the amendment request reason.
    /// </summary>
    public IsoMax105Text[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
