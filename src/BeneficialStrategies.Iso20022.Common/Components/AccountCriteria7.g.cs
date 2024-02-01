﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountCriteria7.  ISO2002 ID# _PxA_l249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for an account and to report on the account. A name may be given to the new query.
/// </summary>
public partial record AccountCriteria7
{
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    public IsoMax35Text? NewQueryName { get; init; } 
    /// <summary>
    /// Defines the criteria to be used to extract the account information.
    /// </summary>
    public CashAccountSearchCriteria7[] SearchCriteria { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Defines the expected account report.
    /// </summary>
    public CashAccountReturnCriteria5? ReturnCriteria { get; init; } 
    
    #nullable disable
}
