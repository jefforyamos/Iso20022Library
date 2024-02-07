﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIMessageStatusResponseV01.  ISO2002 ID# __8IhgYYCEemxIqbaFEE8-w.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.casp.SaleToPOIMessageStatusResponseV01>;

namespace BeneficialStrategies.Iso20022.casp;


/// <summary>
/// This record is an implementation of the casp.015.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This message is a system message sent by the POI system to respond to the Sale system at a previous message status request.
/// </summary>
[Serializable]
[Description(@"This message is a system message sent by the POI system to respond to the Sale system at a previous message status request.")]
public partial record SaleToPOIMessageStatusResponseV01 : IOuterRecord<SaleToPOIMessageStatusResponseV01,SaleToPOIMessageStatusResponseV01Document>
    ,IIsoXmlSerilizable<SaleToPOIMessageStatusResponseV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "casp.015.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIMsgStsRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SaleToPOIMessageStatusResponseV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("__8Ihg4YCEemxIqbaFEE8-w")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header37 Header { get; init; }
    
    /// <summary>
    /// Information related to the response of a status request.
    /// </summary>
    [IsoId("__8IhhYYCEemxIqbaFEE8-w")]
    [Description(@"Information related to the response of a status request.")]
    [DataMember(Name="StsRspn")]
    [XmlElement(ElementName="StsRspn")]
    [Required]
    public required MessageStatusResponse2 StatusResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("__8Ihh4YCEemxIqbaFEE8-w")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType18? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIMessageStatusResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIMessageStatusResponseV01Document ToDocument()
    {
        return new SaleToPOIMessageStatusResponseV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SaleToPOIMsgStsRspn");
    
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
        writer.WriteStartElement(null, "StsRspn", xmlNamespace );
        StatusResponse.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecurityTrailer is ContentInformationType18 SecurityTrailerValue)
        {
            writer.WriteStartElement(null, "SctyTrlr", xmlNamespace );
            SecurityTrailerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SaleToPOIMessageStatusResponseV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOIMessageStatusResponseV01"/>.
/// </summary>
[Serializable]
public partial record SaleToPOIMessageStatusResponseV01Document : IOuterDocument<SaleToPOIMessageStatusResponseV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.015.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIMessageStatusResponseV01"/> is required.
    /// </summary>
    [DataMember(Name=SaleToPOIMessageStatusResponseV01.XmlTag)]
    public required SaleToPOIMessageStatusResponseV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SaleToPOIMessageStatusResponseV01.XmlTag);
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
