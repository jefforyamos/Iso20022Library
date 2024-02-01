﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmendmentReasonInformation1.  ISO2002 ID# _TOt8wdp-Ed-ak6NoX_4Aeg_-588729591.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the reason of the amendment of the mandate.
/// </summary>
public partial record AmendmentReasonInformation1
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the amendment request.
    /// </summary>
    public PartyIdentification32? Originator { get; init; } 
    /// <summary>
    /// Specifies the reason for the amendment request.
    /// </summary>
    public required MandateReason1Choice_ Reason { get; init; } 
    /// <summary>
    /// Further details on the amendment request reason.
    /// </summary>
    public IsoMax105Text[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
