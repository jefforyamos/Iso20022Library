﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionConfirmation002V09.  ISO2002 ID# _5-eII_fXEeiNZp_PtLohLw.
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
/// An account servicer sends a SecuritiesSettlementTransactionConfirmation to an account owner to confirm the partial or full delivery or receipt of financial instruments, free or against of payment, physically or by book-entry.
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
[Description(@"Scope|An account servicer sends a SecuritiesSettlementTransactionConfirmation to an account owner to confirm the partial or full delivery or receipt of financial instruments, free or against of payment, physically or by book-entry.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.")]
public partial record SecuritiesSettlementTransactionConfirmation002V09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxConf";
    
    #nullable enable
    /// <summary>
    /// Provides transaction type and identification information.
    /// </summary>
    [IsoId("_5-eINffXEeiNZp_PtLohLw")]
    [Description(@"Provides transaction type and identification information.")]
    [DataMember(Name="TxIdDtls")]
    [XmlElement(ElementName="TxIdDtls")]
    [Required]
    public required SettlementTypeAndIdentification24 TransactionIdentificationDetails { get; init; }
    
    /// <summary>
    /// Link to another transaction - provided for information only.
    /// </summary>
    [IsoId("_5-eIN_fXEeiNZp_PtLohLw")]
    [Description(@"Link to another transaction - provided for information only.")]
    [DataMember(Name="Lnkgs")]
    [XmlElement(ElementName="Lnkgs")]
    public Linkages50? Linkages { get; init; }
    
    /// <summary>
    /// Additional parameters for the transaction.
    /// </summary>
    [IsoId("_5-eIOffXEeiNZp_PtLohLw")]
    [Description(@"Additional parameters for the transaction.")]
    [DataMember(Name="AddtlParams")]
    [XmlElement(ElementName="AddtlParams")]
    public AdditionalParameters31? AdditionalParameters { get; init; }
    
    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_5-eIO_fXEeiNZp_PtLohLw")]
    [Description(@"Details of the trade.")]
    [DataMember(Name="TradDtls")]
    [XmlElement(ElementName="TradDtls")]
    [Required]
    public required SecuritiesTradeDetails106 TradeDetails { get; init; }
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_5-eIPffXEeiNZp_PtLohLw")]
    [Description(@"Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_5-eIP_fXEeiNZp_PtLohLw")]
    [Description(@"Elements characterising a financial instrument.")]
    [DataMember(Name="FinInstrmAttrbts")]
    [XmlElement(ElementName="FinInstrmAttrbts")]
    public FinancialInstrumentAttributes97? FinancialInstrumentAttributes { get; init; }
    
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_5-eIQffXEeiNZp_PtLohLw")]
    [Description(@"Details related to the account and quantity involved in the transaction.")]
    [DataMember(Name="QtyAndAcctDtls")]
    [XmlElement(ElementName="QtyAndAcctDtls")]
    [Required]
    public required QuantityAndAccount90 QuantityAndAccountDetails { get; init; }
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_5-eIQ_fXEeiNZp_PtLohLw")]
    [Description(@"Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.")]
    [DataMember(Name="SttlmParams")]
    [XmlElement(ElementName="SttlmParams")]
    [Required]
    public required SettlementDetails176 SettlementParameters { get; init; }
    
    /// <summary>
    /// Settlement standing instruction database to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_5-eIRffXEeiNZp_PtLohLw")]
    [Description(@"Settlement standing instruction database to be used to derive the settlement parties involved in the transaction.")]
    [DataMember(Name="StgSttlmInstrDtls")]
    [XmlElement(ElementName="StgSttlmInstrDtls")]
    public StandingSettlementInstruction17? StandingSettlementInstructionDetails { get; init; }
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_5-eIR_fXEeiNZp_PtLohLw")]
    [Description(@"Identifies the chain of delivering settlement parties.")]
    [DataMember(Name="DlvrgSttlmPties")]
    [XmlElement(ElementName="DlvrgSttlmPties")]
    public SettlementParties81? DeliveringSettlementParties { get; init; }
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_5-eISffXEeiNZp_PtLohLw")]
    [Description(@"Identifies the chain of receiving settlement parties.")]
    [DataMember(Name="RcvgSttlmPties")]
    [XmlElement(ElementName="RcvgSttlmPties")]
    public SettlementParties81? ReceivingSettlementParties { get; init; }
    
    /// <summary>
    /// Cash parties involved in the transaction if different from the securities settlement parties.
    /// </summary>
    [IsoId("_5-eIS_fXEeiNZp_PtLohLw")]
    [Description(@"Cash parties involved in the transaction if different from the securities settlement parties.")]
    [DataMember(Name="CshPties")]
    [XmlElement(ElementName="CshPties")]
    public CashParties38? CashParties { get; init; }
    
    /// <summary>
    /// Amount effectively settled and which will be credited to/debited from the account owner's cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("_5-eITffXEeiNZp_PtLohLw")]
    [Description(@"Amount effectively settled and which will be credited to/debited from the account owner's cash account. It may differ from the instructed settlement amount based on market tolerance level.")]
    [DataMember(Name="SttldAmt")]
    [XmlElement(ElementName="SttldAmt")]
    public AmountAndDirection96? SettledAmount { get; init; }
    
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_5-eIT_fXEeiNZp_PtLohLw")]
    [Description(@"Other amounts than the settlement amount.")]
    [DataMember(Name="OthrAmts")]
    [XmlElement(ElementName="OthrAmts")]
    public OtherAmounts44? OtherAmounts { get; init; }
    
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_5-eIUffXEeiNZp_PtLohLw")]
    [Description(@"Other business parties relevant to the transaction.")]
    [DataMember(Name="OthrBizPties")]
    [XmlElement(ElementName="OthrBizPties")]
    public OtherParties35? OtherBusinessParties { get; init; }
    
    /// <summary>
    /// Information for registration or physical settlement.
    /// </summary>
    [IsoId("_5-eIU_fXEeiNZp_PtLohLw")]
    [Description(@"Information for registration or physical settlement.")]
    [DataMember(Name="AddtlPhysOrRegnDtls")]
    [XmlElement(ElementName="AddtlPhysOrRegnDtls")]
    public RegistrationParameters7? AdditionalPhysicalOrRegistrationDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5-eIVffXEeiNZp_PtLohLw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionConfirmation002V09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionConfirmation002V09Document ToDocument()
    {
        return new SecuritiesSettlementTransactionConfirmation002V09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementTransactionConfirmation002V09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesSettlementTransactionConfirmation002V09Document : IOuterDocument<SecuritiesSettlementTransactionConfirmation002V09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.025.002.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionConfirmation002V09"/> is required.
    /// </summary>
    public required SecuritiesSettlementTransactionConfirmation002V09 Message { get; init; }
}
