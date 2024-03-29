﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementFailsDailyInstrument3.  ISO2002 ID# _Gj3jgTOnEeqX8uoQQ3KffQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of financial instruments that are initially recorded or centrally maintained in CSDs (central securities depositories) as defined in the relevant regulation.
/// </summary>
[IsoId("_Gj3jgTOnEeqX8uoQQ3KffQ")]
[DisplayName("Settlement Fails Daily Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsDailyInstrument3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailsDailyInstrument3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsDailyInstrument3( SettlementFailsDailyTransactionType1Choice_ reqEquity,SettlementFailsDailyTransactionType1Choice_ reqSovereignDebt,SettlementFailsDailyTransactionType1Choice_ reqBond,SettlementFailsDailyTransactionType1Choice_ reqOtherTransferableSecurities,SettlementFailsDailyTransactionType1Choice_ reqExchangeTradedFunds,SettlementFailsDailyTransactionType1Choice_ reqCollectiveInvestmentUndertakings,SettlementFailsDailyTransactionType1Choice_ reqMoneyMarketInstrument,SettlementFailsDailyTransactionType1Choice_ reqEmissionAllowance,SettlementFailsDailyTransactionType1Choice_ reqOther )
    {
        Equity = reqEquity;
        SovereignDebt = reqSovereignDebt;
        Bond = reqBond;
        OtherTransferableSecurities = reqOtherTransferableSecurities;
        ExchangeTradedFunds = reqExchangeTradedFunds;
        CollectiveInvestmentUndertakings = reqCollectiveInvestmentUndertakings;
        MoneyMarketInstrument = reqMoneyMarketInstrument;
        EmissionAllowance = reqEmissionAllowance;
        Other = reqOther;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Shares in companies and other securities equivalent to shares in companies, partnerships or other entities, and depositary receipts in respect of share.
    /// </summary>
    [IsoId("_Gko_kTOnEeqX8uoQQ3KffQ")]
    [DisplayName("Equity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Eqty")]
    #endif
    [IsoXmlTag("Eqty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyTransactionType1Choice_ Equity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyTransactionType1Choice_ Equity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyTransactionType1Choice_ Equity { get; init; } 
    #else
    public SettlementFailsDailyTransactionType1Choice_ Equity { get; set; } 
    #endif
    
    /// <summary>
    /// Debt instrument issued by a sovereign issuer.
    /// </summary>
    [IsoId("_Gko_kzOnEeqX8uoQQ3KffQ")]
    [DisplayName("Sovereign Debt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvrgnDebt")]
    #endif
    [IsoXmlTag("SvrgnDebt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyTransactionType1Choice_ SovereignDebt { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyTransactionType1Choice_ SovereignDebt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyTransactionType1Choice_ SovereignDebt { get; init; } 
    #else
    public SettlementFailsDailyTransactionType1Choice_ SovereignDebt { get; set; } 
    #endif
    
    /// <summary>
    /// Bonds other than sovereign debt.
    /// </summary>
    [IsoId("_Gko_lTOnEeqX8uoQQ3KffQ")]
    [DisplayName("Bond")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bd")]
    #endif
    [IsoXmlTag("Bd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyTransactionType1Choice_ Bond { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyTransactionType1Choice_ Bond { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyTransactionType1Choice_ Bond { get; init; } 
    #else
    public SettlementFailsDailyTransactionType1Choice_ Bond { get; set; } 
    #endif
    
    /// <summary>
    /// Securities meeting the criteria laid down in the relevant legislation.
    /// </summary>
    [IsoId("_Gko_lzOnEeqX8uoQQ3KffQ")]
    [DisplayName("Other Transferable Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTrfblScties")]
    #endif
    [IsoXmlTag("OthrTrfblScties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyTransactionType1Choice_ OtherTransferableSecurities { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyTransactionType1Choice_ OtherTransferableSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyTransactionType1Choice_ OtherTransferableSecurities { get; init; } 
    #else
    public SettlementFailsDailyTransactionType1Choice_ OtherTransferableSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Relates to a fund of which at least one unit or share class is traded throughout the day on at least one trading venue and with at least one market maker which takes action to ensure that the price of its units or shares on the trading venue does not vary significantly from its net asset value and, where applicable, from its indicative net asset value, as referred to in the relevant legislation.
    /// </summary>
    [IsoId("_Gko_mTOnEeqX8uoQQ3KffQ")]
    [DisplayName("Exchange Traded Funds")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgTraddFnds")]
    #endif
    [IsoXmlTag("XchgTraddFnds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyTransactionType1Choice_ ExchangeTradedFunds { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyTransactionType1Choice_ ExchangeTradedFunds { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyTransactionType1Choice_ ExchangeTradedFunds { get; init; } 
    #else
    public SettlementFailsDailyTransactionType1Choice_ ExchangeTradedFunds { get; set; } 
    #endif
    
    /// <summary>
    /// Units in collective investment undertakings, other than ETFs.
    /// </summary>
    [IsoId("_Gko_mzOnEeqX8uoQQ3KffQ")]
    [DisplayName("Collective Investment Undertakings")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CllctvInvstmtUdrtkgs")]
    #endif
    [IsoXmlTag("CllctvInvstmtUdrtkgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyTransactionType1Choice_ CollectiveInvestmentUndertakings { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyTransactionType1Choice_ CollectiveInvestmentUndertakings { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyTransactionType1Choice_ CollectiveInvestmentUndertakings { get; init; } 
    #else
    public SettlementFailsDailyTransactionType1Choice_ CollectiveInvestmentUndertakings { get; set; } 
    #endif
    
    /// <summary>
    /// Money market instruments other than sovereign debts.
    /// </summary>
    [IsoId("_Gko_nTOnEeqX8uoQQ3KffQ")]
    [DisplayName("Money Market Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnyMktInstrm")]
    #endif
    [IsoXmlTag("MnyMktInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyTransactionType1Choice_ MoneyMarketInstrument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyTransactionType1Choice_ MoneyMarketInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyTransactionType1Choice_ MoneyMarketInstrument { get; init; } 
    #else
    public SettlementFailsDailyTransactionType1Choice_ MoneyMarketInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Relates to emission allowances which are tradable according to the relevant legislation.
    /// </summary>
    [IsoId("_Gko_nzOnEeqX8uoQQ3KffQ")]
    [DisplayName("Emission Allowance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmssnAllwnc")]
    #endif
    [IsoXmlTag("EmssnAllwnc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyTransactionType1Choice_ EmissionAllowance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyTransactionType1Choice_ EmissionAllowance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyTransactionType1Choice_ EmissionAllowance { get; init; } 
    #else
    public SettlementFailsDailyTransactionType1Choice_ EmissionAllowance { get; set; } 
    #endif
    
    /// <summary>
    /// Covers any financial instruments not covered as a dedicated category.
    /// </summary>
    [IsoId("_Gko_oTOnEeqX8uoQQ3KffQ")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyTransactionType1Choice_ Other { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyTransactionType1Choice_ Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyTransactionType1Choice_ Other { get; init; } 
    #else
    public SettlementFailsDailyTransactionType1Choice_ Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
