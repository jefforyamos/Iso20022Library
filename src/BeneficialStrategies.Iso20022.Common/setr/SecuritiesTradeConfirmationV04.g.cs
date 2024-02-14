﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesTradeConfirmationV04.  ISO2002 ID# _j1-bIY-XEeaVK-2bgpxeYw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.027.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// SCOPE
/// Sent by an executing party to an instructing party directly or through Central Matching Utility (CMU) to provide trade confirmation on a per-account basis based on instructions provided by the instructing party in the SecuritiesAllocationInstruction message.
/// 
/// It may also be used to provide trade confirmation on the trade level from an executing party or an instructing party to the custodian or an affirming party directly or through CMU.
/// 
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.
/// The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// The custodian or the affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.
/// 
/// USAGE
/// Initiator: In local matching, the initiator of this message is always the executing party. In central matching the initiator may be either the executing party or instructing party.
/// Respondent: instructing party, a custodian or an affirming party responds with SecuritiesTradeConfirmationResponse (accept or reject) message.
/// </summary>
[Description(@"SCOPE|Sent by an executing party to an instructing party directly or through Central Matching Utility (CMU) to provide trade confirmation on a per-account basis based on instructions provided by the instructing party in the SecuritiesAllocationInstruction message.||It may also be used to provide trade confirmation on the trade level from an executing party or an instructing party to the custodian or an affirming party directly or through CMU.||The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.|The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|The custodian or the affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.||USAGE|Initiator: In local matching, the initiator of this message is always the executing party. In central matching the initiator may be either the executing party or instructing party.|Respondent: instructing party, a custodian or an affirming party responds with SecuritiesTradeConfirmationResponse (accept or reject) message.")]
[IsoId("_j1-bIY-XEeaVK-2bgpxeYw")]
[DisplayName("Securities Trade Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesTradeConfirmationV04 : IOuterRecord<SecuritiesTradeConfirmationV04,SecuritiesTradeConfirmationV04Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.027.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesTradeConfirmationV04Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesTradeConfirmationV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesTradeConfirmationV04( TransactiontIdentification4 reqIdentification,Order24 reqTradeDetails,SecurityIdentification19 reqFinancialInstrumentIdentification,ConfirmationParties6 reqConfirmationParties )
    {
        Identification = reqIdentification;
        TradeDetails = reqTradeDetails;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        ConfirmationParties = reqConfirmationParties;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information that unambiguously identifies an SecuritiesTradeConfirmation message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_j1-bI4-XEeaVK-2bgpxeYw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactiontIdentification4 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactiontIdentification4 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactiontIdentification4 Identification { get; init; } 
    #else
    public TransactiontIdentification4 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Count of the number of transactions linked.
    /// </summary>
    [IsoId("_j1-bJY-XEeaVK-2bgpxeYw")]
    [DisplayName("Number Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbCnt")]
    #endif
    [IsoXmlTag("NbCnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberCount1Choice_? NumberCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberCount1Choice_? NumberCount { get; init; } 
    #else
    public NumberCount1Choice_? NumberCount { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction identifier issued by a business party and/or market infrastructure. It may also be used to reference a previous transaction, for example, a block/allocation instruction, or tie a set of messages together.
    /// </summary>
    [IsoId("_j1-bJ4-XEeaVK-2bgpxeYw")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Linkages52? References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages52? References { get; init; } 
    #else
    public Linkages52? References { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_j1-bKY-XEeaVK-2bgpxeYw")]
    [DisplayName("Trade Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtls")]
    #endif
    [IsoXmlTag("TradDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Order24 TradeDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Order24 TradeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Order24 TradeDetails { get; init; } 
    #else
    public Order24 TradeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial instrument, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_j1-bK4-XEeaVK-2bgpxeYw")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_j1-bLY-XEeaVK-2bgpxeYw")]
    [DisplayName("Financial Instrument Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAttrbts")]
    #endif
    [IsoXmlTag("FinInstrmAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributes124? FinancialInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes124? FinancialInstrumentAttributes { get; init; } 
    #else
    public FinancialInstrumentAttributes124? FinancialInstrumentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying financial instrument to which an trade confirmation is related.
    /// </summary>
    [IsoId("_j1-bL4-XEeaVK-2bgpxeYw")]
    [DisplayName("Underlying Financial Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygFinInstrm")]
    #endif
    [IsoXmlTag("UndrlygFinInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingFinancialInstrument7? UnderlyingFinancialInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingFinancialInstrument7? UnderlyingFinancialInstrument { get; init; } 
    #else
    public UnderlyingFinancialInstrument7? UnderlyingFinancialInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Additional restrictions on the financial instrument, related to the stipulation.
    /// </summary>
    [IsoId("_j1-bMY-XEeaVK-2bgpxeYw")]
    [DisplayName("Stipulations")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Stiptns")]
    #endif
    [IsoXmlTag("Stiptns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentStipulations4? Stipulations { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentStipulations4? Stipulations { get; init; } 
    #else
    public FinancialInstrumentStipulations4? Stipulations { get; set; } 
    #endif
    
    /// <summary>
    /// Parties involved in the confirmation of the details of a trade.
    /// </summary>
    [IsoId("_j1-bM4-XEeaVK-2bgpxeYw")]
    [DisplayName("Confirmation Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfPties")]
    #endif
    [IsoXmlTag("ConfPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ConfirmationParties6 ConfirmationParties { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ConfirmationParties6 ConfirmationParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationParties6 ConfirmationParties { get; init; } 
    #else
    public ConfirmationParties6 ConfirmationParties { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_j1-bNY-XEeaVK-2bgpxeYw")]
    [DisplayName("Settlement Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmParams")]
    #endif
    [IsoXmlTag("SttlmParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementDetails213? SettlementParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDetails213? SettlementParameters { get; init; } 
    #else
    public SettlementDetails213? SettlementParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_j1-bN4-XEeaVK-2bgpxeYw")]
    [DisplayName("Standing Settlement Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgSttlmInstr")]
    #endif
    [IsoXmlTag("StgSttlmInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StandingSettlementInstruction13? StandingSettlementInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingSettlementInstruction13? StandingSettlementInstruction { get; init; } 
    #else
    public StandingSettlementInstruction13? StandingSettlementInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_j1-bOY-XEeaVK-2bgpxeYw")]
    [DisplayName("Delivering Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgSttlmPties")]
    #endif
    [IsoXmlTag("DlvrgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties59? DeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties59? DeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties59? DeliveringSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_j1-bO4-XEeaVK-2bgpxeYw")]
    [DisplayName("Receiving Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgSttlmPties")]
    #endif
    [IsoXmlTag("RcvgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties59? ReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties59? ReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties59? ReceivingSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Cash parties involved in the specific transaction.
    /// </summary>
    [IsoId("_j1-bPY-XEeaVK-2bgpxeYw")]
    [DisplayName("Cash Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshPties")]
    #endif
    [IsoXmlTag("CshPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashParties33? CashParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashParties33? CashParties { get; init; } 
    #else
    public CashParties33? CashParties { get; set; } 
    #endif
    
    /// <summary>
    /// Provides clearing member information.
    /// </summary>
    [IsoId("_j1-bP4-XEeaVK-2bgpxeYw")]
    [DisplayName("Clearing Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrDtls")]
    #endif
    [IsoXmlTag("ClrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Clearing5? ClearingDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Clearing5? ClearingDetails { get; init; } 
    #else
    public Clearing5? ClearingDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities. The amount includes the principal with any commissions and fees or accrued interest.
    /// </summary>
    [IsoId("_j1-bQY-XEeaVK-2bgpxeYw")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection28? SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection28? SettlementAmount { get; init; } 
    #else
    public AmountAndDirection28? SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_j1-bQ4-XEeaVK-2bgpxeYw")]
    [DisplayName("Other Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAmts")]
    #endif
    [IsoXmlTag("OthrAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherAmounts16? OtherAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherAmounts16? OtherAmounts { get; init; } 
    #else
    public OtherAmounts16? OtherAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Other prices than the deal price.
    /// </summary>
    [IsoId("_j1-bRY-XEeaVK-2bgpxeYw")]
    [DisplayName("Other Prices")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPrics")]
    #endif
    [IsoXmlTag("OthrPrics")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherPrices5? OtherPrices { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherPrices5? OtherPrices { get; init; } 
    #else
    public OtherPrices5? OtherPrices { get; set; } 
    #endif
    
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_j1-bR4-XEeaVK-2bgpxeYw")]
    [DisplayName("Other Business Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrBizPties")]
    #endif
    [IsoXmlTag("OthrBizPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherParties32? OtherBusinessParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherParties32? OtherBusinessParties { get; init; } 
    #else
    public OtherParties32? OtherBusinessParties { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies a transaction that the trading parties are agreeing to repurchase, sell back or return the same or similar securities at a later time. 
    /// The two leg transaction details defines the closing leg conditions of a two leg transaction. It is also used to define the anticipated closing leg conditions at the time of opening the closed-end transaction. 
    /// </summary>
    [IsoId("_j1-bSY-XEeaVK-2bgpxeYw")]
    [DisplayName("Two Leg Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TwoLegTxDtls")]
    #endif
    [IsoXmlTag("TwoLegTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TwoLegTransactionDetails5? TwoLegTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TwoLegTransactionDetails5? TwoLegTransactionDetails { get; init; } 
    #else
    public TwoLegTransactionDetails5? TwoLegTransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies regulatory stipulations that financial institutions must be compliant with in the country, region, and/or area they conduct business.
    /// </summary>
    [IsoId("_j1-bS4-XEeaVK-2bgpxeYw")]
    [DisplayName("Regulatory Stipulations")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryStiptns")]
    #endif
    [IsoXmlTag("RgltryStiptns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegulatoryStipulations1? RegulatoryStipulations { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegulatoryStipulations1? RegulatoryStipulations { get; init; } 
    #else
    public RegulatoryStipulations1? RegulatoryStipulations { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_j1-bTY-XEeaVK-2bgpxeYw")]
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
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;SecuritiesTradeConfirmationV04Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesTradeConfirmationV04Document ToDocument()
    {
        return new SecuritiesTradeConfirmationV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;SecuritiesTradeConfirmationV04&quot;/&gt;.
/// </summary>
[Serializable]
public partial record SecuritiesTradeConfirmationV04Document : IOuterDocument<SecuritiesTradeConfirmationV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.027.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;SecuritiesTradeConfirmationV04&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesTradeConfirmationV04 Message { get; init; }
    #else
    public SecuritiesTradeConfirmationV04 Message { get; init; }
    #endif
}
