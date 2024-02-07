﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMRejectV01.  ISO2002 ID# _DvwXcIrFEeSRwL6n4K9igA.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.catp.ATMRejectV01>;

namespace BeneficialStrategies.Iso20022.catp;


/// <summary>
/// This record is an implementation of the catp.005.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMReject message is sent by any entity to reject a received message.
/// </summary>
[Serializable]
[Description(@"The ATMReject message is sent by any entity to reject a received message.")]
public partial record ATMRejectV01 : IOuterRecord<ATMRejectV01,ATMRejectV01Document>
    ,IIsoXmlSerilizable<ATMRejectV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.005.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMRjct";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ATMRejectV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_fyheoIrFEeSRwL6n4K9igA")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header22 Header { get; init; }
    
    /// <summary>
    /// Information related to the reject of a message from an ATM or an ATM manager.
    /// </summary>
    [IsoId("_3TnxcIrFEeSRwL6n4K9igA")]
    [Description(@"Information related to the reject of a message from an ATM or an ATM manager.")]
    [DataMember(Name="ATMRjct")]
    [XmlElement(ElementName="ATMRjct")]
    [Required]
    public required ATMReject1 ATMReject { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMRejectV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMRejectV01Document ToDocument()
    {
        return new ATMRejectV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("ATMRjct");
    
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
        writer.WriteStartElement(null, "ATMRjct", xmlNamespace );
        ATMReject.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ATMRejectV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMRejectV01"/>.
/// </summary>
[Serializable]
public partial record ATMRejectV01Document : IOuterDocument<ATMRejectV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.005.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMRejectV01"/> is required.
    /// </summary>
    [DataMember(Name=ATMRejectV01.XmlTag)]
    public required ATMRejectV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(ATMRejectV01.XmlTag);
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
