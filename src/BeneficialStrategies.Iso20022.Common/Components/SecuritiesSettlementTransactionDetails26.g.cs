﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesSettlementTransactionDetails26.  ISO2002 ID# _dXOX14yeEeaxLOI-Kq-S4w.
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
/// Provides the details of the update(s) for the settlement transaction.
/// </summary>
[IsoId("_dXOX14yeEeaxLOI-Kq-S4w")]
[DisplayName("Securities Settlement Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesSettlementTransactionDetails26
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides settlement type and identification information.
    /// </summary>
    [IsoId("_eNresYyeEeaxLOI-Kq-S4w")]
    [DisplayName("Settlement Type And Additional Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTpAndAddtlParams")]
    #endif
    [IsoXmlTag("SttlmTpAndAddtlParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTypeAndAdditionalParameters13? SettlementTypeAndAdditionalParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTypeAndAdditionalParameters13? SettlementTypeAndAdditionalParameters { get; init; } 
    #else
    public SettlementTypeAndAdditionalParameters13? SettlementTypeAndAdditionalParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_eNres4yeEeaxLOI-Kq-S4w")]
    [DisplayName("Linkages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lnkgs")]
    #endif
    [IsoXmlTag("Lnkgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Linkages38? Linkages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages38? Linkages { get; init; } 
    #else
    public Linkages38? Linkages { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_eNretYyeEeaxLOI-Kq-S4w")]
    [DisplayName("Trade Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtls")]
    #endif
    [IsoXmlTag("TradDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTradeDetails50? TradeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTradeDetails50? TradeDetails { get; init; } 
    #else
    public SecuritiesTradeDetails50? TradeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Attributes defining a financial instrument.
    /// </summary>
    [IsoId("_eNret4yeEeaxLOI-Kq-S4w")]
    [DisplayName("Financial Instrument Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAttrbts")]
    #endif
    [IsoXmlTag("FinInstrmAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributes64? FinancialInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes64? FinancialInstrumentAttributes { get; init; } 
    #else
    public FinancialInstrumentAttributes64? FinancialInstrumentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_eNreuYyeEeaxLOI-Kq-S4w")]
    [DisplayName("Quantity And Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyAndAcctDtls")]
    #endif
    [IsoXmlTag("QtyAndAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityAndAccount44? QuantityAndAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityAndAccount44? QuantityAndAccountDetails { get; init; } 
    #else
    public QuantityAndAccount44? QuantityAndAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_eNreu4yeEeaxLOI-Kq-S4w")]
    [DisplayName("Settlement Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmParams")]
    #endif
    [IsoXmlTag("SttlmParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementDetails122? SettlementParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDetails122? SettlementParameters { get; init; } 
    #else
    public SettlementDetails122? SettlementParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_eNrevYyeEeaxLOI-Kq-S4w")]
    [DisplayName("Standing Settlement Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgSttlmInstrDtls")]
    #endif
    [IsoXmlTag("StgSttlmInstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StandingSettlementInstruction11? StandingSettlementInstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingSettlementInstruction11? StandingSettlementInstructionDetails { get; init; } 
    #else
    public StandingSettlementInstruction11? StandingSettlementInstructionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_eNrev4yeEeaxLOI-Kq-S4w")]
    [DisplayName("Delivering Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgSttlmPties")]
    #endif
    [IsoXmlTag("DlvrgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties39? DeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties39? DeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties39? DeliveringSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_eNrewYyeEeaxLOI-Kq-S4w")]
    [DisplayName("Receiving Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgSttlmPties")]
    #endif
    [IsoXmlTag("RcvgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties39? ReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties39? ReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties39? ReceivingSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Cash parties involved in the transaction if different for the securities settlement parties.
    /// </summary>
    [IsoId("_eNrew4yeEeaxLOI-Kq-S4w")]
    [DisplayName("Cash Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshPties")]
    #endif
    [IsoXmlTag("CshPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashParties26? CashParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashParties26? CashParties { get; init; } 
    #else
    public CashParties26? CashParties { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_eNrexYyeEeaxLOI-Kq-S4w")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection45? SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection45? SettlementAmount { get; init; } 
    #else
    public AmountAndDirection45? SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_eNrex4yeEeaxLOI-Kq-S4w")]
    [DisplayName("Other Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAmts")]
    #endif
    [IsoXmlTag("OthrAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherAmounts28? OtherAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherAmounts28? OtherAmounts { get; init; } 
    #else
    public OtherAmounts28? OtherAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_eNreyYyeEeaxLOI-Kq-S4w")]
    [DisplayName("Other Business Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrBizPties")]
    #endif
    [IsoXmlTag("OthrBizPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherParties27? OtherBusinessParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherParties27? OtherBusinessParties { get; init; } 
    #else
    public OtherParties27? OtherBusinessParties { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    [IsoId("_eNrey4yeEeaxLOI-Kq-S4w")]
    [DisplayName("Additional Physical Or Registration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlPhysOrRegnDtls")]
    #endif
    [IsoXmlTag("AddtlPhysOrRegnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegistrationParameters4? AdditionalPhysicalOrRegistrationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegistrationParameters4? AdditionalPhysicalOrRegistrationDetails { get; init; } 
    #else
    public RegistrationParameters4? AdditionalPhysicalOrRegistrationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eNrezYyeEeaxLOI-Kq-S4w")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
