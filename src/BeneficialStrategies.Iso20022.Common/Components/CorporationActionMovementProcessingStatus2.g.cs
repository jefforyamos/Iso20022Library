﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporationActionMovementProcessingStatus2.  ISO2002 ID# _RlNoWNp-Ed-ak6NoX_4Aeg_1529464275.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides processing status of the movement cancellation request.
/// </summary>
public partial record CorporationActionMovementProcessingStatus2
{
    #nullable enable
    
    /// <summary>
    /// The processing status.
    /// </summary>
    public required ProcessedStatus2FormatChoice_ Status { get; init; } 
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
