﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionInstructionV08.  ISO2002 ID# _O2Ed8adCEee4_75LDmHZiQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.023.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner sends a SecuritiesSettlementTransactionInstruction to an account servicer to instruct the receipt or delivery of financial instruments with or without payment, physically or by book-entry.
/// The account owner/servicer relationship may be:
/// - a global custodian which has an account with a local custodian, or
/// - an investment management institution which manages a fund account opened at a custodian, or
/// - a broker which has an account with a custodian, or
/// - a central securities depository participant which has an account with a central securities depository, or
/// - a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or
/// - a central counterparty or a stock exchange or a trade matching utility which need to instruct the settlement of transactions to a central securities depository or another settlement market infrastructure.
/// 
/// Usage
/// The instruction may be linked to other settlement instructions, for example, for a turnaround or back-to-back, or other transactions, for example, foreign exchange deal, using the linkage functionality.
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope|An account owner sends a SecuritiesSettlementTransactionInstruction to an account servicer to instruct the receipt or delivery of financial instruments with or without payment, physically or by book-entry.|The account owner/servicer relationship may be:|- a global custodian which has an account with a local custodian, or|- an investment management institution which manages a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository participant which has an account with a central securities depository, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or|- a central counterparty or a stock exchange or a trade matching utility which need to instruct the settlement of transactions to a central securities depository or another settlement market infrastructure.||Usage|The instruction may be linked to other settlement instructions, for example, for a turnaround or back-to-back, or other transactions, for example, foreign exchange deal, using the linkage functionality.|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
[IsoId("_O2Ed8adCEee4_75LDmHZiQ")]
[DisplayName("Securities Settlement Transaction Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesSettlementTransactionInstructionV08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.023.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.023.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesSettlementTransactionInstructionV08 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesSettlementTransactionInstructionV08( System.String reqTransactionIdentification,SettlementTypeAndAdditionalParameters19 reqSettlementTypeAndAdditionalParameters,SecuritiesTradeDetails73 reqTradeDetails,SecurityIdentification19 reqFinancialInstrumentIdentification,QuantityAndAccount65 reqQuantityAndAccountDetails,SettlementDetails142 reqSettlementParameters )
    {
        TransactionIdentification = reqTransactionIdentification;
        SettlementTypeAndAdditionalParameters = reqSettlementTypeAndAdditionalParameters;
        TradeDetails = reqTradeDetails;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        QuantityAndAccountDetails = reqQuantityAndAccountDetails;
        SettlementParameters = reqSettlementParameters;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_O2EeE6dCEee4_75LDmHZiQ")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides settlement type and identification information.
    /// </summary>
    [IsoId("_O2EeFadCEee4_75LDmHZiQ")]
    [DisplayName("Settlement Type And Additional Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTpAndAddtlParams")]
    #endif
    [IsoXmlTag("SttlmTpAndAddtlParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTypeAndAdditionalParameters19 SettlementTypeAndAdditionalParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTypeAndAdditionalParameters19 SettlementTypeAndAdditionalParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTypeAndAdditionalParameters19 SettlementTypeAndAdditionalParameters { get; init; } 
    #else
    public SettlementTypeAndAdditionalParameters19 SettlementTypeAndAdditionalParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Count of the number of transactions linked.
    /// </summary>
    [IsoId("_O2EeF6dCEee4_75LDmHZiQ")]
    [DisplayName("Number Counts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbCounts")]
    #endif
    [IsoXmlTag("NbCounts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberCount1Choice_? NumberCounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberCount1Choice_? NumberCounts { get; init; } 
    #else
    public NumberCount1Choice_? NumberCounts { get; set; } 
    #endif
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_O2EeGadCEee4_75LDmHZiQ")]
    [DisplayName("Linkages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lnkgs")]
    #endif
    [IsoXmlTag("Lnkgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Linkages37? Linkages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages37? Linkages { get; init; } 
    #else
    public Linkages37? Linkages { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_O2EeG6dCEee4_75LDmHZiQ")]
    [DisplayName("Trade Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtls")]
    #endif
    [IsoXmlTag("TradDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesTradeDetails73 TradeDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesTradeDetails73 TradeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTradeDetails73 TradeDetails { get; init; } 
    #else
    public SecuritiesTradeDetails73 TradeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_O2EeHadCEee4_75LDmHZiQ")]
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
    [IsoId("_O2EeH6dCEee4_75LDmHZiQ")]
    [DisplayName("Financial Instrument Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmAttrbts")]
    #endif
    [IsoXmlTag("FinInstrmAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributes91? FinancialInstrumentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes91? FinancialInstrumentAttributes { get; init; } 
    #else
    public FinancialInstrumentAttributes91? FinancialInstrumentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_O2EeIadCEee4_75LDmHZiQ")]
    [DisplayName("Quantity And Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyAndAcctDtls")]
    #endif
    [IsoXmlTag("QtyAndAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QuantityAndAccount65 QuantityAndAccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QuantityAndAccount65 QuantityAndAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityAndAccount65 QuantityAndAccountDetails { get; init; } 
    #else
    public QuantityAndAccount65 QuantityAndAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_O2EeI6dCEee4_75LDmHZiQ")]
    [DisplayName("Settlement Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmParams")]
    #endif
    [IsoXmlTag("SttlmParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDetails142 SettlementParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementDetails142 SettlementParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDetails142 SettlementParameters { get; init; } 
    #else
    public SettlementDetails142 SettlementParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_O2EeJadCEee4_75LDmHZiQ")]
    [DisplayName("Standing Settlement Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgSttlmInstrDtls")]
    #endif
    [IsoXmlTag("StgSttlmInstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StandingSettlementInstruction14? StandingSettlementInstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingSettlementInstruction14? StandingSettlementInstructionDetails { get; init; } 
    #else
    public StandingSettlementInstruction14? StandingSettlementInstructionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_O2EeJ6dCEee4_75LDmHZiQ")]
    [DisplayName("Delivering Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgSttlmPties")]
    #endif
    [IsoXmlTag("DlvrgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties62? DeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties62? DeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties62? DeliveringSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_O2EeKadCEee4_75LDmHZiQ")]
    [DisplayName("Receiving Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgSttlmPties")]
    #endif
    [IsoXmlTag("RcvgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties62? ReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties62? ReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties62? ReceivingSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Cash parties involved in the transaction if different for the securities settlement parties.
    /// </summary>
    [IsoId("_O2EeK6dCEee4_75LDmHZiQ")]
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
    [IsoId("_O2EeLadCEee4_75LDmHZiQ")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection87? SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection87? SettlementAmount { get; init; } 
    #else
    public AmountAndDirection87? SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_O2EeL6dCEee4_75LDmHZiQ")]
    [DisplayName("Other Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAmts")]
    #endif
    [IsoXmlTag("OthrAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherAmounts39? OtherAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherAmounts39? OtherAmounts { get; init; } 
    #else
    public OtherAmounts39? OtherAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_O2EeMadCEee4_75LDmHZiQ")]
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
    [IsoId("_O2EeM6dCEee4_75LDmHZiQ")]
    [DisplayName("Additional Physical Or Registration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlPhysOrRegnDtls")]
    #endif
    [IsoXmlTag("AddtlPhysOrRegnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegistrationParameters6? AdditionalPhysicalOrRegistrationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegistrationParameters6? AdditionalPhysicalOrRegistrationDetails { get; init; } 
    #else
    public RegistrationParameters6? AdditionalPhysicalOrRegistrationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_O2EeNadCEee4_75LDmHZiQ")]
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


// Since SecuritiesSettlementTransactionInstructionV08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesSettlementTransactionInstructionV08.

