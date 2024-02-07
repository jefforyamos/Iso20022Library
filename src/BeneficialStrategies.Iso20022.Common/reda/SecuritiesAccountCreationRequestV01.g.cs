﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesAccountCreationRequestV01.  ISO2002 ID# _KAlNzZ2fEem_Be8NuxvF7Q.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.reda.SecuritiesAccountCreationRequestV01>;

namespace BeneficialStrategies.Iso20022.reda;


/// <summary>
/// This record is an implementation of the reda.018.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SecuritiesAccountCreationRequest message message is sent by an instructing party to the executing party to instruct the creation of a new securities account with the required account attributes details.
/// |
/// Usage:|
/// Processing and confirmation of the securities account creation request message are provided via a SecuritiesAccountStatusAdvice message.
/// </summary>
[Serializable]
[Description(@"The SecuritiesAccountCreationRequest message message is sent by an instructing party to the executing party to instruct the creation of a new securities account with the required account attributes details.|||Usage:||Processing and confirmation of the securities account creation request message are provided via a SecuritiesAccountStatusAdvice message.")]
public partial record SecuritiesAccountCreationRequestV01 : IOuterRecord<SecuritiesAccountCreationRequestV01,SecuritiesAccountCreationRequestV01Document>
    ,IIsoXmlSerilizable<SecuritiesAccountCreationRequestV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.018.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesAcctCreReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesAccountCreationRequestV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_gl0bMJ5GEemQg7pJhFUUYg")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    public MessageHeader1? MessageHeader { get; init; }
    
    /// <summary>
    /// Securities account to be created in the executing party system.
    /// </summary>
    [IsoId("_KAu-l52fEem_Be8NuxvF7Q")]
    [Description(@"Securities account to be created in the executing party system.")]
    [DataMember(Name="SctiesAcct")]
    [XmlElement(ElementName="SctiesAcct")]
    [Required]
    public required SystemSecuritiesAccount7 SecuritiesAccount { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KAu-mZ2fEem_Be8NuxvF7Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesAccountCreationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesAccountCreationRequestV01Document ToDocument()
    {
        return new SecuritiesAccountCreationRequestV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SctiesAcctCreReq");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (MessageHeader is MessageHeader1 MessageHeaderValue)
        {
            writer.WriteStartElement(null, "MsgHdr", xmlNamespace );
            MessageHeaderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctiesAcct", xmlNamespace );
        SecuritiesAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesAccountCreationRequestV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesAccountCreationRequestV01"/>.
/// </summary>
[Serializable]
public partial record SecuritiesAccountCreationRequestV01Document : IOuterDocument<SecuritiesAccountCreationRequestV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.018.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesAccountCreationRequestV01"/> is required.
    /// </summary>
    [DataMember(Name=SecuritiesAccountCreationRequestV01.XmlTag)]
    public required SecuritiesAccountCreationRequestV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SecuritiesAccountCreationRequestV01.XmlTag);
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
