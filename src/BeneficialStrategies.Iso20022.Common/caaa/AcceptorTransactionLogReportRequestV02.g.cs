﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorTransactionLogReportRequestV02.  ISO2002 ID# _L8IqIU6vEeyGi9JAv6wq7Q.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.caaa.AcceptorTransactionLogReportRequestV02>;

namespace BeneficialStrategies.Iso20022.caaa;


/// <summary>
/// This record is an implementation of the caaa.024.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorTransactionLogReportRequest message is sent by an Acceptor to an Acquirer or its IntermediaryAgent to request a report service.
/// </summary>
[Serializable]
[Description(@"The AcceptorTransactionLogReportRequest message is sent by an Acceptor to an Acquirer or its IntermediaryAgent to request a report service.")]
public partial record AcceptorTransactionLogReportRequestV02 : IOuterRecord<AcceptorTransactionLogReportRequestV02,AcceptorTransactionLogReportRequestV02Document>
    ,IIsoXmlSerilizable<AcceptorTransactionLogReportRequestV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.024.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrTxLgRptReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AcceptorTransactionLogReportRequestV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_L8IqI06vEeyGi9JAv6wq7Q")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header59 Header { get; init; }
    
    /// <summary>
    /// Information related to the report request.
    /// </summary>
    [IsoId("_L8IqJU6vEeyGi9JAv6wq7Q")]
    [Description(@"Information related to the report request.")]
    [DataMember(Name="RptReq")]
    [XmlElement(ElementName="RptReq")]
    [Required]
    public required ReportRequest5 ReportRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_L8IqJ06vEeyGi9JAv6wq7Q")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType31? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorTransactionLogReportRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorTransactionLogReportRequestV02Document ToDocument()
    {
        return new AcceptorTransactionLogReportRequestV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AccptrTxLgRptReq");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Hdr", xmlNamespace );
        Header.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RptReq", xmlNamespace );
        ReportRequest.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecurityTrailer is ContentInformationType31 SecurityTrailerValue)
        {
            writer.WriteStartElement(null, "SctyTrlr", xmlNamespace );
            SecurityTrailerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AcceptorTransactionLogReportRequestV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorTransactionLogReportRequestV02"/>.
/// </summary>
[Serializable]
public partial record AcceptorTransactionLogReportRequestV02Document : IOuterDocument<AcceptorTransactionLogReportRequestV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.024.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorTransactionLogReportRequestV02"/> is required.
    /// </summary>
    [DataMember(Name=AcceptorTransactionLogReportRequestV02.XmlTag)]
    public required AcceptorTransactionLogReportRequestV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AcceptorTransactionLogReportRequestV02.XmlTag);
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
