﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReservationQuery2.  ISO2002 ID# _kWL_IZlaEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the reservation query criteria.
/// </summary>
public partial record ReservationQuery2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    public QueryType2Code? QueryType { get; init; } 
    /// <summary>
    /// Defines the reservation query criteria.
    /// </summary>
    public ReservationCriteria2Choice_? ReservationCriteria { get; init; } 
    
    #nullable disable
}
