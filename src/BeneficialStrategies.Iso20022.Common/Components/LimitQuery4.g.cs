﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LimitQuery4.  ISO2002 ID# _E2br6W4-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the query criteria.
/// </summary>
public partial record LimitQuery4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    public QueryType2Code? QueryType { get; init; } 
    /// <summary>
    /// Defines the limit query criteria.
    /// </summary>
    public ILimitCriteria6Choice? LimitCriteria { get; init; } 
    
    #nullable disable
}
