﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PartyCreationRequestV01.  ISO2002 ID# _lfqucZeTEeen_cyMrluY4w.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.reda.PartyCreationRequestV01>;

namespace BeneficialStrategies.Iso20022.reda;


/// <summary>
/// This record is an implementation of the reda.014.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:|The PartyCreationRequest message is sent by an instructing party to the executing party to request for the creation of party reference data for a new party in the executing system.||Usage:|It aims at instructing the creation of a new party with corresponding details.|Processing and confirmation of the party creation request are provided via a party status advice.
/// </summary>
[Serializable]
[Description(@"Scope:|The PartyCreationRequest message is sent by an instructing party to the executing party to request for the creation of party reference data for a new party in the executing system.||Usage:|It aims at instructing the creation of a new party with corresponding details.|Processing and confirmation of the party creation request are provided via a party status advice.")]
public partial record PartyCreationRequestV01 : IOuterRecord<PartyCreationRequestV01,PartyCreationRequestV01Document>
    ,IIsoXmlSerilizable<PartyCreationRequestV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.014.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyCreReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => PartyCreationRequestV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_c7obABivEeiGdqyppFhcBA")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    public MessageHeader1? MessageHeader { get; init; }
    
    /// <summary>
    /// Specifies the details of the party to be created in the system.
    /// </summary>
    [IsoId("_H_lCYBiwEei5IMHVES5gUw")]
    [Description(@"Specifies the details of the party to be created in the system.")]
    [DataMember(Name="Pty")]
    [XmlElement(ElementName="Pty")]
    [Required]
    public required SystemParty4 Party { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_lfque5eTEeen_cyMrluY4w")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PartyCreationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PartyCreationRequestV01Document ToDocument()
    {
        return new PartyCreationRequestV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("PtyCreReq");
    
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
        writer.WriteStartElement(null, "Pty", xmlNamespace );
        Party.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PartyCreationRequestV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PartyCreationRequestV01"/>.
/// </summary>
[Serializable]
public partial record PartyCreationRequestV01Document : IOuterDocument<PartyCreationRequestV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.014.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PartyCreationRequestV01"/> is required.
    /// </summary>
    [DataMember(Name=PartyCreationRequestV01.XmlTag)]
    public required PartyCreationRequestV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(PartyCreationRequestV01.XmlTag);
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
