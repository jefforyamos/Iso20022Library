﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarginReporting.  ISO2002 ID# _hY22A8K4EeuFNp8LZAnorg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TransactionIdentification3Choice;

/// <summary>
/// Provides identification of the margin reporting.
/// </summary>
public partial record MarginReporting : ITransactionIdentification3Choice
{
    #nullable enable
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    public required IOrganisationIdentification15Choice ReportingCounterparty { get; init; } 
    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    public required IPartyIdentification236Choice OtherCounterparty { get; init; } 
    /// <summary>
    /// Unique code identifying that the Financial counterparty responsible for reporting on behalf of the other counterparty.
    /// </summary>
    public IOrganisationIdentification15Choice? EntityResponsibleForReport { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the collateral portfolio.
    /// </summary>
    public IsoMax52Text? CollateralPortfolioIdentification { get; init; } 
    #nullable disable
}
