﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptanceResult6.  ISO2002 ID# _RBvu4dp-Ed-ak6NoX_4Aeg_2046006177.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide detailed information on the acceptance result.
/// </summary>
public partial record AcceptanceResult6
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the mandate request was accepted or rejected.
    /// </summary>
    public required IsoYesNoIndicator Accepted { get; init; } 
    /// <summary>
    /// Specifies the reason for the rejection of a mandate request.
    /// </summary>
    public IMandateReason1Choice? RejectReason { get; init; } 
    /// <summary>
    /// Further details on the reject reason.
    /// </summary>
    public IsoMax105Text? AdditionalRejectReasonInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
