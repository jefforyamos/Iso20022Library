﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementInternaliserFinancialInstrument1.  ISO2002 ID# _JZgRUO3nEeaWjpoyrnG6Rw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of financial instruments that are initially recorded or centrally maintained in CSDs (central securities depositories) as defined in the relevant regulation.
/// </summary>
public partial record SettlementInternaliserFinancialInstrument1
{
    #nullable enable
    
    /// <summary>
    /// Shares in companies and other securities equivalent to shares in companies, partnerships or other entities, and depositary receipts in respect of share.
    /// </summary>
    public required InternalisationData1 Equity { get; init; } 
    /// <summary>
    /// Debt instrument issued by a sovereign issuer.
    /// </summary>
    public required InternalisationData1 SovereignDebt { get; init; } 
    /// <summary>
    /// Bonds other than sovereign debt.
    /// </summary>
    public required InternalisationData1 Bond { get; init; } 
    /// <summary>
    /// Securities meeting the criteria laid down in the relevant legislation.
    /// </summary>
    public required InternalisationData1 OtherTransferableSecurities { get; init; } 
    /// <summary>
    /// Relates to a fund of which at least one unit or share class is traded throughout the day on at least one trading venue and with at least one market maker which takes action to ensure that the price of its units or shares on the trading venue does not vary significantly from its net asset value and, where applicable, from its indicative net asset value, as referred to in the relevant legislation.
    /// </summary>
    public required InternalisationData1 ExchangeTradingFunds { get; init; } 
    /// <summary>
    /// Units in collective investment undertakings, other than ETFs.
    /// </summary>
    public required InternalisationData1 CollectiveInvestmentUndertakings { get; init; } 
    /// <summary>
    /// Money market instruments other than sovereign debts.
    /// </summary>
    public required InternalisationData1 MoneyMarketInstrument { get; init; } 
    /// <summary>
    /// Relates to emission allowances which are tradable according to the relevant legislation.
    /// </summary>
    public required InternalisationData1 EmissionAllowance { get; init; } 
    /// <summary>
    /// Covers any financial instruments not covered as a dedicated category.
    /// </summary>
    public required InternalisationData1 OtherFinancialInstruments { get; init; } 
    
    #nullable disable
}
