﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraBalanceMovementModificationQueryV01.  ISO2002 ID# _DLtKyzncEem7JZMuWtwtsg.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.camt.IntraBalanceMovementModificationQueryV01>;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// This record is an implementation of the camt.080.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The IntraBalanceMovementModificationQuery message is sent from an account owner/requestor to a settlement infrastructure to query for the status of intra-balance movement modification instruction(s) based on a set of search criteria or business attributes.
/// The message may also be used to: 
/// - re-send a message sent by the account owner to the account servicer (the sub-function of the message is "Duplicate") 
/// - provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy") 
/// - re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy Duplicate").
/// </summary>
[Serializable]
[Description(@"The IntraBalanceMovementModificationQuery message is sent from an account owner/requestor to a settlement infrastructure to query for the status of intra-balance movement modification instruction(s) based on a set of search criteria or business attributes.|The message may also be used to: |- re-send a message sent by the account owner to the account servicer (the sub-function of the message is ""Duplicate"") |- provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy"") |- re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy Duplicate"").")]
public partial record IntraBalanceMovementModificationQueryV01 : IOuterRecord<IntraBalanceMovementModificationQueryV01,IntraBalanceMovementModificationQueryV01Document>
    ,IIsoXmlSerilizable<IntraBalanceMovementModificationQueryV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.080.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntModQry";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => IntraBalanceMovementModificationQueryV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Unambiguous identification of the message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_DLtK0zncEem7JZMuWtwtsg")]
    [Description(@"Unambiguous identification of the message as known by the account owner (or the instructing party acting on its behalf).")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    public DocumentIdentification51? Identification { get; init; }
    
    /// <summary>
    /// Defines the intra-balance movement modification query criteria.
    /// </summary>
    [IsoId("_DLtK1TncEem7JZMuWtwtsg")]
    [Description(@"Defines the intra-balance movement modification query criteria.")]
    [DataMember(Name="QryDef")]
    [XmlElement(ElementName="QryDef")]
    [Required]
    public required IntraBalanceQueryDefinition8 QueryDefinition { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DLtK1zncEem7JZMuWtwtsg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntraBalanceMovementModificationQueryV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraBalanceMovementModificationQueryV01Document ToDocument()
    {
        return new IntraBalanceMovementModificationQueryV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("IntraBalMvmntModQry");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Identification is DocumentIdentification51 IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            IdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "QryDef", xmlNamespace );
        QueryDefinition.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static IntraBalanceMovementModificationQueryV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IntraBalanceMovementModificationQueryV01"/>.
/// </summary>
[Serializable]
public partial record IntraBalanceMovementModificationQueryV01Document : IOuterDocument<IntraBalanceMovementModificationQueryV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.080.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntraBalanceMovementModificationQueryV01"/> is required.
    /// </summary>
    [DataMember(Name=IntraBalanceMovementModificationQueryV01.XmlTag)]
    public required IntraBalanceMovementModificationQueryV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(IntraBalanceMovementModificationQueryV01.XmlTag);
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
