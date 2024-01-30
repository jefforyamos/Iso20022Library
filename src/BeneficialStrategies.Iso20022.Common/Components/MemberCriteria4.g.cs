﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MemberCriteria4.  ISO2002 ID# _iwxEdXSbEeiH1ZOt2UD8vQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a member and to report on the member. A name may be given to the new query.
/// </summary>
public partial record MemberCriteria4
{
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    public IsoMax35Text? NewQueryName { get; init; } 
    /// <summary>
    /// Defines the criteria based on which the information is extracted.
    /// </summary>
    public MemberSearchCriteria4? SearchCriteria { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Defines the expected report.
    /// </summary>
    public MemberReturnCriteria1? ReturnCriteria { get; init; } 
    
    #nullable disable
}
