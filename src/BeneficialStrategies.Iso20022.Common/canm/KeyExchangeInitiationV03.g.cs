﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for KeyExchangeInitiationV03.  ISO2002 ID# _oOlvsYv6EeumSPwlS1PkxQ.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.canm.KeyExchangeInitiationV03>;

namespace BeneficialStrategies.Iso20022.canm;


/// <summary>
/// This record is an implementation of the canm.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The KeyExchangeInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). This message is used to initiate a cryptographic key activity (request of a key change, request of the verification of a key, etc.).|
/// 
/// 
/// </summary>
[Serializable]
[Description(@"The KeyExchangeInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). This message is used to initiate a cryptographic key activity (request of a key change, request of the verification of a key, etc.).|||")]
public partial record KeyExchangeInitiationV03 : IOuterRecord<KeyExchangeInitiationV03,KeyExchangeInitiationV03Document>
    ,IIsoXmlSerilizable<KeyExchangeInitiationV03>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "canm.003.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "KeyXchgInitn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => KeyExchangeInitiationV03Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_oOlvs4v6EeumSPwlS1PkxQ")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header63 Header { get; init; }
    
    /// <summary>
    /// Information related to a key exchange activity.
    /// </summary>
    [IsoId("_oOlvtYv6EeumSPwlS1PkxQ")]
    [Description(@"Information related to a key exchange activity.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required KeyExchangeInitiation2 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_oOlvt4v6EeumSPwlS1PkxQ")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="KeyExchangeInitiationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public KeyExchangeInitiationV03Document ToDocument()
    {
        return new KeyExchangeInitiationV03Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("KeyXchgInitn");
    
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
    public static KeyExchangeInitiationV03 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="KeyExchangeInitiationV03"/>.
/// </summary>
[Serializable]
public partial record KeyExchangeInitiationV03Document : IOuterDocument<KeyExchangeInitiationV03>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:canm.003.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="KeyExchangeInitiationV03"/> is required.
    /// </summary>
    [DataMember(Name=KeyExchangeInitiationV03.XmlTag)]
    public required KeyExchangeInitiationV03 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(KeyExchangeInitiationV03.XmlTag);
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
