﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BusinessDayCriteria2.  ISO2002 ID# _yFXaB5lcEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for business day information and to report on the business day information. A name may be given to the new query.
/// </summary>
public partial record BusinessDayCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    public IsoMax35Text? NewQueryName { get; init; } 
    /// <summary>
    /// Defines the criteria on which the information is extracted.
    /// </summary>
    public BusinessDaySearchCriteria2[] SearchCriteria { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Defines the expected report.
    /// </summary>
    public BusinessDayReturnCriteria2? ReturnCriteria { get; init; } 
    
    #nullable disable
}
