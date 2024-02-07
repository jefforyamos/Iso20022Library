﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PriceReportCancellationV02.  ISO2002 ID# _Zski2NEvEd-BzquC8wXy7w_-1589707882.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.reda.PriceReportCancellationV02>;

namespace BeneficialStrategies.Iso20022.reda;


/// <summary>
/// This record is an implementation of the reda.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The PriceReportCancellation message is sent by a report provider, eg, a fund accountant, transfer agent, market data provider, or any other interested party, to a report user, eg, a fund management company, a transfer agent, market data provider, regulator or any other interested party.
/// The message is used to cancel a previously sent PriceReport message.
/// Usage
/// The PriceReportCancellation message is used to cancel an entire PriceReport message that was previously sent by the report provider. If only a part of the information needs to be cancelled and replaced, the PriceReportCorrection message must be used.
/// This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended.
/// </summary>
[Serializable]
[Description(@"Scope|The PriceReportCancellation message is sent by a report provider, eg, a fund accountant, transfer agent, market data provider, or any other interested party, to a report user, eg, a fund management company, a transfer agent, market data provider, regulator or any other interested party.|The message is used to cancel a previously sent PriceReport message.|Usage|The PriceReportCancellation message is used to cancel an entire PriceReport message that was previously sent by the report provider. If only a part of the information needs to be cancelled and replaced, the PriceReportCorrection message must be used.|This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended.")]
public partial record PriceReportCancellationV02 : IOuterRecord<PriceReportCancellationV02,PriceReportCancellationV02Document>
    ,IIsoXmlSerilizable<PriceReportCancellationV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.002.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "reda.002.001.02";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => PriceReportCancellationV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Zski2dEvEd-BzquC8wXy7w_-1891280241")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Zski2tEvEd-BzquC8wXy7w_-1948539540")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    [Required]
    public required AdditionalReference3 PreviousReference { get; init; }
    
    /// <summary>
    /// Common information related to all the price reports to be cancelled.
    /// </summary>
    [IsoId("_Zski29EvEd-BzquC8wXy7w_-1321950502")]
    [Description(@"Common information related to all the price reports to be cancelled.")]
    [DataMember(Name="PricRptToBeCanc")]
    [XmlElement(ElementName="PricRptToBeCanc")]
    public PriceReport1? PriceReportToBeCancelled { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PriceReportCancellationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PriceReportCancellationV02Document ToDocument()
    {
        return new PriceReportCancellationV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("reda.002.001.02");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (PoolReference is AdditionalReference3 PoolReferenceValue)
        {
            writer.WriteStartElement(null, "PoolRef", xmlNamespace );
            PoolReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PrvsRef", xmlNamespace );
        PreviousReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PriceReportToBeCancelled is PriceReport1 PriceReportToBeCancelledValue)
        {
            writer.WriteStartElement(null, "PricRptToBeCanc", xmlNamespace );
            PriceReportToBeCancelledValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PriceReportCancellationV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PriceReportCancellationV02"/>.
/// </summary>
[Serializable]
public partial record PriceReportCancellationV02Document : IOuterDocument<PriceReportCancellationV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PriceReportCancellationV02"/> is required.
    /// </summary>
    [DataMember(Name=PriceReportCancellationV02.XmlTag)]
    public required PriceReportCancellationV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(PriceReportCancellationV02.XmlTag);
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
