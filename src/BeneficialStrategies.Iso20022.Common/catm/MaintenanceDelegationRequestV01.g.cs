﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MaintenanceDelegationRequestV01.  ISO2002 ID# _RRRwEGp2EeSojYXQbRlLzA.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.catm.MaintenanceDelegationRequestV01>;

namespace BeneficialStrategies.Iso20022.catm;


/// <summary>
/// This record is an implementation of the catm.005.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// A terminal manager requests to the master terminal manager the delegation of maintenance functions or maintenance operation on the terminal estate managed by the master terminal manager.
/// </summary>
[Serializable]
[Description(@"A terminal manager requests to the master terminal manager the delegation of maintenance functions or maintenance operation on the terminal estate managed by the master terminal manager.")]
public partial record MaintenanceDelegationRequestV01 : IOuterRecord<MaintenanceDelegationRequestV01,MaintenanceDelegationRequestV01Document>
    ,IIsoXmlSerilizable<MaintenanceDelegationRequestV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.005.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MntncDlgtnReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MaintenanceDelegationRequestV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_825hIGp2EeSojYXQbRlLzA")]
    [Description(@"Information related to the protocol management.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header16 Header { get; init; }
    
    /// <summary>
    /// Information related to the request of maintenance delegations.
    /// </summary>
    [IsoId("_jVQoAGp4EeSojYXQbRlLzA")]
    [Description(@"Information related to the request of maintenance delegations.")]
    [DataMember(Name="MntncDlgtnReq")]
    [XmlElement(ElementName="MntncDlgtnReq")]
    [Required]
    public required MaintenanceDelegationRequest1 MaintenanceDelegationRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_xgIyUGp4EeSojYXQbRlLzA")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required ContentInformationType12 SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MaintenanceDelegationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MaintenanceDelegationRequestV01Document ToDocument()
    {
        return new MaintenanceDelegationRequestV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("MntncDlgtnReq");
    
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
        writer.WriteStartElement(null, "MntncDlgtnReq", xmlNamespace );
        MaintenanceDelegationRequest.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SctyTrlr", xmlNamespace );
        SecurityTrailer.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static MaintenanceDelegationRequestV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MaintenanceDelegationRequestV01"/>.
/// </summary>
[Serializable]
public partial record MaintenanceDelegationRequestV01Document : IOuterDocument<MaintenanceDelegationRequestV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.005.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MaintenanceDelegationRequestV01"/> is required.
    /// </summary>
    [DataMember(Name=MaintenanceDelegationRequestV01.XmlTag)]
    public required MaintenanceDelegationRequestV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(MaintenanceDelegationRequestV01.XmlTag);
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
