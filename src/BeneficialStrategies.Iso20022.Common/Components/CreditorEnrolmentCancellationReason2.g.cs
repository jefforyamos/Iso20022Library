﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditorEnrolmentCancellationReason2.  ISO2002 ID# _Ufpx-eH7Eeqbls7Gk4-ckA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the creditor enrolment cancellation request.
/// </summary>
public partial record CreditorEnrolmentCancellationReason2
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    public RTPPartyIdentification1? Originator { get; init; } 
    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    public required CreditorEnrolmentCancellationReason1Choice_ Reason { get; init; } 
    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    public IsoMax105Text[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
