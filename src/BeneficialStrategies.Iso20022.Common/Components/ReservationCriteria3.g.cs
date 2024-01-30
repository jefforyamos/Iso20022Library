﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReservationCriteria3.  ISO2002 ID# _kmHRh5laEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria to extract the reservation information and the expected reservation report. A name may be given to the new query.
/// </summary>
public partial record ReservationCriteria3
{
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    public IsoMax35Text? NewQueryName { get; init; } 
    /// <summary>
    /// Defines the criteria to extract the reservation information.
    /// </summary>
    public ReservationSearchCriteria2? SearchCriteria { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Defines the expected reservation report.
    /// </summary>
    public ReservationReturnCriteria1? ReturnCriteria { get; init; } 
    
    #nullable disable
}
