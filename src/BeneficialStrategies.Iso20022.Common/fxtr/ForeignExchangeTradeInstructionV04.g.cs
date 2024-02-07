﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ForeignExchangeTradeInstructionV04.  ISO2002 ID# _lxHWUZRyEeak6e8_Fc5fQg.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.fxtr.ForeignExchangeTradeInstructionV04>;

namespace BeneficialStrategies.Iso20022.fxtr;


/// <summary>
/// This record is an implementation of the fxtr.014.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|
/// The ForeignExchangeTradeInstruction message is sent by a participant to a central settlement system to notify the creation of the foreign exchange trade agreed by both trading parties.|
/// Usage|
/// The ForeignExchangeTradeInstruction message is sent from a participant to a central settlement system to advise of the creation of a foreign exchange trade.
/// </summary>
[Serializable]
[Description(@"Scope||The ForeignExchangeTradeInstruction message is sent by a participant to a central settlement system to notify the creation of the foreign exchange trade agreed by both trading parties.||Usage||The ForeignExchangeTradeInstruction message is sent from a participant to a central settlement system to advise of the creation of a foreign exchange trade.")]
public partial record ForeignExchangeTradeInstructionV04 : IOuterRecord<ForeignExchangeTradeInstructionV04,ForeignExchangeTradeInstructionV04Document>
    ,IIsoXmlSerilizable<ForeignExchangeTradeInstructionV04>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.014.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradInstr";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ForeignExchangeTradeInstructionV04Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// General information related to the trade.
    /// </summary>
    [IsoId("_lxHWU5RyEeak6e8_Fc5fQg")]
    [Description(@"General information related to the trade.")]
    [DataMember(Name="TradInf")]
    [XmlElement(ElementName="TradInf")]
    [Required]
    public required TradeAgreement14 TradeInformation { get; init; }
    
    /// <summary>
    /// Party(ies) on the trading side of the trade.
    /// </summary>
    [IsoId("_lxHWVZRyEeak6e8_Fc5fQg")]
    [Description(@"Party(ies) on the trading side of the trade.")]
    [DataMember(Name="TradgSdId")]
    [XmlElement(ElementName="TradgSdId")]
    [Required]
    public required TradePartyIdentification6 TradingSideIdentification { get; init; }
    
    /// <summary>
    /// Party(ies) on the counterparty side of the trade.
    /// </summary>
    [IsoId("_lxHWV5RyEeak6e8_Fc5fQg")]
    [Description(@"Party(ies) on the counterparty side of the trade.")]
    [DataMember(Name="CtrPtySdId")]
    [XmlElement(ElementName="CtrPtySdId")]
    [Required]
    public required TradePartyIdentification6 CounterpartySideIdentification { get; init; }
    
    /// <summary>
    /// Amounts of the trade.
    /// </summary>
    [IsoId("_lxHWWZRyEeak6e8_Fc5fQg")]
    [Description(@"Amounts of the trade.")]
    [DataMember(Name="TradAmts")]
    [XmlElement(ElementName="TradAmts")]
    [Required]
    public required AmountsAndValueDate1 TradeAmounts { get; init; }
    
    /// <summary>
    /// Exchange rate as agreed by the traders.
    /// </summary>
    [IsoId("_lxHWW5RyEeak6e8_Fc5fQg")]
    [Description(@"Exchange rate as agreed by the traders.")]
    [DataMember(Name="AgrdRate")]
    [XmlElement(ElementName="AgrdRate")]
    [Required]
    public required AgreedRate3 AgreedRate { get; init; }
    
    /// <summary>
    /// Specifies the conditions for a non deliverable opening or fixing confirmation.
    /// </summary>
    [IsoId("_H6EN0JUREea7vKctaoIyEQ")]
    [Description(@"Specifies the conditions for a non deliverable opening or fixing confirmation.")]
    [DataMember(Name="NDFConds")]
    [XmlElement(ElementName="NDFConds")]
    public NonDeliverableForwardConditions1? NonDeliverableForwardConditions { get; init; }
    
    /// <summary>
    /// Settlement instructions for the amounts received by the trading side.
    /// </summary>
    [IsoId("_lxHWXZRyEeak6e8_Fc5fQg")]
    [Description(@"Settlement instructions for the amounts received by the trading side.")]
    [DataMember(Name="TradgSdSttlmInstrs")]
    [XmlElement(ElementName="TradgSdSttlmInstrs")]
    public SettlementParties29? TradingSideSettlementInstructions { get; init; }
    
    /// <summary>
    /// Settlement instructions for the amounts received by the counterparty.
    /// </summary>
    [IsoId("_lxHWX5RyEeak6e8_Fc5fQg")]
    [Description(@"Settlement instructions for the amounts received by the counterparty.")]
    [DataMember(Name="CtrPtySdSttlmInstrs")]
    [XmlElement(ElementName="CtrPtySdSttlmInstrs")]
    public SettlementParties29? CounterpartySideSettlementInstructions { get; init; }
    
    /// <summary>
    /// Specifies whether the trade is a block or an individual trade. It also contains supplementary information such as free format information, broker's identification, dealing branches and references.
    /// </summary>
    [IsoId("_lxHWYZRyEeak6e8_Fc5fQg")]
    [Description(@"Specifies whether the trade is a block or an individual trade. It also contains supplementary information such as free format information, broker's identification, dealing branches and references.")]
    [DataMember(Name="OptnlGnlInf")]
    [XmlElement(ElementName="OptnlGnlInf")]
    public GeneralInformation5? OptionalGeneralInformation { get; init; }
    
    /// <summary>
    /// Information that is to be provided to trade repositories in the context of the regulatory standards around over-the-counter (OTC) derivatives, central counterparties and trade repositories.
    /// </summary>
    [IsoId("_lxHWY5RyEeak6e8_Fc5fQg")]
    [Description(@"Information that is to be provided to trade repositories in the context of the regulatory standards around over-the-counter (OTC) derivatives, central counterparties and trade repositories.")]
    [DataMember(Name="RgltryRptg")]
    [XmlElement(ElementName="RgltryRptg")]
    public RegulatoryReporting6? RegulatoryReporting { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_lxQgQZRyEeak6e8_Fc5fQg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ForeignExchangeTradeInstructionV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ForeignExchangeTradeInstructionV04Document ToDocument()
    {
        return new ForeignExchangeTradeInstructionV04Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("FXTradInstr");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "TradInf", xmlNamespace );
        TradeInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TradgSdId", xmlNamespace );
        TradingSideIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CtrPtySdId", xmlNamespace );
        CounterpartySideIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TradAmts", xmlNamespace );
        TradeAmounts.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AgrdRate", xmlNamespace );
        AgreedRate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (NonDeliverableForwardConditions is NonDeliverableForwardConditions1 NonDeliverableForwardConditionsValue)
        {
            writer.WriteStartElement(null, "NDFConds", xmlNamespace );
            NonDeliverableForwardConditionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradingSideSettlementInstructions is SettlementParties29 TradingSideSettlementInstructionsValue)
        {
            writer.WriteStartElement(null, "TradgSdSttlmInstrs", xmlNamespace );
            TradingSideSettlementInstructionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CounterpartySideSettlementInstructions is SettlementParties29 CounterpartySideSettlementInstructionsValue)
        {
            writer.WriteStartElement(null, "CtrPtySdSttlmInstrs", xmlNamespace );
            CounterpartySideSettlementInstructionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionalGeneralInformation is GeneralInformation5 OptionalGeneralInformationValue)
        {
            writer.WriteStartElement(null, "OptnlGnlInf", xmlNamespace );
            OptionalGeneralInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RegulatoryReporting is RegulatoryReporting6 RegulatoryReportingValue)
        {
            writer.WriteStartElement(null, "RgltryRptg", xmlNamespace );
            RegulatoryReportingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ForeignExchangeTradeInstructionV04 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ForeignExchangeTradeInstructionV04"/>.
/// </summary>
[Serializable]
public partial record ForeignExchangeTradeInstructionV04Document : IOuterDocument<ForeignExchangeTradeInstructionV04>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.014.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ForeignExchangeTradeInstructionV04"/> is required.
    /// </summary>
    [DataMember(Name=ForeignExchangeTradeInstructionV04.XmlTag)]
    public required ForeignExchangeTradeInstructionV04 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(ForeignExchangeTradeInstructionV04.XmlTag);
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
