﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMKeyDownloadResponseV02.  ISO2002 ID# __AA4sa45EeWRfYPBaeOY8w.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.caam.ATMKeyDownloadResponseV02>;

namespace BeneficialStrategies.Iso20022.caam;


/// <summary>
/// This record is an implementation of the caam.004.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMKeyDownloadResponse message is sent from an acquirer to an ATM in response to an ATMKeyDownloadRequest message, to download of one or several cryptographic keys.
/// </summary>
[Serializable]
[Description(@"The ATMKeyDownloadResponse message is sent from an acquirer to an ATM in response to an ATMKeyDownloadRequest message, to download of one or several cryptographic keys.")]
public partial record ATMKeyDownloadResponseV02 : IOuterRecord<ATMKeyDownloadResponseV02,ATMKeyDownloadResponseV02Document>
    ,IIsoXmlSerilizable<ATMKeyDownloadResponseV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.004.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMKeyDwnldRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ATMKeyDownloadResponseV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("__AA4s645EeWRfYPBaeOY8w")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header31 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("__AA4ta45EeWRfYPBaeOY8w")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMKeyDwnldRspn")]
    [XmlElement(ElementName="PrtctdATMKeyDwnldRspn")]
    public ContentInformationType10? ProtectedATMKeyDownloadResponse { get; init; }
    
    /// <summary>
    /// Information related to the response of an ATM key download from an ATM manager.
    /// </summary>
    [IsoId("__AA4t645EeWRfYPBaeOY8w")]
    [Description(@"Information related to the response of an ATM key download from an ATM manager.")]
    [DataMember(Name="ATMKeyDwnldRspn")]
    [XmlElement(ElementName="ATMKeyDwnldRspn")]
    public ATMKeyDownloadResponse2? ATMKeyDownloadResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("__AA4ua45EeWRfYPBaeOY8w")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType13? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMKeyDownloadResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMKeyDownloadResponseV02Document ToDocument()
    {
        return new ATMKeyDownloadResponseV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("ATMKeyDwnldRspn");
    
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
        if (ProtectedATMKeyDownloadResponse is ContentInformationType10 ProtectedATMKeyDownloadResponseValue)
        {
            writer.WriteStartElement(null, "PrtctdATMKeyDwnldRspn", xmlNamespace );
            ProtectedATMKeyDownloadResponseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ATMKeyDownloadResponse is ATMKeyDownloadResponse2 ATMKeyDownloadResponseValue)
        {
            writer.WriteStartElement(null, "ATMKeyDwnldRspn", xmlNamespace );
            ATMKeyDownloadResponseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecurityTrailer is ContentInformationType13 SecurityTrailerValue)
        {
            writer.WriteStartElement(null, "SctyTrlr", xmlNamespace );
            SecurityTrailerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ATMKeyDownloadResponseV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMKeyDownloadResponseV02"/>.
/// </summary>
[Serializable]
public partial record ATMKeyDownloadResponseV02Document : IOuterDocument<ATMKeyDownloadResponseV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.004.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMKeyDownloadResponseV02"/> is required.
    /// </summary>
    [DataMember(Name=ATMKeyDownloadResponseV02.XmlTag)]
    public required ATMKeyDownloadResponseV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(ATMKeyDownloadResponseV02.XmlTag);
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
