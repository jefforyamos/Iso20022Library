﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NewCriteria.  ISO2002 ID# _U5qyVZlQEee-Zps0fZQaFQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TransactionCriteria4Choice;

/// <summary>
/// Explicitly defines the query criteria.
/// </summary>
public partial record NewCriteria : ITransactionCriteria4Choice
{
    #nullable enable
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    public IsoMax35Text? NewQueryName { get; init; } 
    /// <summary>
    /// Defines the criteria on which the information is extracted.
    /// </summary>
    public TransactionSearchCriteria7? SearchCriteria { get; init;  } // Warning: Don't know multiplicity.
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
