﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionEventAndBalance17.  ISO2002 ID# _21VMj-XmEemEj48jhmlA0Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed account holdings information report for a corporate action event.
/// </summary>
public partial record CorporateActionEventAndBalance17
{
    #nullable enable
    
    /// <summary>
    /// Provides general information related to a corporate action event.
    /// </summary>
    public required EventInformation13 GeneralInformation { get; init; } 
    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    public required SecurityIdentification19 UnderlyingSecurity { get; init; } 
    /// <summary>
    /// Provides information about the balance related to a corporate action.
    /// </summary>
    public CorporateActionBalance41? Balance { get; init; } 
    /// <summary>
    /// Provides additional information related to the event and the balance of the corporate action.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
