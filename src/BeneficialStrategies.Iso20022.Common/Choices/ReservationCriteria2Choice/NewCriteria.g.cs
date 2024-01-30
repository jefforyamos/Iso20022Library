﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NewCriteria.  ISO2002 ID# _kmHRhZlaEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ReservationCriteria2Choice;

/// <summary>
/// Defines the criteria based on which the information is extracted.
/// </summary>
public partial record NewCriteria : IReservationCriteria2Choice
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
