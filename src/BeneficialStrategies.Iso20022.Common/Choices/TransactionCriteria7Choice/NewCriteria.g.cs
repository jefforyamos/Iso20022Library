﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NewCriteria.  ISO2002 ID# _-S2D0wKxEe2rHs6fbn9-0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionCriteria7Choice;

/// <summary>
/// Explicitly defines the query criteria.
/// </summary>
public partial record NewCriteria : ITransactionCriteria7Choice
{
    #nullable enable
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    public IsoMax35Text? NewQueryName { get; init; } 
    /// <summary>
    /// Defines the criteria on which the information is extracted.
    /// </summary>
    public TransactionSearchCriteria10? SearchCriteria { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates the format of the requested report.
    /// </summary>
    public ReportIndicator1Code? StatementReport { get; init; } 
    /// <summary>
    /// Defines the expected payment transaction report.
    /// </summary>
    public TransactionReturnCriteria5? ReturnCriteria { get; init; } 
    #nullable disable
}
