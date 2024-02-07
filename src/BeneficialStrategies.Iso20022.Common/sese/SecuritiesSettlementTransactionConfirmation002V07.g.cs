﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionConfirmation002V07.  ISO2002 ID# __NTvU5wyEeazcsnODTksnQ.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.sese.SecuritiesSettlementTransactionConfirmation002V07>;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.025.002.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesSettlementTransactionConfirmation to an account owner to confirm the partial or full delivery or receipt of financial instruments, free or against of payment, physically or by book-entry.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information.
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[Description(@"Scope|An account servicer sends a SecuritiesSettlementTransactionConfirmation to an account owner to confirm the partial or full delivery or receipt of financial instruments, free or against of payment, physically or by book-entry.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information.|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesSettlementTransactionConfirmation002V07 : IOuterRecord<SecuritiesSettlementTransactionConfirmation002V07,SecuritiesSettlementTransactionConfirmation002V07Document>
    ,IIsoXmlSerilizable<SecuritiesSettlementTransactionConfirmation002V07>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.025.002.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxConf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesSettlementTransactionConfirmation002V07Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Provides transaction type and identification information.
    /// </summary>
    [IsoId("__NTvZZwyEeazcsnODTksnQ")]
    [Description(@"Provides transaction type and identification information.")]
    [DataMember(Name="TxIdDtls")]
    [XmlElement(ElementName="TxIdDtls")]
    [Required]
    public required SettlementTypeAndIdentification24 TransactionIdentificationDetails { get; init; }
    
    /// <summary>
    /// Link to another transaction - provided for information only.
    /// </summary>
    [IsoId("__NTvZ5wyEeazcsnODTksnQ")]
    [Description(@"Link to another transaction - provided for information only.")]
    [DataMember(Name="Lnkgs")]
    [XmlElement(ElementName="Lnkgs")]
    public Linkages50? Linkages { get; init; }
    
    /// <summary>
    /// Additional parameters to the transaction.
    /// </summary>
    [IsoId("__NTvaZwyEeazcsnODTksnQ")]
    [Description(@"Additional parameters to the transaction.")]
    [DataMember(Name="AddtlParams")]
    [XmlElement(ElementName="AddtlParams")]
    public AdditionalParameters31? AdditionalParameters { get; init; }
    
    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("__NTva5wyEeazcsnODTksnQ")]
    [Description(@"Details of the trade.")]
    [DataMember(Name="TradDtls")]
    [XmlElement(ElementName="TradDtls")]
    [Required]
    public required SecuritiesTradeDetails62 TradeDetails { get; init; }
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("__NTvbZwyEeazcsnODTksnQ")]
    [Description(@"Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("__NTvb5wyEeazcsnODTksnQ")]
    [Description(@"Elements characterising a financial instrument.")]
    [DataMember(Name="FinInstrmAttrbts")]
    [XmlElement(ElementName="FinInstrmAttrbts")]
    public FinancialInstrumentAttributes78? FinancialInstrumentAttributes { get; init; }
    
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("__NTvcZwyEeazcsnODTksnQ")]
    [Description(@"Details related to the account and quantity involved in the transaction.")]
    [DataMember(Name="QtyAndAcctDtls")]
    [XmlElement(ElementName="QtyAndAcctDtls")]
    [Required]
    public required QuantityAndAccount57 QuantityAndAccountDetails { get; init; }
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("__NTvc5wyEeazcsnODTksnQ")]
    [Description(@"Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.")]
    [DataMember(Name="SttlmParams")]
    [XmlElement(ElementName="SttlmParams")]
    [Required]
    public required SettlementDetails134 SettlementParameters { get; init; }
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("__NTvdZwyEeazcsnODTksnQ")]
    [Description(@"Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.")]
    [DataMember(Name="StgSttlmInstrDtls")]
    [XmlElement(ElementName="StgSttlmInstrDtls")]
    public StandingSettlementInstruction12? StandingSettlementInstructionDetails { get; init; }
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("__NTvd5wyEeazcsnODTksnQ")]
    [Description(@"Identifies the chain of delivering settlement parties.")]
    [DataMember(Name="DlvrgSttlmPties")]
    [XmlElement(ElementName="DlvrgSttlmPties")]
    public SettlementParties44? DeliveringSettlementParties { get; init; }
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("__NTveZwyEeazcsnODTksnQ")]
    [Description(@"Identifies the chain of receiving settlement parties.")]
    [DataMember(Name="RcvgSttlmPties")]
    [XmlElement(ElementName="RcvgSttlmPties")]
    public SettlementParties44? ReceivingSettlementParties { get; init; }
    
    /// <summary>
    /// Cash parties involved in the transaction if different for the securities settlement parties.
    /// </summary>
    [IsoId("__NTve5wyEeazcsnODTksnQ")]
    [Description(@"Cash parties involved in the transaction if different for the securities settlement parties.")]
    [DataMember(Name="CshPties")]
    [XmlElement(ElementName="CshPties")]
    public CashParties30? CashParties { get; init; }
    
    /// <summary>
    /// Amount effectively settled and which will be credited to/debited from the account owner's cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [IsoId("__NTvfZwyEeazcsnODTksnQ")]
    [Description(@"Amount effectively settled and which will be credited to/debited from the account owner's cash account. It may differ from the instructed settlement amount based on market tolerance level.")]
    [DataMember(Name="SttldAmt")]
    [XmlElement(ElementName="SttldAmt")]
    public AmountAndDirection60? SettledAmount { get; init; }
    
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("__NTvf5wyEeazcsnODTksnQ")]
    [Description(@"Other amounts than the settlement amount.")]
    [DataMember(Name="OthrAmts")]
    [XmlElement(ElementName="OthrAmts")]
    public OtherAmounts38? OtherAmounts { get; init; }
    
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("__NTvgZwyEeazcsnODTksnQ")]
    [Description(@"Other business parties relevant to the transaction.")]
    [DataMember(Name="OthrBizPties")]
    [XmlElement(ElementName="OthrBizPties")]
    public OtherParties29? OtherBusinessParties { get; init; }
    
    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    [IsoId("__NTvg5wyEeazcsnODTksnQ")]
    [Description(@"Provides information required for the registration or physical settlement.")]
    [DataMember(Name="AddtlPhysOrRegnDtls")]
    [XmlElement(ElementName="AddtlPhysOrRegnDtls")]
    public RegistrationParameters5? AdditionalPhysicalOrRegistrationDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("__NTvhZwyEeazcsnODTksnQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionConfirmation002V07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionConfirmation002V07Document ToDocument()
    {
        return new SecuritiesSettlementTransactionConfirmation002V07Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SctiesSttlmTxConf");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "TxIdDtls", xmlNamespace );
        TransactionIdentificationDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Linkages is Linkages50 LinkagesValue)
        {
            writer.WriteStartElement(null, "Lnkgs", xmlNamespace );
            LinkagesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalParameters is AdditionalParameters31 AdditionalParametersValue)
        {
            writer.WriteStartElement(null, "AddtlParams", xmlNamespace );
            AdditionalParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TradDtls", xmlNamespace );
        TradeDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (FinancialInstrumentAttributes is FinancialInstrumentAttributes78 FinancialInstrumentAttributesValue)
        {
            writer.WriteStartElement(null, "FinInstrmAttrbts", xmlNamespace );
            FinancialInstrumentAttributesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "QtyAndAcctDtls", xmlNamespace );
        QuantityAndAccountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SttlmParams", xmlNamespace );
        SettlementParameters.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (StandingSettlementInstructionDetails is StandingSettlementInstruction12 StandingSettlementInstructionDetailsValue)
        {
            writer.WriteStartElement(null, "StgSttlmInstrDtls", xmlNamespace );
            StandingSettlementInstructionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveringSettlementParties is SettlementParties44 DeliveringSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "DlvrgSttlmPties", xmlNamespace );
            DeliveringSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceivingSettlementParties is SettlementParties44 ReceivingSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "RcvgSttlmPties", xmlNamespace );
            ReceivingSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashParties is CashParties30 CashPartiesValue)
        {
            writer.WriteStartElement(null, "CshPties", xmlNamespace );
            CashPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettledAmount is AmountAndDirection60 SettledAmountValue)
        {
            writer.WriteStartElement(null, "SttldAmt", xmlNamespace );
            SettledAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherAmounts is OtherAmounts38 OtherAmountsValue)
        {
            writer.WriteStartElement(null, "OthrAmts", xmlNamespace );
            OtherAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherBusinessParties is OtherParties29 OtherBusinessPartiesValue)
        {
            writer.WriteStartElement(null, "OthrBizPties", xmlNamespace );
            OtherBusinessPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalPhysicalOrRegistrationDetails is RegistrationParameters5 AdditionalPhysicalOrRegistrationDetailsValue)
        {
            writer.WriteStartElement(null, "AddtlPhysOrRegnDtls", xmlNamespace );
            AdditionalPhysicalOrRegistrationDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesSettlementTransactionConfirmation002V07 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementTransactionConfirmation002V07"/>.
/// </summary>
[Serializable]
public partial record SecuritiesSettlementTransactionConfirmation002V07Document : IOuterDocument<SecuritiesSettlementTransactionConfirmation002V07>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.025.002.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionConfirmation002V07"/> is required.
    /// </summary>
    [DataMember(Name=SecuritiesSettlementTransactionConfirmation002V07.XmlTag)]
    public required SecuritiesSettlementTransactionConfirmation002V07 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SecuritiesSettlementTransactionConfirmation002V07.XmlTag);
        Message.Serialize(writer, DocumentNamespace);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
    }
    
    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
    
    public System.Xml.Schema.XmlSchema GetSchema() => null;
}
