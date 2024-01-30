﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NewCriteria.  ISO2002 ID# _1dxAk5lZEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GeneralBusinessInformationCriteriaDefinition1Choice;

/// <summary>
/// Defines the criteria based on which the information is extracted.
/// </summary>
public partial record NewCriteria : IGeneralBusinessInformationCriteriaDefinition1Choice
{
    #nullable enable
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    public IsoMax35Text? NewQueryName { get; init; } 
    /// <summary>
    /// Defines the criteria based on which the information is extracted.
    /// </summary>
    public GeneralBusinessInformationSearchCriteria1? SearchCriteria { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Defines the expected report.
    /// </summary>
    public GeneralBusinessInformationReturnCriteria1? ReturnCriteria { get; init; } 
    #nullable disable
}
