﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingModificationInstructionV06.  ISO2002 ID# _CT-xAW6vEeat2-NFbXd1Pw.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// An account owner sends a SecuritiesFinancingModificationInstruction to a securities financing transaction account servicer to notify the securities financing transaction account servicer of an update in the details of a repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing transaction that does not impact the original transaction securities quantity.
/// Such a change may be:
/// - the providing of closing details not available at the time of the sending of the Securities Financing Instruction, for example, termination date for an open repo,
/// - the providing of a new rate, for example, a repo rate,
/// - the rollover of a position extending the closing or maturity date.
/// The account owner/servicer relationship may be:
/// - a global custodian which has an account with a local custodian, or
/// - an investment management institution which manage a fund account opened at a custodian, or
/// - a broker which has an account with a custodian, or
/// - a central securities depository participant which has an account with a central securities depository, or
/// - a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or
/// - a central counterparty or a stock exchange or a trade matching utility which need to instruct the settlement of securities financing transactions to a central securities depository or another settlement market infrastructure.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account owner sends a SecuritiesFinancingModificationInstruction to a securities financing transaction account servicer to notify the securities financing transaction account servicer of an update in the details of a repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing transaction that does not impact the original transaction securities quantity.|Such a change may be:|- the providing of closing details not available at the time of the sending of the Securities Financing Instruction, for example, termination date for an open repo,|- the providing of a new rate, for example, a repo rate,|- the rollover of a position extending the closing or maturity date.|The account owner/servicer relationship may be:|- a global custodian which has an account with a local custodian, or|- an investment management institution which manage a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository participant which has an account with a central securities depository, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or|- a central counterparty or a stock exchange or a trade matching utility which need to instruct the settlement of securities financing transactions to a central securities depository or another settlement market infrastructure.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesFinancingModificationInstructionV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgModInstr";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Securities financing transaction identification information, type (repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing), modification information and other parameters.
    /// </summary>
    [IsoId("_CT-xBW6vEeat2-NFbXd1Pw")]
    [Description(@"Securities financing transaction identification information, type (repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing), modification information and other parameters.")]
    [DataMember(Name="TxTpAndModAddtlParams")]
    [XmlElement(ElementName="TxTpAndModAddtlParams")]
    [Required]
    public required TransactionTypeAndAdditionalParameters17 TransactionTypeAndModificationAdditionalParameters { get; init; }
    
    /// <summary>
    /// Details of the securities financing deal.
    /// </summary>
    [IsoId("_CT-xB26vEeat2-NFbXd1Pw")]
    [Description(@"Details of the securities financing deal.")]
    [DataMember(Name="TradDtls")]
    [XmlElement(ElementName="TradDtls")]
    [Required]
    public required SecuritiesTradeDetails5 TradeDetails { get; init; }
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_CT-xCW6vEeat2-NFbXd1Pw")]
    [Description(@"Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_CT-xC26vEeat2-NFbXd1Pw")]
    [Description(@"Details related to the account and quantity involved in the transaction.")]
    [DataMember(Name="QtyAndAcctDtls")]
    [XmlElement(ElementName="QtyAndAcctDtls")]
    [Required]
    public required QuantityAndAccount38 QuantityAndAccountDetails { get; init; }
    
    /// <summary>
    /// Details of the closing of the securities financing transaction.
    /// </summary>
    [IsoId("_CT-xDW6vEeat2-NFbXd1Pw")]
    [Description(@"Details of the closing of the securities financing transaction.")]
    [DataMember(Name="SctiesFincgAddtlDtls")]
    [XmlElement(ElementName="SctiesFincgAddtlDtls")]
    [Required]
    public required SecuritiesFinancingTransactionDetails27 SecuritiesFinancingAdditionalDetails { get; init; }
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_CT-xD26vEeat2-NFbXd1Pw")]
    [Description(@"Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.")]
    [DataMember(Name="SttlmParams")]
    [XmlElement(ElementName="SttlmParams")]
    public SettlementDetails97? SettlementParameters { get; init; }
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_CT-xEW6vEeat2-NFbXd1Pw")]
    [Description(@"Identifies the chain of delivering settlement parties.")]
    [DataMember(Name="DlvrgSttlmPties")]
    [XmlElement(ElementName="DlvrgSttlmPties")]
    public SettlementParties36? DeliveringSettlementParties { get; init; }
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_CT-xE26vEeat2-NFbXd1Pw")]
    [Description(@"Identifies the chain of receiving settlement parties.")]
    [DataMember(Name="RcvgSttlmPties")]
    [XmlElement(ElementName="RcvgSttlmPties")]
    public SettlementParties36? ReceivingSettlementParties { get; init; }
    
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities at the opening of a securities financing transaction.
    /// </summary>
    [IsoId("_CT-xFW6vEeat2-NFbXd1Pw")]
    [Description(@"Total amount of money to be paid or received in exchange for the securities at the opening of a securities financing transaction.")]
    [DataMember(Name="OpngSttlmAmt")]
    [XmlElement(ElementName="OpngSttlmAmt")]
    public AmountAndDirection49? OpeningSettlementAmount { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_CT-xF26vEeat2-NFbXd1Pw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesFinancingModificationInstructionV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingModificationInstructionV06Document ToDocument()
    {
        return new SecuritiesFinancingModificationInstructionV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesFinancingModificationInstructionV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesFinancingModificationInstructionV06Document : IOuterDocument<SecuritiesFinancingModificationInstructionV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.036.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesFinancingModificationInstructionV06"/> is required.
    /// </summary>
    public required SecuritiesFinancingModificationInstructionV06 Message { get; init; }
}
