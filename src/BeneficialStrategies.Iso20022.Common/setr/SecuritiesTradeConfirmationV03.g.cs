﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesTradeConfirmationV03.  ISO2002 ID# _L2hN0S9UEeOdVfle5cojCg.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// SCOPE
/// Sent by an executing party to an instructing party directly or through Central Matching Utility (CMU) to provide trade confirmation on a per-account basis based on instructions provided by the instructing party in the SecuritiesAllocationInstruction message.
/// It may also be used to provide trade confirmation on the trade level from an executing party or an instructing party to the custodian or an affirming party directly or through CMU.
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.
/// The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// The custodian or the affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.
/// USAGE
/// Initiator: In local matching, the initiator of this message is always the executing party. In central matching the initiator may be either the executing party or instructing party.
/// Respondent: instructing party, a custodian or an affirming party responds with SecuritiesTradeConfirmationResponse (accept or reject) message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"SCOPE|Sent by an executing party to an instructing party directly or through Central Matching Utility (CMU) to provide trade confirmation on a per-account basis based on instructions provided by the instructing party in the SecuritiesAllocationInstruction message.||It may also be used to provide trade confirmation on the trade level from an executing party or an instructing party to the custodian or an affirming party directly or through CMU.||The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.|The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|The custodian or the affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.||USAGE|Initiator: In local matching, the initiator of this message is always the executing party. In central matching the initiator may be either the executing party or instructing party.|Respondent: instructing party, a custodian or an affirming party responds with SecuritiesTradeConfirmationResponse (accept or reject) message.")]
public partial record SecuritiesTradeConfirmationV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information that unambiguously identifies an SecuritiesTradeConfirmation message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_L2hN0y9UEeOdVfle5cojCg")]
    [Description(@"Information that unambiguously identifies an SecuritiesTradeConfirmation message as known by the account owner (or the instructing party acting on its behalf).")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required SomeIdentificationRecord Identification { get; init; }
    
    /// <summary>
    /// Count of the number of transactions linked.
    /// </summary>
    [IsoId("_L2hN1S9UEeOdVfle5cojCg")]
    [Description(@"Count of the number of transactions linked.")]
    [DataMember(Name="NbCnt")]
    [XmlElement(ElementName="NbCnt")]
    public SomeNumberCountRecord? NumberCount { get; init; }
    
    /// <summary>
    /// Reference to the transaction identifier issued by a business party and/or market infrastructure. It may also be used to reference a previous transaction, for example, a block/allocation instruction, or tie a set of messages together.
    /// </summary>
    [IsoId("_L2hN1y9UEeOdVfle5cojCg")]
    [Description(@"Reference to the transaction identifier issued by a business party and/or market infrastructure. It may also be used to reference a previous transaction, for example, a block/allocation instruction, or tie a set of messages together.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    public SomeReferencesRecord? References { get; init; }
    
    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_L2hN2S9UEeOdVfle5cojCg")]
    [Description(@"Details of the trade.")]
    [DataMember(Name="TradDtls")]
    [XmlElement(ElementName="TradDtls")]
    [Required]
    public required SomeTradeDetailsRecord TradeDetails { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial instrument, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_L2hN2y9UEeOdVfle5cojCg")]
    [Description(@"Unique and unambiguous identifier of a financial instrument, assigned under a formal or proprietary identification scheme.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SomeFinancialInstrumentIdentificationRecord FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_L2hN3S9UEeOdVfle5cojCg")]
    [Description(@"Elements characterising a financial instrument.")]
    [DataMember(Name="FinInstrmAttrbts")]
    [XmlElement(ElementName="FinInstrmAttrbts")]
    public SomeFinancialInstrumentAttributesRecord? FinancialInstrumentAttributes { get; init; }
    
    /// <summary>
    /// Underlying financial instrument to which an trade confirmation is related.
    /// </summary>
    [IsoId("_L2hN3y9UEeOdVfle5cojCg")]
    [Description(@"Underlying financial instrument to which an trade confirmation is related.")]
    [DataMember(Name="UndrlygFinInstrm")]
    [XmlElement(ElementName="UndrlygFinInstrm")]
    public SomeUnderlyingFinancialInstrumentRecord? UnderlyingFinancialInstrument { get; init; }
    
    /// <summary>
    /// Additional restrictions on the financial instrument, related to the stipulation.
    /// </summary>
    [IsoId("_L2hN4S9UEeOdVfle5cojCg")]
    [Description(@"Additional restrictions on the financial instrument, related to the stipulation.")]
    [DataMember(Name="Stiptns")]
    [XmlElement(ElementName="Stiptns")]
    public SomeStipulationsRecord? Stipulations { get; init; }
    
    /// <summary>
    /// Parties involved in the confirmation of the details of a trade.
    /// </summary>
    [IsoId("_L2hN4y9UEeOdVfle5cojCg")]
    [Description(@"Parties involved in the confirmation of the details of a trade.")]
    [DataMember(Name="ConfPties")]
    [XmlElement(ElementName="ConfPties")]
    [Required]
    public required SomeConfirmationPartiesRecord ConfirmationParties { get; init; }
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_L2hN5S9UEeOdVfle5cojCg")]
    [Description(@"Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.")]
    [DataMember(Name="SttlmParams")]
    [XmlElement(ElementName="SttlmParams")]
    public SomeSettlementParametersRecord? SettlementParameters { get; init; }
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_L2hN5y9UEeOdVfle5cojCg")]
    [Description(@"Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.")]
    [DataMember(Name="StgSttlmInstr")]
    [XmlElement(ElementName="StgSttlmInstr")]
    public SomeStandingSettlementInstructionRecord? StandingSettlementInstruction { get; init; }
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_L2hN6S9UEeOdVfle5cojCg")]
    [Description(@"Identifies the chain of delivering settlement parties.")]
    [DataMember(Name="DlvrgSttlmPties")]
    [XmlElement(ElementName="DlvrgSttlmPties")]
    public SomeDeliveringSettlementPartiesRecord? DeliveringSettlementParties { get; init; }
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_L2hN6y9UEeOdVfle5cojCg")]
    [Description(@"Identifies the chain of receiving settlement parties.")]
    [DataMember(Name="RcvgSttlmPties")]
    [XmlElement(ElementName="RcvgSttlmPties")]
    public SomeReceivingSettlementPartiesRecord? ReceivingSettlementParties { get; init; }
    
    /// <summary>
    /// Cash parties involved in the specific transaction.
    /// </summary>
    [IsoId("_L2hN7S9UEeOdVfle5cojCg")]
    [Description(@"Cash parties involved in the specific transaction.")]
    [DataMember(Name="CshPties")]
    [XmlElement(ElementName="CshPties")]
    public SomeCashPartiesRecord? CashParties { get; init; }
    
    /// <summary>
    /// Provides clearing member information.
    /// </summary>
    [IsoId("_L2hN7y9UEeOdVfle5cojCg")]
    [Description(@"Provides clearing member information.")]
    [DataMember(Name="ClrDtls")]
    [XmlElement(ElementName="ClrDtls")]
    public SomeClearingDetailsRecord? ClearingDetails { get; init; }
    
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities. The amount includes the principal with any commissions and fees or accrued interest.
    /// </summary>
    [IsoId("_L2hN8S9UEeOdVfle5cojCg")]
    [Description(@"Total amount of money to be paid or received in exchange for the securities. The amount includes the principal with any commissions and fees or accrued interest.")]
    [DataMember(Name="SttlmAmt")]
    [XmlElement(ElementName="SttlmAmt")]
    public SomeSettlementAmountRecord? SettlementAmount { get; init; }
    
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_L2hN8y9UEeOdVfle5cojCg")]
    [Description(@"Other amounts than the settlement amount.")]
    [DataMember(Name="OthrAmts")]
    [XmlElement(ElementName="OthrAmts")]
    public SomeOtherAmountsRecord? OtherAmounts { get; init; }
    
    /// <summary>
    /// Other prices than the deal price.
    /// </summary>
    [IsoId("_L2hN9S9UEeOdVfle5cojCg")]
    [Description(@"Other prices than the deal price.")]
    [DataMember(Name="OthrPrics")]
    [XmlElement(ElementName="OthrPrics")]
    public SomeOtherPricesRecord? OtherPrices { get; init; }
    
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_L2hN9y9UEeOdVfle5cojCg")]
    [Description(@"Other business parties relevant to the transaction.")]
    [DataMember(Name="OthrBizPties")]
    [XmlElement(ElementName="OthrBizPties")]
    public SomeOtherBusinessPartiesRecord? OtherBusinessParties { get; init; }
    
    /// <summary>
    /// Identifies a transaction that the trading parties are agreeing to repurchase, sell back or return the same or similar securities at a later time. 
    /// The two leg transaction details defines the closing leg conditions of a two leg transaction. It is also used to define the anticipated closing leg conditions at the time of opening the closed-end transaction. 
    /// </summary>
    [IsoId("_L2hN-S9UEeOdVfle5cojCg")]
    [Description(@"Identifies a transaction that the trading parties are agreeing to repurchase, sell back or return the same or similar securities at a later time. |The two leg transaction details defines the closing leg conditions of a two leg transaction. It is also used to define the anticipated closing leg conditions at the time of opening the closed-end transaction. ||")]
    [DataMember(Name="TwoLegTxDtls")]
    [XmlElement(ElementName="TwoLegTxDtls")]
    public SomeTwoLegTransactionDetailsRecord? TwoLegTransactionDetails { get; init; }
    
    /// <summary>
    /// Specifies regulatory stipulations that financial institutions must be compliant with in the country, region, and/or area they conduct business.
    /// </summary>
    [IsoId("_L2hN-y9UEeOdVfle5cojCg")]
    [Description(@"Specifies regulatory stipulations that financial institutions must be compliant with in the country, region, and/or area they conduct business.")]
    [DataMember(Name="RgltryStiptns")]
    [XmlElement(ElementName="RgltryStiptns")]
    public SomeRegulatoryStipulationsRecord? RegulatoryStipulations { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_L2hN_S9UEeOdVfle5cojCg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesTradeConfirmationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesTradeConfirmationV03Document ToDocument()
    {
        return new SecuritiesTradeConfirmationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesTradeConfirmationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesTradeConfirmationV03Document : IOuterDocument<SecuritiesTradeConfirmationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.027.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesTradeConfirmationV03"/> is required.
    /// </summary>
    public required SecuritiesTradeConfirmationV03 Message { get; init; }
}