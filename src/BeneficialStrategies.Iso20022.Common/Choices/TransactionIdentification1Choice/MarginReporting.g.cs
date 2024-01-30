﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarginReporting.  ISO2002 ID# _pq7S4K7LEemZxoEFHjN-AQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionIdentification1Choice;

/// <summary>
/// Provides identification of the marfin reporting.
/// </summary>
public partial record MarginReporting : ITransactionIdentification1Choice
{
    #nullable enable
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    public required IOrganisationIdentification9Choice ReportingCounterparty { get; init; } 
    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    public required IOrganisationIdentification9Choice OtherCounterparty { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the collateral portfolio.
    /// </summary>
    public required IsoMax52Text CollateralPortfolioIdentification { get; init; } 
    #nullable disable
}
