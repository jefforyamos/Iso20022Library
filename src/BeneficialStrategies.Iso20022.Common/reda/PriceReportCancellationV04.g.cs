﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PriceReportCancellationV04.  ISO2002 ID# _M87dQRj3EeKxeog5DTmtgg.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.reda.PriceReportCancellationV04>;

namespace BeneficialStrategies.Iso20022.reda;


/// <summary>
/// This record is an implementation of the reda.002.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// SCOPE
/// A report provider, for example, a transfer agent, fund accountant or market data provider, sends the PriceReportCancellation message to the report recipient, for example, a fund management company, transfer agent, market data provider, regulator or any other interested party to cancel previously sent prices.|
/// USAGE
/// The PriceReportCancellation message is used to either: |- cancel an entire PriceReport that was previously sent (by quoting the business reference of the original price report in the PriceReportIdentification element), or,|- cancel one or more individual prices from a previously sent price report (by using the PriceDetailsToBeCancelled sequence).|Technically, it is possible to cancel all the prices individually by using the PriceDetailsToBeCancelled sequence, but this is not recommended.|The cancellation should not contain the cancellation of prices for more than one NAV date. 
/// 
/// 
/// </summary>
[Serializable]
[Description(@"SCOPE|A report provider, for example, a transfer agent, fund accountant or market data provider, sends the PriceReportCancellation message to the report recipient, for example, a fund management company, transfer agent, market data provider, regulator or any other interested party to cancel previously sent prices.||USAGE|The PriceReportCancellation message is used to either: |- cancel an entire PriceReport that was previously sent (by quoting the business reference of the original price report in the PriceReportIdentification element), or,|- cancel one or more individual prices from a previously sent price report (by using the PriceDetailsToBeCancelled sequence).|Technically, it is possible to cancel all the prices individually by using the PriceDetailsToBeCancelled sequence, but this is not recommended.|The cancellation should not contain the cancellation of prices for more than one NAV date. ||")]
public partial record PriceReportCancellationV04 : IOuterRecord<PriceReportCancellationV04,PriceReportCancellationV04Document>
    ,IIsoXmlSerilizable<PriceReportCancellationV04>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.002.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PricRptCxl";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => PriceReportCancellationV04Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_M87dQxj3EeKxeog5DTmtgg")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_M87dRxj3EeKxeog5DTmtgg")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_M87dSxj3EeKxeog5DTmtgg")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_M87dTxj3EeKxeog5DTmtgg")]
    [Description(@"Pagination of the message.")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    [Required]
    public required Pagination MessagePagination { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier for the price report, as assigned by the reporting party.
    /// </summary>
    [IsoId("_NPnKdRmAEeKxsrht2duUcg")]
    [Description(@"Unique and unambiguous identifier for the price report, as assigned by the reporting party.")]
    [DataMember(Name="PricRptId")]
    [XmlElement(ElementName="PricRptId")]
    [Required]
    public required IsoMax35Text PriceReportIdentification { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier for the cancellation of the previous price report, as assigned by the reporting party.
    /// </summary>
    [IsoId("_epzJZRmAEeKxsrht2duUcg")]
    [Description(@"Unique and unambiguous identifier for the cancellation of the previous price report, as assigned by the reporting party.")]
    [DataMember(Name="CxlId")]
    [XmlElement(ElementName="CxlId")]
    [Required]
    public required IsoMax35Text CancellationIdentification { get; init; }
    
    /// <summary>
    /// Reason for the cancellation.
    /// </summary>
    [IsoId("_06rKcBmAEeKxsrht2duUcg")]
    [Description(@"Reason for the cancellation.")]
    [DataMember(Name="CxlRsn")]
    [XmlElement(ElementName="CxlRsn")]
    public IsoMax350Text? CancellationReason { get; init; }
    
    /// <summary>
    /// Date or date and time the price will be corrected.
    /// </summary>
    [IsoId("_RTTz8BmBEeKxsrht2duUcg")]
    [Description(@"Date or date and time the price will be corrected.")]
    [DataMember(Name="XpctdPricCrrctnDt")]
    [XmlElement(ElementName="XpctdPricCrrctnDt")]
    public DateAndDateTime1Choice_? ExpectedPriceCorrectionDate { get; init; }
    
    /// <summary>
    /// Indicates whether or not all the prices of the referenced price report are cancelled.
    /// </summary>
    [IsoId("_Cj3HgBmCEeKxsrht2duUcg")]
    [Description(@"Indicates whether or not all the prices of the referenced price report are cancelled.")]
    [DataMember(Name="CmpltPricCxl")]
    [XmlElement(ElementName="CmpltPricCxl")]
    [Required]
    public required IsoYesNoIndicator CompletePriceCancellation { get; init; }
    
    /// <summary>
    /// Details of prices to be cancelled.
    /// </summary>
    [IsoId("_M87dUxj3EeKxeog5DTmtgg")]
    [Description(@"Details of prices to be cancelled.")]
    [DataMember(Name="CancPricValtnDtls")]
    [XmlElement(ElementName="CancPricValtnDtls")]
    public PriceReport3? CancelledPriceValuationDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2sI2JRmCEeKxsrht2duUcg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PriceReportCancellationV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PriceReportCancellationV04Document ToDocument()
    {
        return new PriceReportCancellationV04Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("PricRptCxl");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MsgId", xmlNamespace );
        MessageIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PoolReference is AdditionalReference3 PoolReferenceValue)
        {
            writer.WriteStartElement(null, "PoolRef", xmlNamespace );
            PoolReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousReference is AdditionalReference3 PreviousReferenceValue)
        {
            writer.WriteStartElement(null, "PrvsRef", xmlNamespace );
            PreviousReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "MsgPgntn", xmlNamespace );
        MessagePagination.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PricRptId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(PriceReportIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CxlId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(CancellationIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (CancellationReason is IsoMax350Text CancellationReasonValue)
        {
            writer.WriteStartElement(null, "CxlRsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(CancellationReasonValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (ExpectedPriceCorrectionDate is DateAndDateTime1Choice_ ExpectedPriceCorrectionDateValue)
        {
            writer.WriteStartElement(null, "XpctdPricCrrctnDt", xmlNamespace );
            ExpectedPriceCorrectionDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CmpltPricCxl", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CompletePriceCancellation)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (CancelledPriceValuationDetails is PriceReport3 CancelledPriceValuationDetailsValue)
        {
            writer.WriteStartElement(null, "CancPricValtnDtls", xmlNamespace );
            CancelledPriceValuationDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Extension is Extension1 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PriceReportCancellationV04 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PriceReportCancellationV04"/>.
/// </summary>
[Serializable]
public partial record PriceReportCancellationV04Document : IOuterDocument<PriceReportCancellationV04>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PriceReportCancellationV04"/> is required.
    /// </summary>
    [DataMember(Name=PriceReportCancellationV04.XmlTag)]
    public required PriceReportCancellationV04 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(PriceReportCancellationV04.XmlTag);
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
