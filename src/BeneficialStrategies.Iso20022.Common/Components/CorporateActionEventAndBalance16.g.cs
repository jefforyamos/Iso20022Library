﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionEventAndBalance16.  ISO2002 ID# _D3TvIffQEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed account holdings information report for a corporate action event.
/// </summary>
public partial record CorporateActionEventAndBalance16
{
    #nullable enable
    
    /// <summary>
    /// Provides general information related to a corporate action event.
    /// </summary>
    public required EventInformation12 GeneralInformation { get; init; } 
    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    public required SecurityIdentification20 UnderlyingSecurity { get; init; } 
    /// <summary>
    /// Provides information about the balance related to a corporate action.
    /// </summary>
    public CorporateActionBalanceDetails40? Balance { get; init; } 
    /// <summary>
    /// Provides additional information related to the event and the balance of the corporate action.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
