﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MemberQueryDefinition3.  ISO2002 ID# _tCLRIZlVEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the query criteria.
/// </summary>
public partial record MemberQueryDefinition3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    public QueryType2Code? QueryType { get; init; } 
    /// <summary>
    /// Defines the member query criteria.
    /// </summary>
    public IMemberCriteriaDefinition1Choice? MemberCriteria { get; init; } 
    
    #nullable disable
}
