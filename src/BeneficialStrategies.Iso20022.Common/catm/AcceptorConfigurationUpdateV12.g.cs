﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorConfigurationUpdateV12.  ISO2002 ID# _hasO4XPSEe2pK6udhxEaHA.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.catm.AcceptorConfigurationUpdateV12>;

namespace BeneficialStrategies.Iso20022.catm;


/// <summary>
/// This record is an implementation of the catm.003.001.12 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorConfigurationUpdate message is sent by a TM to a POI to update configurations.
/// </summary>
[Serializable]
[Description(@"The AcceptorConfigurationUpdate message is sent by a TM to a POI to update configurations.")]
public partial record AcceptorConfigurationUpdateV12 : IOuterRecord<AcceptorConfigurationUpdateV12,AcceptorConfigurationUpdateV12Document>
    ,IIsoXmlSerilizable<AcceptorConfigurationUpdateV12>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.003.001.12";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCfgtnUpd";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AcceptorConfigurationUpdateV12Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Set of characteristics related to the transfer of the acceptor parameters.
    /// </summary>
    [IsoId("_hasO5XPSEe2pK6udhxEaHA")]
    [Description(@"Set of characteristics related to the transfer of the acceptor parameters.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required TMSHeader1 Header { get; init; }
    
    /// <summary>
    /// Acceptor configuration to be downloaded from the terminal management system.
    /// </summary>
    [IsoId("_hasO53PSEe2pK6udhxEaHA")]
    [Description(@"Acceptor configuration to be downloaded from the terminal management system.")]
    [DataMember(Name="AccptrCfgtn")]
    [XmlElement(ElementName="AccptrCfgtn")]
    [Required]
    public required AcceptorConfiguration12 AcceptorConfiguration { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_hasO6XPSEe2pK6udhxEaHA")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType33? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorConfigurationUpdateV12Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorConfigurationUpdateV12Document ToDocument()
    {
        return new AcceptorConfigurationUpdateV12Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AccptrCfgtnUpd");
    
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
        writer.WriteStartElement(null, "AccptrCfgtn", xmlNamespace );
        AcceptorConfiguration.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecurityTrailer is ContentInformationType33 SecurityTrailerValue)
        {
            writer.WriteStartElement(null, "SctyTrlr", xmlNamespace );
            SecurityTrailerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AcceptorConfigurationUpdateV12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorConfigurationUpdateV12"/>.
/// </summary>
[Serializable]
public partial record AcceptorConfigurationUpdateV12Document : IOuterDocument<AcceptorConfigurationUpdateV12>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.003.001.12";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorConfigurationUpdateV12"/> is required.
    /// </summary>
    [DataMember(Name=AcceptorConfigurationUpdateV12.XmlTag)]
    public required AcceptorConfigurationUpdateV12 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AcceptorConfigurationUpdateV12.XmlTag);
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
