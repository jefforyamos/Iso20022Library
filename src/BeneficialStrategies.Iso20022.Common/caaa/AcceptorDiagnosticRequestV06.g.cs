﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorDiagnosticRequestV06.  ISO2002 ID# _OjCqsbChEeapjPTKZHuM2w.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.caaa.AcceptorDiagnosticRequestV06>;

namespace BeneficialStrategies.Iso20022.caaa;


/// <summary>
/// This record is an implementation of the caaa.013.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorDiagnosticRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check the end-to-end communication, to test the availability of this acquirer, or to validate the security environment.
/// </summary>
[Serializable]
[Description(@"The AcceptorDiagnosticRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check the end-to-end communication, to test the availability of this acquirer, or to validate the security environment.")]
public partial record AcceptorDiagnosticRequestV06 : IOuterRecord<AcceptorDiagnosticRequestV06,AcceptorDiagnosticRequestV06Document>
    ,IIsoXmlSerilizable<AcceptorDiagnosticRequestV06>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.013.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrDgnstcReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AcceptorDiagnosticRequestV06Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Diagnostic request message management information.
    /// </summary>
    [IsoId("_OjCqtbChEeapjPTKZHuM2w")]
    [Description(@"Diagnostic request message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header30 Header { get; init; }
    
    /// <summary>
    /// Information related to the diagnostic request.
    /// </summary>
    [IsoId("_OjCqt7ChEeapjPTKZHuM2w")]
    [Description(@"Information related to the diagnostic request.")]
    [DataMember(Name="DgnstcReq")]
    [XmlElement(ElementName="DgnstcReq")]
    [Required]
    public required AcceptorDiagnosticRequest6 DiagnosticRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_OjCqubChEeapjPTKZHuM2w")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorDiagnosticRequestV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorDiagnosticRequestV06Document ToDocument()
    {
        return new AcceptorDiagnosticRequestV06Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AccptrDgnstcReq");
    
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
        writer.WriteStartElement(null, "DgnstcReq", xmlNamespace );
        DiagnosticRequest.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecurityTrailer is ContentInformationType15 SecurityTrailerValue)
        {
            writer.WriteStartElement(null, "SctyTrlr", xmlNamespace );
            SecurityTrailerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AcceptorDiagnosticRequestV06 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorDiagnosticRequestV06"/>.
/// </summary>
[Serializable]
public partial record AcceptorDiagnosticRequestV06Document : IOuterDocument<AcceptorDiagnosticRequestV06>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.013.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorDiagnosticRequestV06"/> is required.
    /// </summary>
    [DataMember(Name=AcceptorDiagnosticRequestV06.XmlTag)]
    public required AcceptorDiagnosticRequestV06 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AcceptorDiagnosticRequestV06.XmlTag);
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
