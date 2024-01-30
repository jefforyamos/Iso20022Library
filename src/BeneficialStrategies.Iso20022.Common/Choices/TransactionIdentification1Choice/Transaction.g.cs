﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Transaction.  ISO2002 ID# _lv0vQK7LEemZxoEFHjN-AQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TransactionIdentification1Choice;

/// <summary>
/// Provides identification of the securities financial transaction.
/// </summary>
public partial record Transaction : ITransactionIdentification1Choice
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
    /// Unique trade Identifier (UTI) as agreed with the counterparty.
    /// </summary>
    public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    public MasterAgreement6? MasterAgreement { get; init; } 
    /// <summary>
    /// Identification of the agent lender involved in the securities lending transaction.
    /// </summary>
    public IOrganisationIdentification9Choice? AgentLender { get; init; } 
    /// <summary>
    /// Identification of the third party that administers the transaction.
    /// </summary>
    public IOrganisationIdentification9Choice? TripartyAgent { get; init; } 
    #nullable disable
}
