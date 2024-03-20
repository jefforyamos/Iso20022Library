﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDetails3.  ISO2002 ID# _S-6mMdp-Ed-ak6NoX_4Aeg_-160365271.
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
/// Details of the transaction.
/// </summary>
[IsoId("_S-6mMdp-Ed-ak6NoX_4Aeg_-160365271")]
[DisplayName("Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionDetails3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionDetails3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionDetails3( System.String reqTradeReference,PlaceOfTradeIdentification2Choice_ reqPlaceOfTrade,System.DateTime reqTradeDateTime,FinancialInstrument15 reqFinancialInstrumentDetails,OrderDriverCode reqSide,PartyIdentification11Choice_ reqCounterparty,TradingCapacity3Code reqCapacity,PriceRateOrAmountChoice_ reqExecutedTradePrice,UnitOrFaceAmountChoice_ reqExecutedTradeQuantity )
    {
        TradeReference = reqTradeReference;
        PlaceOfTrade = reqPlaceOfTrade;
        TradeDateTime = reqTradeDateTime;
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
        Side = reqSide;
        Counterparty = reqCounterparty;
        Capacity = reqCapacity;
        ExecutedTradePrice = reqExecutedTradePrice;
        ExecutedTradeQuantity = reqExecutedTradeQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned to a trade. This is the reference generated by a firm or the reference allocated by the executing system if the trade was executed automatically.
    /// </summary>
    [IsoId("_S-6mMtp-Ed-ak6NoX_4Aeg_-160365269")]
    [DisplayName("Trade Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradRef")]
    #endif
    [IsoXmlTag("TradRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text TradeReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TradeReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradeReference { get; init; } 
    #else
    public System.String TradeReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference that links to other trades that are/will be sent, eg for straddles where put and call legs need to be reported together.
    /// </summary>
    [IsoId("_S-6mM9p-Ed-ak6NoX_4Aeg_-160365253")]
    [DisplayName("Associated Trade Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdTradRef")]
    #endif
    [IsoXmlTag("AssoctdTradRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AssociatedTradeReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssociatedTradeReference { get; init; } 
    #else
    public System.String? AssociatedTradeReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the execution venue. In the case of an exchange or a Multilateral Trading Facility (MTF), this should be identified using a MIC code. In the case of a systematic internaliser, place of trade should be identified using a BIC code.
    /// </summary>
    [IsoId("_S-6mNNp-Ed-ak6NoX_4Aeg_-160365236")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PlaceOfTradeIdentification2Choice_ PlaceOfTrade { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PlaceOfTradeIdentification2Choice_ PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlaceOfTradeIdentification2Choice_ PlaceOfTrade { get; init; } 
    #else
    public PlaceOfTradeIdentification2Choice_ PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_S-6mNdp-Ed-ak6NoX_4Aeg_-160365218")]
    [DisplayName("Trade Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtTm")]
    #endif
    [IsoXmlTag("TradDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TradeDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TradeDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TradeDateTime { get; init; } 
    #else
    public System.DateTime TradeDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the financial instrument for which the transaction report is being sent.
    /// </summary>
    [IsoId("_S-6mNtp-Ed-ak6NoX_4Aeg_-160364400")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument15 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument15 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument15 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument15 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the transaction was a buy or a sell from the perspective of the reporting firm.
    /// </summary>
    [IsoId("_S-6mN9p-Ed-ak6NoX_4Aeg_-160365193")]
    [DisplayName("Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sd")]
    #endif
    [IsoXmlTag("Sd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrderDriverCode Side { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrderDriverCode Side { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderDriverCode Side { get; init; } 
    #else
    public OrderDriverCode Side { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the regulator(s) to whom the transaction report must be sent.
    /// </summary>
    [IsoId("_S-6mONp-Ed-ak6NoX_4Aeg_-160364357")]
    [DisplayName("Transaction Report Marker")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRptMrkr")]
    #endif
    [IsoXmlTag("TxRptMrkr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<PartyIdentification24Choice_> TransactionReportMarker { get; init; } = new ValueList<PartyIdentification24Choice_>(){};
    
    /// <summary>
    /// Provides details of the counterparty.
    /// </summary>
    [IsoId("_S-6mOdp-Ed-ak6NoX_4Aeg_-160364512")]
    [DisplayName("Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPty")]
    #endif
    [IsoXmlTag("CtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification11Choice_ Counterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification11Choice_ Counterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification11Choice_ Counterparty { get; init; } 
    #else
    public PartyIdentification11Choice_ Counterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the client.
    /// </summary>
    [IsoId("_S_EXMNp-Ed-ak6NoX_4Aeg_-160364802")]
    [DisplayName("Client")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clnt")]
    #endif
    [IsoXmlTag("Clnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification23? Client { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification23? Client { get; init; } 
    #else
    public PartyIdentification23? Client { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the trading capacity of the firm reporting the transaction, eg Agent or Principal.
    /// </summary>
    [IsoId("_S_EXMdp-Ed-ak6NoX_4Aeg_-160364941")]
    [DisplayName("Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cpcty")]
    #endif
    [IsoXmlTag("Cpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradingCapacity3Code Capacity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradingCapacity3Code Capacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingCapacity3Code Capacity { get; init; } 
    #else
    public TradingCapacity3Code Capacity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the currency and price at which the trade has been executed, excluding commission or accrued interest.
    /// </summary>
    [IsoId("_S_EXMtp-Ed-ak6NoX_4Aeg_-160364916")]
    [DisplayName("Executed Trade Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctdTradPric")]
    #endif
    [IsoXmlTag("ExctdTradPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceRateOrAmountChoice_ ExecutedTradePrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceRateOrAmountChoice_ ExecutedTradePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceRateOrAmountChoice_ ExecutedTradePrice { get; init; } 
    #else
    public PriceRateOrAmountChoice_ ExecutedTradePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument executed by the trading party.
    /// </summary>
    [IsoId("_S_EXM9p-Ed-ak6NoX_4Aeg_-160364899")]
    [DisplayName("Executed Trade Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctdTradQty")]
    #endif
    [IsoXmlTag("ExctdTradQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOrFaceAmountChoice_ ExecutedTradeQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOrFaceAmountChoice_ ExecutedTradeQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmountChoice_ ExecutedTradeQuantity { get; init; } 
    #else
    public UnitOrFaceAmountChoice_ ExecutedTradeQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// The total consideration or value.
    /// </summary>
    [IsoId("_S_EXNNp-Ed-ak6NoX_4Aeg_-160364881")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the intended settlement date.
    /// </summary>
    [IsoId("_S_EXNdp-Ed-ak6NoX_4Aeg_-160364864")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? SettlementDate { get; init; } 
    #else
    public System.DateTime? SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the person/organisation that has the power of attorney.
    /// </summary>
    [IsoId("_S_EXNtp-Ed-ak6NoX_4Aeg_-160364417")]
    [DisplayName("Proxy Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrxyHldr")]
    #endif
    [IsoXmlTag("PrxyHldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? ProxyHolder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? ProxyHolder { get; init; } 
    #else
    public PartyIdentification2Choice_? ProxyHolder { get; set; } 
    #endif
    
    /// <summary>
    /// Additional domestic regulatory transaction information.
    /// </summary>
    [IsoId("_S_EXN9p-Ed-ak6NoX_4Aeg_-160364846")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
