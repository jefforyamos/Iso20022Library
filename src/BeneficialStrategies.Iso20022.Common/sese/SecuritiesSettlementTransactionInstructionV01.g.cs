﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionInstructionV01.  ISO2002 ID# _7EzuWNE5Ed-BzquC8wXy7w_-1585655495.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.023.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner sends a SecuritiesSettlementTransactionInstruction to an account servicer to instruct the receipt or delivery of financial instruments with or without payment, physically or by book-entry.
/// The account owner/servicer relationship may be:
/// - a global custodian which has an account with a local custodian, or
/// - an investment management institution which manages a fund account opened at a custodian, or
/// - a broker which has an account with a custodian, or
/// - a central securities depository participant which has an account with a central securities depository, or
/// - a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or
/// - a central counterparty or a stock exchange or a trade matching utility which need to instruct the settlement of transactions to a central securities depository or another settlement market infrastructure
/// Usage
/// The instruction may be linked to other settlement instructions, for example, for a turnaround or back-to-back, or other transactions, for example, foreign exchange deal, using the linkage functionality.
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account owner sends a SecuritiesSettlementTransactionInstruction to an account servicer to instruct the receipt or delivery of financial instruments with or without payment, physically or by book-entry.|The account owner/servicer relationship may be:|- a global custodian which has an account with a local custodian, or|- an investment management institution which manages a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository participant which has an account with a central securities depository, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or|- a central counterparty or a stock exchange or a trade matching utility which need to instruct the settlement of transactions to a central securities depository or another settlement market infrastructure|Usage|The instruction may be linked to other settlement instructions, for example, for a turnaround or back-to-back, or other transactions, for example, foreign exchange deal, using the linkage functionality.|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
public partial record SecuritiesSettlementTransactionInstructionV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.023.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxInstr";
    
    #nullable enable
    /// <summary>
    /// Information that unambiguously identifies a SecuritiesSettlementTransaction and a SecuritiesSettlementTransactionInstruction message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_7EzuWdE5Ed-BzquC8wXy7w_-576394869")]
    [Description(@"Information that unambiguously identifies a SecuritiesSettlementTransaction and a SecuritiesSettlementTransactionInstruction message as known by the account owner (or the instructing party acting on its behalf).")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required TransactionAndDocumentIdentification1 Identification { get; init; }
    
    /// <summary>
    /// Provides settlement type and identification information.
    /// </summary>
    [IsoId("_7E9fUNE5Ed-BzquC8wXy7w_-695813086")]
    [Description(@"Provides settlement type and identification information.")]
    [DataMember(Name="SttlmTpAndAddtlParams")]
    [XmlElement(ElementName="SttlmTpAndAddtlParams")]
    [Required]
    public required SettlementTypeAndAdditionalParameters1 SettlementTypeAndAdditionalParameters { get; init; }
    
    /// <summary>
    /// Count of the number of transactions linked.
    /// </summary>
    [IsoId("_7E9fUdE5Ed-BzquC8wXy7w_-1521852581")]
    [Description(@"Count of the number of transactions linked.")]
    [DataMember(Name="NbCounts")]
    [XmlElement(ElementName="NbCounts")]
    public NumberCount1Choice_? NumberCounts { get; init; }
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_7E9fUtE5Ed-BzquC8wXy7w_749868105")]
    [Description(@"Link to another transaction that must be processed after, before or at the same time.")]
    [DataMember(Name="Lnkgs")]
    [XmlElement(ElementName="Lnkgs")]
    public Linkages1? Linkages { get; init; }
    
    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_7E9fU9E5Ed-BzquC8wXy7w_1609064530")]
    [Description(@"Details of the trade.")]
    [DataMember(Name="TradDtls")]
    [XmlElement(ElementName="TradDtls")]
    [Required]
    public required SecuritiesTradeDetails1 TradeDetails { get; init; }
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_7E9fVNE5Ed-BzquC8wXy7w_-781080453")]
    [Description(@"Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification11 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_7E9fVdE5Ed-BzquC8wXy7w_-1532371061")]
    [Description(@"Elements characterising a financial instrument.")]
    [DataMember(Name="FinInstrmAttrbts")]
    [XmlElement(ElementName="FinInstrmAttrbts")]
    public FinancialInstrumentAttributes8? FinancialInstrumentAttributes { get; init; }
    
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_7E9fVtE5Ed-BzquC8wXy7w_-1672007096")]
    [Description(@"Details related to the account and quantity involved in the transaction.")]
    [DataMember(Name="QtyAndAcctDtls")]
    [XmlElement(ElementName="QtyAndAcctDtls")]
    [Required]
    public required QuantityAndAccount1 QuantityAndAccountDetails { get; init; }
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_7E9fV9E5Ed-BzquC8wXy7w_-114361436")]
    [Description(@"Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.")]
    [DataMember(Name="SttlmParams")]
    [XmlElement(ElementName="SttlmParams")]
    [Required]
    public required SettlementDetails1 SettlementParameters { get; init; }
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_7FHQUNE5Ed-BzquC8wXy7w_-1833480520")]
    [Description(@"Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.")]
    [DataMember(Name="StgSttlmInstrDtls")]
    [XmlElement(ElementName="StgSttlmInstrDtls")]
    public StandingSettlementInstruction1? StandingSettlementInstructionDetails { get; init; }
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_7FHQUdE5Ed-BzquC8wXy7w_-1384649439")]
    [Description(@"Identifies the chain of delivering settlement parties.")]
    [DataMember(Name="DlvrgSttlmPties")]
    [XmlElement(ElementName="DlvrgSttlmPties")]
    public SettlementParties5? DeliveringSettlementParties { get; init; }
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_7FHQUtE5Ed-BzquC8wXy7w_-1399427077")]
    [Description(@"Identifies the chain of receiving settlement parties.")]
    [DataMember(Name="RcvgSttlmPties")]
    [XmlElement(ElementName="RcvgSttlmPties")]
    public SettlementParties5? ReceivingSettlementParties { get; init; }
    
    /// <summary>
    /// Cash parties involved in the transaction if different for the securities settlement parties.
    /// </summary>
    [IsoId("_7FHQU9E5Ed-BzquC8wXy7w_1627901613")]
    [Description(@"Cash parties involved in the transaction if different for the securities settlement parties.")]
    [DataMember(Name="CshPties")]
    [XmlElement(ElementName="CshPties")]
    public CashParties3? CashParties { get; init; }
    
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_7FHQVNE5Ed-BzquC8wXy7w_1387793819")]
    [Description(@"Total amount of money to be paid or received in exchange for the securities.")]
    [DataMember(Name="SttlmAmt")]
    [XmlElement(ElementName="SttlmAmt")]
    public AmountAndDirection2? SettlementAmount { get; init; }
    
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_7FHQVdE5Ed-BzquC8wXy7w_-866180806")]
    [Description(@"Other amounts than the settlement amount.")]
    [DataMember(Name="OthrAmts")]
    [XmlElement(ElementName="OthrAmts")]
    public OtherAmounts3? OtherAmounts { get; init; }
    
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_7FHQVtE5Ed-BzquC8wXy7w_133182261")]
    [Description(@"Other business parties relevant to the transaction.")]
    [DataMember(Name="OthrBizPties")]
    [XmlElement(ElementName="OthrBizPties")]
    public OtherParties2? OtherBusinessParties { get; init; }
    
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_7FHQV9E5Ed-BzquC8wXy7w_1755381402")]
    [Description(@"Party that originated the message, if other than the sender.")]
    [DataMember(Name="MsgOrgtr")]
    [XmlElement(ElementName="MsgOrgtr")]
    public PartyIdentification10Choice_? MessageOriginator { get; init; }
    
    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_7FHQWNE5Ed-BzquC8wXy7w_1752610282")]
    [Description(@"Party that is the final destination of the message, if other than the receiver.")]
    [DataMember(Name="MsgRcpt")]
    [XmlElement(ElementName="MsgRcpt")]
    public PartyIdentification10Choice_? MessageRecipient { get; init; }
    
    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    [IsoId("_7FQaQNE5Ed-BzquC8wXy7w_-1372736126")]
    [Description(@"Provides information required for the registration or physical settlement.")]
    [DataMember(Name="AddtlPhysOrRegnDtls")]
    [XmlElement(ElementName="AddtlPhysOrRegnDtls")]
    public RegistrationParameters1? AdditionalPhysicalOrRegistrationDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7FQaQdE5Ed-BzquC8wXy7w_1444936856")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension2? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionInstructionV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionInstructionV01Document ToDocument()
    {
        return new SecuritiesSettlementTransactionInstructionV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementTransactionInstructionV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesSettlementTransactionInstructionV01Document : IOuterDocument<SecuritiesSettlementTransactionInstructionV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.023.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionInstructionV01"/> is required.
    /// </summary>
    public required SecuritiesSettlementTransactionInstructionV01 Message { get; init; }
}
