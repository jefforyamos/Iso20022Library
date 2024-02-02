﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReservationCriteria6.  ISO2002 ID# _xpxD1Qy_Ee2Wmf2RrXviyA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria to extract the reservation information and the expected reservation report. A name may be given to the new query.
/// </summary>
[DataContract]
[XmlType]
public partial record ReservationCriteria6
{
    #nullable enable
    
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [DataMember]
    public IsoMax35Text? NewQueryName { get; init; } 
    /// <summary>
    /// Defines the criteria to extract the reservation information.
    /// </summary>
    [DataMember]
    public ValueList<ReservationSearchCriteria5> SearchCriteria { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Defines the expected reservation report.
    /// </summary>
    [DataMember]
    public ReservationReturnCriteria1? ReturnCriteria { get; init; } 
    
    #nullable disable
}
