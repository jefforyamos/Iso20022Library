﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RetrievalFulfilmentResponseV01.  ISO2002 ID# _XckoseE1EeeV6-yubHrZaQ.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.cain.RetrievalFulfilmentResponseV01>;

namespace BeneficialStrategies.Iso20022.cain;


/// <summary>
/// This record is an implementation of the cain.015.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The RetrievalFulfilmentResponse message is sent by an issuer or acquirer to an agent (processor, agent) in response to a RetrievalFulfilmentInitiation message.
/// </summary>
[Serializable]
[Description(@"The RetrievalFulfilmentResponse message is sent by an issuer or acquirer to an agent (processor, agent) in response to a RetrievalFulfilmentInitiation message.")]
public partial record RetrievalFulfilmentResponseV01 : IOuterRecord<RetrievalFulfilmentResponseV01,RetrievalFulfilmentResponseV01Document>
    ,IIsoXmlSerilizable<RetrievalFulfilmentResponseV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.015.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrvlFlfmtRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => RetrievalFulfilmentResponseV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_Xckos-E1EeeV6-yubHrZaQ")]
    [Description(@"Information related to the protocol management.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header48 Header { get; init; }
    
    /// <summary>
    /// Information related to the response to the request of a retrieval fulfilment.
    /// </summary>
    [IsoId("_XckoteE1EeeV6-yubHrZaQ")]
    [Description(@"Information related to the response to the request of a retrieval fulfilment.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required RetrievalFullfilmentResponse1 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_Xckot-E1EeeV6-yubHrZaQ")]
    [Description(@"Trailer of the message containing a MAC.|It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RetrievalFulfilmentResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RetrievalFulfilmentResponseV01Document ToDocument()
    {
        return new RetrievalFulfilmentResponseV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("RtrvlFlfmtRspn");
    
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
        writer.WriteStartElement(null, "Body", xmlNamespace );
        Body.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecurityTrailer is ContentInformationType20 SecurityTrailerValue)
        {
            writer.WriteStartElement(null, "SctyTrlr", xmlNamespace );
            SecurityTrailerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RetrievalFulfilmentResponseV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RetrievalFulfilmentResponseV01"/>.
/// </summary>
[Serializable]
public partial record RetrievalFulfilmentResponseV01Document : IOuterDocument<RetrievalFulfilmentResponseV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.015.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RetrievalFulfilmentResponseV01"/> is required.
    /// </summary>
    [DataMember(Name=RetrievalFulfilmentResponseV01.XmlTag)]
    public required RetrievalFulfilmentResponseV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(RetrievalFulfilmentResponseV01.XmlTag);
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
