﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionAllegementNotification002V05.  ISO2002 ID# _6IYWA5NLEeWGlc8L7oPDIg.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.sese.SecuritiesSettlementTransactionAllegementNotification002V05>;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.028.002.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesSettlementTransactionAllegementNotification to an account owner to advise the account owner that a counterparty has alleged an instruction against the account owner's account at the account servicer and that the account servicer could not find the corresponding instruction of the account owner.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[Description(@"Scope|An account servicer sends a SecuritiesSettlementTransactionAllegementNotification to an account owner to advise the account owner that a counterparty has alleged an instruction against the account owner's account at the account servicer and that the account servicer could not find the corresponding instruction of the account owner.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesSettlementTransactionAllegementNotification002V05 : IOuterRecord<SecuritiesSettlementTransactionAllegementNotification002V05,SecuritiesSettlementTransactionAllegementNotification002V05Document>
    ,IIsoXmlSerilizable<SecuritiesSettlementTransactionAllegementNotification002V05>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.028.002.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxAllgmtNtfctn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesSettlementTransactionAllegementNotification002V05Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_6IYWEZNLEeWGlc8L7oPDIg")]
    [Description(@"Unambiguous identification of the transaction as know by the instructing party.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required IsoRestrictedFINXMax16Text TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides settlement type and identification information.
    /// </summary>
    [IsoId("_6IYWE5NLEeWGlc8L7oPDIg")]
    [Description(@"Provides settlement type and identification information.")]
    [DataMember(Name="SttlmTpAndAddtlParams")]
    [XmlElement(ElementName="SttlmTpAndAddtlParams")]
    [Required]
    public required SettlementTypeAndAdditionalParameters15 SettlementTypeAndAdditionalParameters { get; init; }
    
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_6IYWFZNLEeWGlc8L7oPDIg")]
    [Description(@"Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.")]
    [DataMember(Name="MktInfrstrctrTxId")]
    [XmlElement(ElementName="MktInfrstrctrTxId")]
    public Identification16? MarketInfrastructureTransactionIdentification { get; init; }
    
    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_6IYWF5NLEeWGlc8L7oPDIg")]
    [Description(@"Details of the trade.")]
    [DataMember(Name="TradDtls")]
    [XmlElement(ElementName="TradDtls")]
    [Required]
    public required SecuritiesTradeDetails60 TradeDetails { get; init; }
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_6IYWGZNLEeWGlc8L7oPDIg")]
    [Description(@"Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_6IYWG5NLEeWGlc8L7oPDIg")]
    [Description(@"Elements characterising a financial instrument.")]
    [DataMember(Name="FinInstrmAttrbts")]
    [XmlElement(ElementName="FinInstrmAttrbts")]
    public FinancialInstrumentAttributes78? FinancialInstrumentAttributes { get; init; }
    
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_6IYWHZNLEeWGlc8L7oPDIg")]
    [Description(@"Details related to the account and quantity involved in the transaction.")]
    [DataMember(Name="QtyAndAcctDtls")]
    [XmlElement(ElementName="QtyAndAcctDtls")]
    [Required]
    public required QuantityAndAccount49 QuantityAndAccountDetails { get; init; }
    
    /// <summary>
    /// Details of the closing of the securities financing transaction.
    /// </summary>
    [IsoId("_6IYWH5NLEeWGlc8L7oPDIg")]
    [Description(@"Details of the closing of the securities financing transaction.")]
    [DataMember(Name="SctiesFincgDtls")]
    [XmlElement(ElementName="SctiesFincgDtls")]
    public SecuritiesFinancingTransactionDetails34? SecuritiesFinancingDetails { get; init; }
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_6IYWIZNLEeWGlc8L7oPDIg")]
    [Description(@"Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.")]
    [DataMember(Name="SttlmParams")]
    [XmlElement(ElementName="SttlmParams")]
    [Required]
    public required SettlementDetails108 SettlementParameters { get; init; }
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_6IYWI5NLEeWGlc8L7oPDIg")]
    [Description(@"Identifies the chain of delivering settlement parties.")]
    [DataMember(Name="DlvrgSttlmPties")]
    [XmlElement(ElementName="DlvrgSttlmPties")]
    public SettlementParties44? DeliveringSettlementParties { get; init; }
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_6IYWJZNLEeWGlc8L7oPDIg")]
    [Description(@"Identifies the chain of receiving settlement parties.")]
    [DataMember(Name="RcvgSttlmPties")]
    [XmlElement(ElementName="RcvgSttlmPties")]
    public SettlementParties44? ReceivingSettlementParties { get; init; }
    
    /// <summary>
    /// Specifies cash parties in the framework of a corporate action event.
    /// </summary>
    [IsoId("_6IYWJ5NLEeWGlc8L7oPDIg")]
    [Description(@"Specifies cash parties in the framework of a corporate action event.")]
    [DataMember(Name="CshPties")]
    [XmlElement(ElementName="CshPties")]
    public CashParties32? CashParties { get; init; }
    
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_6IYWKZNLEeWGlc8L7oPDIg")]
    [Description(@"Total amount of money to be paid or received in exchange for the securities.")]
    [DataMember(Name="SttlmAmt")]
    [XmlElement(ElementName="SttlmAmt")]
    public AmountAndDirection71? SettlementAmount { get; init; }
    
    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_6IYWK5NLEeWGlc8L7oPDIg")]
    [Description(@"Other amounts than the settlement amount.")]
    [DataMember(Name="OthrAmts")]
    [XmlElement(ElementName="OthrAmts")]
    public OtherAmounts36? OtherAmounts { get; init; }
    
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_6IYWLZNLEeWGlc8L7oPDIg")]
    [Description(@"Other business parties relevant to the transaction.")]
    [DataMember(Name="OthrBizPties")]
    [XmlElement(ElementName="OthrBizPties")]
    public OtherParties31? OtherBusinessParties { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_6IYWL5NLEeWGlc8L7oPDIg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionAllegementNotification002V05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionAllegementNotification002V05Document ToDocument()
    {
        return new SecuritiesSettlementTransactionAllegementNotification002V05Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SctiesSttlmTxAllgmtNtfctn");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(TransactionIdentification)); // data type RestrictedFINXMax16Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SttlmTpAndAddtlParams", xmlNamespace );
        SettlementTypeAndAdditionalParameters.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MarketInfrastructureTransactionIdentification is Identification16 MarketInfrastructureTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "MktInfrstrctrTxId", xmlNamespace );
            MarketInfrastructureTransactionIdentificationValue.Serialize(writer, xmlNamespace);
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
        if (SecuritiesFinancingDetails is SecuritiesFinancingTransactionDetails34 SecuritiesFinancingDetailsValue)
        {
            writer.WriteStartElement(null, "SctiesFincgDtls", xmlNamespace );
            SecuritiesFinancingDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SttlmParams", xmlNamespace );
        SettlementParameters.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
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
        if (CashParties is CashParties32 CashPartiesValue)
        {
            writer.WriteStartElement(null, "CshPties", xmlNamespace );
            CashPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementAmount is AmountAndDirection71 SettlementAmountValue)
        {
            writer.WriteStartElement(null, "SttlmAmt", xmlNamespace );
            SettlementAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherAmounts is OtherAmounts36 OtherAmountsValue)
        {
            writer.WriteStartElement(null, "OthrAmts", xmlNamespace );
            OtherAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherBusinessParties is OtherParties31 OtherBusinessPartiesValue)
        {
            writer.WriteStartElement(null, "OthrBizPties", xmlNamespace );
            OtherBusinessPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesSettlementTransactionAllegementNotification002V05 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementTransactionAllegementNotification002V05"/>.
/// </summary>
[Serializable]
public partial record SecuritiesSettlementTransactionAllegementNotification002V05Document : IOuterDocument<SecuritiesSettlementTransactionAllegementNotification002V05>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.028.002.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionAllegementNotification002V05"/> is required.
    /// </summary>
    [DataMember(Name=SecuritiesSettlementTransactionAllegementNotification002V05.XmlTag)]
    public required SecuritiesSettlementTransactionAllegementNotification002V05 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SecuritiesSettlementTransactionAllegementNotification002V05.XmlTag);
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
