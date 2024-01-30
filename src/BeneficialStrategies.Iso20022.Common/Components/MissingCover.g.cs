﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MissingCover.  ISO2002 ID# _T9zQWdp-Ed-ak6NoX_4Aeg_-539916461.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates that the claim for non receipt is effectively a missing cover.
/// </summary>
public partial record MissingCover
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not the claim is related to a missing cover.
    /// </summary>
    public required IsoYesNoIndicator MissingCoverIndication { get; init; } 
    
    #nullable disable
}
