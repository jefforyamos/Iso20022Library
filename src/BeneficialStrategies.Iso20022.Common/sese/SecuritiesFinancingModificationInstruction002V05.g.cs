﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingModificationInstruction002V05.  ISO2002 ID# _5-ASA5NLEeWGlc8L7oPDIg.
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
/// This record is an implementation of the sese.036.002.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
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
/// 
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
public partial record SecuritiesFinancingModificationInstruction002V05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.036.002.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgModInstr";
    
    #nullable enable
    /// <summary>
    /// Securities financing transaction identification information, type (repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing), modification information and other parameters.
    /// </summary>
    [IsoId("_5-ASB5NLEeWGlc8L7oPDIg")]
    [Description(@"Securities financing transaction identification information, type (repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing), modification information and other parameters.")]
    [DataMember(Name="TxTpAndModAddtlParams")]
    [XmlElement(ElementName="TxTpAndModAddtlParams")]
    [Required]
    public required TransactionTypeAndAdditionalParameters14 TransactionTypeAndModificationAdditionalParameters { get; init; }
    
    /// <summary>
    /// Details of the securities financing deal.
    /// </summary>
    [IsoId("_5-ASCZNLEeWGlc8L7oPDIg")]
    [Description(@"Details of the securities financing deal.")]
    [DataMember(Name="TradDtls")]
    [XmlElement(ElementName="TradDtls")]
    [Required]
    public required SecuritiesTradeDetails12 TradeDetails { get; init; }
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_5-ASC5NLEeWGlc8L7oPDIg")]
    [Description(@"Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_5-ASDZNLEeWGlc8L7oPDIg")]
    [Description(@"Details related to the account and quantity involved in the transaction.")]
    [DataMember(Name="QtyAndAcctDtls")]
    [XmlElement(ElementName="QtyAndAcctDtls")]
    [Required]
    public required QuantityAndAccount48 QuantityAndAccountDetails { get; init; }
    
    /// <summary>
    /// Details of the closing of the securities financing transaction.
    /// </summary>
    [IsoId("_5-ASD5NLEeWGlc8L7oPDIg")]
    [Description(@"Details of the closing of the securities financing transaction.")]
    [DataMember(Name="SctiesFincgAddtlDtls")]
    [XmlElement(ElementName="SctiesFincgAddtlDtls")]
    [Required]
    public required SecuritiesFinancingTransactionDetails32 SecuritiesFinancingAdditionalDetails { get; init; }
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_5-ASEZNLEeWGlc8L7oPDIg")]
    [Description(@"Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.")]
    [DataMember(Name="SttlmParams")]
    [XmlElement(ElementName="SttlmParams")]
    public SettlementDetails106? SettlementParameters { get; init; }
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_5-ASE5NLEeWGlc8L7oPDIg")]
    [Description(@"Identifies the chain of delivering settlement parties.")]
    [DataMember(Name="DlvrgSttlmPties")]
    [XmlElement(ElementName="DlvrgSttlmPties")]
    public SettlementParties44? DeliveringSettlementParties { get; init; }
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_5-ASFZNLEeWGlc8L7oPDIg")]
    [Description(@"Identifies the chain of receiving settlement parties.")]
    [DataMember(Name="RcvgSttlmPties")]
    [XmlElement(ElementName="RcvgSttlmPties")]
    public SettlementParties44? ReceivingSettlementParties { get; init; }
    
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities at the opening of a securities financing transaction.
    /// </summary>
    [IsoId("_5-ASF5NLEeWGlc8L7oPDIg")]
    [Description(@"Total amount of money to be paid or received in exchange for the securities at the opening of a securities financing transaction.")]
    [DataMember(Name="OpngSttlmAmt")]
    [XmlElement(ElementName="OpngSttlmAmt")]
    public AmountAndDirection66? OpeningSettlementAmount { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5-ASGZNLEeWGlc8L7oPDIg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesFinancingModificationInstruction002V05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingModificationInstruction002V05Document ToDocument()
    {
        return new SecuritiesFinancingModificationInstruction002V05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesFinancingModificationInstruction002V05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesFinancingModificationInstruction002V05Document : IOuterDocument<SecuritiesFinancingModificationInstruction002V05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.036.002.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesFinancingModificationInstruction002V05"/> is required.
    /// </summary>
    public required SecuritiesFinancingModificationInstruction002V05 Message { get; init; }
}
