﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMTransferRequestV01.  ISO2002 ID# _vueJoK4rEeWLdt0vLARX2Q.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.catp.ATMTransferRequestV01>;

namespace BeneficialStrategies.Iso20022.catp;


/// <summary>
/// This record is an implementation of the catp.016.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMTransferRequest message is sent by an ATM to an ATM manager to request the approval of a fund transfer at the ATM.
/// </summary>
[Serializable]
[Description(@"The ATMTransferRequest message is sent by an ATM to an ATM manager to request the approval of a fund transfer at the ATM.")]
public partial record ATMTransferRequestV01 : IOuterRecord<ATMTransferRequestV01,ATMTransferRequestV01Document>
    ,IIsoXmlSerilizable<ATMTransferRequestV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.016.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMTrfReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ATMTransferRequestV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_7z5qYK4rEeWLdt0vLARX2Q")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header31 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_Ag7aMK4sEeWLdt0vLARX2Q")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMTrfReq")]
    [XmlElement(ElementName="PrtctdATMTrfReq")]
    public ContentInformationType10? ProtectedATMTransferRequest { get; init; }
    
    /// <summary>
    /// Information related to the request of a fund transfer from an ATM.
    /// </summary>
    [IsoId("_HwpwQK4sEeWLdt0vLARX2Q")]
    [Description(@"Information related to the request of a fund transfer from an ATM.")]
    [DataMember(Name="ATMTrfReq")]
    [XmlElement(ElementName="ATMTrfReq")]
    public ATMTransferRequest1? ATMTransferRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_A9cA8K41EeWpsoxRhdX-8A")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMTransferRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMTransferRequestV01Document ToDocument()
    {
        return new ATMTransferRequestV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("ATMTrfReq");
    
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
        if (ProtectedATMTransferRequest is ContentInformationType10 ProtectedATMTransferRequestValue)
        {
            writer.WriteStartElement(null, "PrtctdATMTrfReq", xmlNamespace );
            ProtectedATMTransferRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ATMTransferRequest is ATMTransferRequest1 ATMTransferRequestValue)
        {
            writer.WriteStartElement(null, "ATMTrfReq", xmlNamespace );
            ATMTransferRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecurityTrailer is ContentInformationType15 SecurityTrailerValue)
        {
            writer.WriteStartElement(null, "SctyTrlr", xmlNamespace );
            SecurityTrailerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ATMTransferRequestV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMTransferRequestV01"/>.
/// </summary>
[Serializable]
public partial record ATMTransferRequestV01Document : IOuterDocument<ATMTransferRequestV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.016.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMTransferRequestV01"/> is required.
    /// </summary>
    [DataMember(Name=ATMTransferRequestV01.XmlTag)]
    public required ATMTransferRequestV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(ATMTransferRequestV01.XmlTag);
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
