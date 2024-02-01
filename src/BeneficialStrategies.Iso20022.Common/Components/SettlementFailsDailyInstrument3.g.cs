﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementFailsDailyInstrument3.  ISO2002 ID# _Gj3jgTOnEeqX8uoQQ3KffQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of financial instruments that are initially recorded or centrally maintained in CSDs (central securities depositories) as defined in the relevant regulation.
/// </summary>
public partial record SettlementFailsDailyInstrument3
{
    #nullable enable
    
    /// <summary>
    /// Shares in companies and other securities equivalent to shares in companies, partnerships or other entities, and depositary receipts in respect of share.
    /// </summary>
    public required SettlementFailsDailyTransactionType1Choice_ Equity { get; init; } 
    /// <summary>
    /// Debt instrument issued by a sovereign issuer.
    /// </summary>
    public required SettlementFailsDailyTransactionType1Choice_ SovereignDebt { get; init; } 
    /// <summary>
    /// Bonds other than sovereign debt.
    /// </summary>
    public required SettlementFailsDailyTransactionType1Choice_ Bond { get; init; } 
    /// <summary>
    /// Securities meeting the criteria laid down in the relevant legislation.
    /// </summary>
    public required SettlementFailsDailyTransactionType1Choice_ OtherTransferableSecurities { get; init; } 
    /// <summary>
    /// Relates to a fund of which at least one unit or share class is traded throughout the day on at least one trading venue and with at least one market maker which takes action to ensure that the price of its units or shares on the trading venue does not vary significantly from its net asset value and, where applicable, from its indicative net asset value, as referred to in the relevant legislation.
    /// </summary>
    public required SettlementFailsDailyTransactionType1Choice_ ExchangeTradedFunds { get; init; } 
    /// <summary>
    /// Units in collective investment undertakings, other than ETFs.
    /// </summary>
    public required SettlementFailsDailyTransactionType1Choice_ CollectiveInvestmentUndertakings { get; init; } 
    /// <summary>
    /// Money market instruments other than sovereign debts.
    /// </summary>
    public required SettlementFailsDailyTransactionType1Choice_ MoneyMarketInstrument { get; init; } 
    /// <summary>
    /// Relates to emission allowances which are tradable according to the relevant legislation.
    /// </summary>
    public required SettlementFailsDailyTransactionType1Choice_ EmissionAllowance { get; init; } 
    /// <summary>
    /// Covers any financial instruments not covered as a dedicated category.
    /// </summary>
    public required SettlementFailsDailyTransactionType1Choice_ Other { get; init; } 
    
    #nullable disable
}
