﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionReversalAdvice002V10.  ISO2002 ID# _fz0-kzi8Eeydid5dcNPKvg.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// An account servicer sends a SecuritiesSettlementTransactionReversalAdvice to an account owner to reverse the confirmation of a partial or full delivery or receipt of financial instruments, free or against of payment, physically or by book-entry.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends a SecuritiesSettlementTransactionReversalAdvice to an account owner to reverse the confirmation of a partial or full delivery or receipt of financial instruments, free or against of payment, physically or by book-entry.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.")]
public partial record SecuritiesSettlementTransactionReversalAdvice002V10 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxRvslAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Provides transaction type and identification information.
    /// </summary>
    [IsoId("_fz0-pTi8Eeydid5dcNPKvg")]
    [Description(@"Provides transaction type and identification information.")]
    [DataMember(Name="TxIdDtls")]
    [XmlElement(ElementName="TxIdDtls")]
    [Required]
    public required SettlementTypeAndIdentification28 TransactionIdentificationDetails { get; init; }
    
    /// <summary>
    /// Reference to the unambiguous identification of the confirmation as per the account servicer.
    /// </summary>
    [IsoId("_fz0-pzi8Eeydid5dcNPKvg")]
    [Description(@"Reference to the unambiguous identification of the confirmation as per the account servicer.")]
    [DataMember(Name="ConfRef")]
    [XmlElement(ElementName="ConfRef")]
    [Required]
    public required IsoRestrictedFINXMax16Text ConfirmationReference { get; init; }
    
    /// <summary>
    /// Additional parameters for the transaction.
    /// </summary>
    [IsoId("_fz0-qTi8Eeydid5dcNPKvg")]
    [Description(@"Additional parameters for the transaction.")]
    [DataMember(Name="AddtlParams")]
    [XmlElement(ElementName="AddtlParams")]
    public AdditionalParameters32? AdditionalParameters { get; init; }
    
    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_fz0-qzi8Eeydid5dcNPKvg")]
    [Description(@"Details of the trade.")]
    [DataMember(Name="TradDtls")]
    [XmlElement(ElementName="TradDtls")]
    [Required]
    public required SecuritiesTradeDetails128 TradeDetails { get; init; }
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_fz0-rTi8Eeydid5dcNPKvg")]
    [Description(@"Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_fz0-rzi8Eeydid5dcNPKvg")]
    [Description(@"Elements characterising a financial instrument.")]
    [DataMember(Name="FinInstrmAttrbts")]
    [XmlElement(ElementName="FinInstrmAttrbts")]
    public FinancialInstrumentAttributes122? FinancialInstrumentAttributes { get; init; }
    
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_fz0-sTi8Eeydid5dcNPKvg")]
    [Description(@"Details related to the account and quantity involved in the transaction.")]
    [DataMember(Name="QtyAndAcctDtls")]
    [XmlElement(ElementName="QtyAndAcctDtls")]
    [Required]
    public required QuantityAndAccount108 QuantityAndAccountDetails { get; init; }
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_fz0-szi8Eeydid5dcNPKvg")]
    [Description(@"Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.")]
    [DataMember(Name="SttlmParams")]
    [XmlElement(ElementName="SttlmParams")]
    [Required]
    public required SettlementDetails209 SettlementParameters { get; init; }
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_fz0-tTi8Eeydid5dcNPKvg")]
    [Description(@"Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.")]
    [DataMember(Name="StgSttlmInstrDtls")]
    [XmlElement(ElementName="StgSttlmInstrDtls")]
    public StandingSettlementInstruction19? StandingSettlementInstructionDetails { get; init; }
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_fz0-tzi8Eeydid5dcNPKvg")]
    [Description(@"Identifies the chain of delivering settlement parties.")]
    [DataMember(Name="DlvrgSttlmPties")]
    [XmlElement(ElementName="DlvrgSttlmPties")]
    public SettlementParties105? DeliveringSettlementParties { get; init; }
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_fz0-uTi8Eeydid5dcNPKvg")]
    [Description(@"Identifies the chain of receiving settlement parties.")]
    [DataMember(Name="RcvgSttlmPties")]
    [XmlElement(ElementName="RcvgSttlmPties")]
    public SettlementParties105? ReceivingSettlementParties { get; init; }
    
    /// <summary>
    /// Cash parties involved in the transaction if different from the securities settlement parties.
    /// </summary>
    [IsoId("_fz0-uzi8Eeydid5dcNPKvg")]
    [Description(@"Cash parties involved in the transaction if different from the securities settlement parties.")]
    [DataMember(Name="CshPties")]
    [XmlElement(ElementName="CshPties")]
    public CashParties40? CashParties { get; init; }
    
    /// <summary>
    /// Amount effectively settled and which will be credited to/debited from the account owner's cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_fz0-vTi8Eeydid5dcNPKvg")]
    [Description(@"Amount effectively settled and which will be credited to/debited from the account owner's cash account. It may differ from the instructed settlement amount based on market tolerance level.")]
    [DataMember(Name="SttldAmt")]
    [XmlElement(ElementName="SttldAmt")]
    public AmountAndDirection96? SettledAmount { get; init; }
    
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_fz0-vzi8Eeydid5dcNPKvg")]
    [Description(@"Other amounts than the settlement amount.")]
    [DataMember(Name="OthrAmts")]
    [XmlElement(ElementName="OthrAmts")]
    public OtherAmounts44? OtherAmounts { get; init; }
    
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_fz0-wTi8Eeydid5dcNPKvg")]
    [Description(@"Other business parties relevant to the transaction.")]
    [DataMember(Name="OthrBizPties")]
    [XmlElement(ElementName="OthrBizPties")]
    public OtherParties44? OtherBusinessParties { get; init; }
    
    /// <summary>
    /// Information for registration or physical settlement.
    /// </summary>
    [IsoId("_fz0-wzi8Eeydid5dcNPKvg")]
    [Description(@"Information for registration or physical settlement.")]
    [DataMember(Name="AddtlPhysOrRegnDtls")]
    [XmlElement(ElementName="AddtlPhysOrRegnDtls")]
    public RegistrationParameters7? AdditionalPhysicalOrRegistrationDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_fz0-xTi8Eeydid5dcNPKvg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionReversalAdvice002V10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionReversalAdvice002V10Document ToDocument()
    {
        return new SecuritiesSettlementTransactionReversalAdvice002V10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementTransactionReversalAdvice002V10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesSettlementTransactionReversalAdvice002V10Document : IOuterDocument<SecuritiesSettlementTransactionReversalAdvice002V10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.026.002.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionReversalAdvice002V10"/> is required.
    /// </summary>
    public required SecuritiesSettlementTransactionReversalAdvice002V10 Message { get; init; }
}
