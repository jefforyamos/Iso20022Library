﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCancellationRequestV03.  ISO2002 ID# _O1urUTJREeO58eY-wGOnqw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.caaa.AcceptorCancellationRequestV03>;

namespace BeneficialStrategies.Iso20022.caaa;


/// <summary>
/// This record is an implementation of the caaa.005.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorCancellationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to request the cancellation of a successfully completed transaction. Cancellation should only occur before the transaction has been cleared.
/// 
/// 
/// </summary>
[Serializable]
[Description(@"The AcceptorCancellationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to request the cancellation of a successfully completed transaction. Cancellation should only occur before the transaction has been cleared.||")]
public partial record AcceptorCancellationRequestV03 : IOuterRecord<AcceptorCancellationRequestV03,AcceptorCancellationRequestV03Document>
    ,IIsoXmlSerilizable<AcceptorCancellationRequestV03>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.005.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCxlReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AcceptorCancellationRequestV03Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Cancellation request message management information.
    /// </summary>
    [IsoId("_O1urUzJREeO58eY-wGOnqw")]
    [Description(@"Cancellation request message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header7 Header { get; init; }
    
    /// <summary>
    /// Information related to the cancellation request.
    /// </summary>
    [IsoId("_O1urVTJREeO58eY-wGOnqw")]
    [Description(@"Information related to the cancellation request.")]
    [DataMember(Name="CxlReq")]
    [XmlElement(ElementName="CxlReq")]
    [Required]
    public required AcceptorCancellationRequest3 CancellationRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_O1urVzJREeO58eY-wGOnqw")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required ContentInformationType8 SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCancellationRequestV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCancellationRequestV03Document ToDocument()
    {
        return new AcceptorCancellationRequestV03Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AccptrCxlReq");
    
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
        writer.WriteStartElement(null, "CxlReq", xmlNamespace );
        CancellationRequest.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SctyTrlr", xmlNamespace );
        SecurityTrailer.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static AcceptorCancellationRequestV03 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorCancellationRequestV03"/>.
/// </summary>
[Serializable]
public partial record AcceptorCancellationRequestV03Document : IOuterDocument<AcceptorCancellationRequestV03>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.005.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCancellationRequestV03"/> is required.
    /// </summary>
    [DataMember(Name=AcceptorCancellationRequestV03.XmlTag)]
    public required AcceptorCancellationRequestV03 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AcceptorCancellationRequestV03.XmlTag);
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
