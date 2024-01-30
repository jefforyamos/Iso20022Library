﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionCancellation3.  ISO2002 ID# _OgdE4SXaEeOFIcNWlDEvdQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate action event cancellation status and reason.
/// </summary>
public partial record CorporateActionCancellation3
{
    #nullable enable
    
    /// <summary>
    /// Specifies reasons for cancellation of a corporate action event.
    /// </summary>
    public required CorporateActionCancellationReason1Code CancellationReasonCode { get; init; } 
    /// <summary>
    /// Additional information about cancellation of a corporate action event.
    /// </summary>
    public IsoMax140Text? CancellationReason { get; init; } 
    /// <summary>
    /// Specifies the status of the details of the event.
    /// </summary>
    public required CorporateActionEventStatus1 ProcessingStatus { get; init; } 
    
    #nullable disable
}
