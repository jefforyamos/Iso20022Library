﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionGenerationNotificationV01.  ISO2002 ID# _5mVlONE5Ed-BzquC8wXy7w_-1419271688.
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
/// Scope
/// An account servicer sends a SecuritiesSettlementTransactionGenerationNotification to an account owner to advise the account owner of a securities settlement transaction that has been generated/created by the account servicer for the account owner. The reason for creation can range from the automatic transformation of pending settlement instructions following a corporate event to the recovery of an account owner transactions' database initiated by its account servicer.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends a SecuritiesSettlementTransactionGenerationNotification to an account owner to advise the account owner of a securities settlement transaction that has been generated/created by the account servicer for the account owner. The reason for creation can range from the automatic transformation of pending settlement instructions following a corporate event to the recovery of an account owner transactions' database initiated by its account servicer.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
public partial record SecuritiesSettlementTransactionGenerationNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxGnrtnNtfctn";
    
    #nullable enable
    /// <summary>
    /// Information that unambiguously identifies a SecuritiesSettlementTransaction and a SecuritiesSettlementTransactionGenerationNotification message as known by the account servicer.
    /// </summary>
    [IsoId("_5mVlOdE5Ed-BzquC8wXy7w_-695230741")]
    [Description(@"Information that unambiguously identifies a SecuritiesSettlementTransaction and a SecuritiesSettlementTransactionGenerationNotification message as known by the account servicer.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required DocumentIdentification11 Identification { get; init; }
    
    /// <summary>
    /// Provides transaction type and identification information.
    /// </summary>
    [IsoId("_5mVlOtE5Ed-BzquC8wXy7w_-652750324")]
    [Description(@"Provides transaction type and identification information.")]
    [DataMember(Name="TxIdDtls")]
    [XmlElement(ElementName="TxIdDtls")]
    [Required]
    public required SettlementTypeAndIdentification1 TransactionIdentificationDetails { get; init; }
    
    /// <summary>
    /// Count of the number of transactions linked.
    /// </summary>
    [IsoId("_5mfWMNE5Ed-BzquC8wXy7w_395446162")]
    [Description(@"Count of the number of transactions linked.")]
    [DataMember(Name="NbCounts")]
    [XmlElement(ElementName="NbCounts")]
    public INumberCount1Choice? NumberCounts { get; init; }
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_5mfWMdE5Ed-BzquC8wXy7w_696513904")]
    [Description(@"Link to another transaction that must be processed after, before or at the same time.")]
    [DataMember(Name="Lnkgs")]
    [XmlElement(ElementName="Lnkgs")]
    public Linkages1? Linkages { get; init; }
    
    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_5mfWMtE5Ed-BzquC8wXy7w_666210297")]
    [Description(@"Details of the trade.")]
    [DataMember(Name="TradDtls")]
    [XmlElement(ElementName="TradDtls")]
    [Required]
    public required SecuritiesTradeDetails1 TradeDetails { get; init; }
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_5mfWM9E5Ed-BzquC8wXy7w_1010684014")]
    [Description(@"Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification11 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_5mfWNNE5Ed-BzquC8wXy7w_1597119434")]
    [Description(@"Elements characterising a financial instrument.")]
    [DataMember(Name="FinInstrmAttrbts")]
    [XmlElement(ElementName="FinInstrmAttrbts")]
    public FinancialInstrumentAttributes8? FinancialInstrumentAttributes { get; init; }
    
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_5mfWNdE5Ed-BzquC8wXy7w_1183384318")]
    [Description(@"Details related to the account and quantity involved in the transaction.")]
    [DataMember(Name="QtyAndAcctDtls")]
    [XmlElement(ElementName="QtyAndAcctDtls")]
    [Required]
    public required QuantityAndAccount1 QuantityAndAccountDetails { get; init; }
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_5mfWNtE5Ed-BzquC8wXy7w_1982229366")]
    [Description(@"Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.")]
    [DataMember(Name="SttlmParams")]
    [XmlElement(ElementName="SttlmParams")]
    [Required]
    public required SettlementDetails1 SettlementParameters { get; init; }
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_5mfWN9E5Ed-BzquC8wXy7w_-1910083503")]
    [Description(@"Identifies the chain of delivering settlement parties.")]
    [DataMember(Name="DlvrgSttlmPties")]
    [XmlElement(ElementName="DlvrgSttlmPties")]
    public SettlementParties5? DeliveringSettlementParties { get; init; }
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_5mogINE5Ed-BzquC8wXy7w_-1813112896")]
    [Description(@"Identifies the chain of receiving settlement parties.")]
    [DataMember(Name="RcvgSttlmPties")]
    [XmlElement(ElementName="RcvgSttlmPties")]
    public SettlementParties5? ReceivingSettlementParties { get; init; }
    
    /// <summary>
    /// Cash parties involved in the transaction if different for the securities settlement parties.
    /// </summary>
    [IsoId("_5mogIdE5Ed-BzquC8wXy7w_-1450170571")]
    [Description(@"Cash parties involved in the transaction if different for the securities settlement parties.")]
    [DataMember(Name="CshPties")]
    [XmlElement(ElementName="CshPties")]
    public CashParties3? CashParties { get; init; }
    
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_5mogItE5Ed-BzquC8wXy7w_-1338422191")]
    [Description(@"Total amount of money to be paid or received in exchange for the securities.")]
    [DataMember(Name="SttlmAmt")]
    [XmlElement(ElementName="SttlmAmt")]
    public AmountAndDirection2? SettlementAmount { get; init; }
    
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_5mogI9E5Ed-BzquC8wXy7w_-993028112")]
    [Description(@"Other amounts than the settlement amount.")]
    [DataMember(Name="OthrAmts")]
    [XmlElement(ElementName="OthrAmts")]
    public OtherAmounts3? OtherAmounts { get; init; }
    
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_5mogJNE5Ed-BzquC8wXy7w_-480470781")]
    [Description(@"Other business parties relevant to the transaction.")]
    [DataMember(Name="OthrBizPties")]
    [XmlElement(ElementName="OthrBizPties")]
    public OtherParties2? OtherBusinessParties { get; init; }
    
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_5mogJdE5Ed-BzquC8wXy7w_-179340731")]
    [Description(@"Party that originated the message, if other than the sender.")]
    [DataMember(Name="MsgOrgtr")]
    [XmlElement(ElementName="MsgOrgtr")]
    public IPartyIdentification10Choice? MessageOriginator { get; init; }
    
    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_5mogJtE5Ed-BzquC8wXy7w_-164566824")]
    [Description(@"Party that is the final destination of the message, if other than the receiver.")]
    [DataMember(Name="MsgRcpt")]
    [XmlElement(ElementName="MsgRcpt")]
    public IPartyIdentification10Choice? MessageRecipient { get; init; }
    
    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    [IsoId("_5mogJ9E5Ed-BzquC8wXy7w_-362260078")]
    [Description(@"Provides information required for the registration or physical settlement.")]
    [DataMember(Name="AddtlPhysOrRegnDtls")]
    [XmlElement(ElementName="AddtlPhysOrRegnDtls")]
    public RegistrationParameters1? AdditionalPhysicalOrRegistrationDetails { get; init; }
    
    /// <summary>
    /// Specifies the reason why the transaction was generated.
    /// </summary>
    [IsoId("_5myRINE5Ed-BzquC8wXy7w_607012453")]
    [Description(@"Specifies the reason why the transaction was generated.")]
    [DataMember(Name="GnrtdRsn")]
    [XmlElement(ElementName="GnrtdRsn")]
    public GeneratedReason1? GeneratedReason { get; init; }
    
    /// <summary>
    /// Status and reason of the transaction.
    /// </summary>
    [IsoId("_5myRIdE5Ed-BzquC8wXy7w_-505343159")]
    [Description(@"Status and reason of the transaction.")]
    [DataMember(Name="StsAndRsn")]
    [XmlElement(ElementName="StsAndRsn")]
    public StatusAndReason3? StatusAndReason { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5myRItE5Ed-BzquC8wXy7w_9980498")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension2? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionGenerationNotificationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionGenerationNotificationV01Document ToDocument()
    {
        return new SecuritiesSettlementTransactionGenerationNotificationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementTransactionGenerationNotificationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesSettlementTransactionGenerationNotificationV01Document : IOuterDocument<SecuritiesSettlementTransactionGenerationNotificationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.032.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionGenerationNotificationV01"/> is required.
    /// </summary>
    public required SecuritiesSettlementTransactionGenerationNotificationV01 Message { get; init; }
}
