﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CancellationReasonInformation2.  ISO2002 ID# _TOt8yNp-Ed-ak6NoX_4Aeg_993731779.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the reason of the mandate cancellation request.
/// </summary>
public partial record CancellationReasonInformation2
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    public PartyIdentification32? Originator { get; init; } 
    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    public required MandateReason1Choice_ Reason { get; init; } 
    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    public IsoMax105Text[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
