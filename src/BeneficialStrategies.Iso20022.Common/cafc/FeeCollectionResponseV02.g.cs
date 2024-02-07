﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FeeCollectionResponseV02.  ISO2002 ID# _6oy9QYaAEeuSbct6WWD-Ng.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.cafc.FeeCollectionResponseV02>;

namespace BeneficialStrategies.Iso20022.cafc;


/// <summary>
/// This record is an implementation of the cafc.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FeeCollectionResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a FeeCollectionInitiation message.
/// </summary>
[Serializable]
[Description(@"The FeeCollectionResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a FeeCollectionInitiation message.")]
public partial record FeeCollectionResponseV02 : IOuterRecord<FeeCollectionResponseV02,FeeCollectionResponseV02Document>
    ,IIsoXmlSerilizable<FeeCollectionResponseV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cafc.002.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FeeColltnRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => FeeCollectionResponseV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management.
    /// ISO 8583 MTI
    /// </summary>
    [IsoId("_6oy9Q4aAEeuSbct6WWD-Ng")]
    [Description(@"Information related to the protocol management.|ISO 8583 MTI")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header66 Header { get; init; }
    
    /// <summary>
    /// Information related to the response of a fee collection initiation message..
    /// </summary>
    [IsoId("_6oy9RYaAEeuSbct6WWD-Ng")]
    [Description(@"Information related to the response of a fee collection initiation message..")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required FeeCollectionResponse2 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_6oy9R4aAEeuSbct6WWD-Ng")]
    [Description(@"Trailer of the message containing a MAC.|It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FeeCollectionResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FeeCollectionResponseV02Document ToDocument()
    {
        return new FeeCollectionResponseV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("FeeColltnRspn");
    
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
    public static FeeCollectionResponseV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FeeCollectionResponseV02"/>.
/// </summary>
[Serializable]
public partial record FeeCollectionResponseV02Document : IOuterDocument<FeeCollectionResponseV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cafc.002.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FeeCollectionResponseV02"/> is required.
    /// </summary>
    [DataMember(Name=FeeCollectionResponseV02.XmlTag)]
    public required FeeCollectionResponseV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(FeeCollectionResponseV02.XmlTag);
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
