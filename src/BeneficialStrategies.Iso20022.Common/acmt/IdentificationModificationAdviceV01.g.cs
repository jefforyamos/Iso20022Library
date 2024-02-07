﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IdentificationModificationAdviceV01.  ISO2002 ID# _sSPRRWtdEeCY4-KZ9JEyUQ_219398369.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.acmt.IdentificationModificationAdviceV01>;

namespace BeneficialStrategies.Iso20022.acmt;


/// <summary>
/// This record is an implementation of the acmt.022.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The IdentificationModificationAdvice message is sent by an assigner to an assignee. The message is used to advice on the correct party and/or account identification information.
/// Usage
/// The IdentificationModificationAdvice message is sent after the receipt of one or several transaction messages that included no longer valid party and/or account identification information.
/// The IdentificationModificationAdvice message is exchanged between financial institutions and between financial institutions and non financial institutions and can contain one or more modification advises.
/// There is no time limit on the time between the sending of an IdentificationModificationAdvice message and the receipt of the transaction messages that the IdentificationModificationAdvice refers to.
/// The IdentificationModificationAdvice includes the correct party and/or account identification information, the IdentificationModificationAdvice or the included information may be forwarded to the initiating party of the transaction messages.
/// </summary>
[Serializable]
[Description(@"Scope|The IdentificationModificationAdvice message is sent by an assigner to an assignee. The message is used to advice on the correct party and/or account identification information.|Usage|The IdentificationModificationAdvice message is sent after the receipt of one or several transaction messages that included no longer valid party and/or account identification information.|The IdentificationModificationAdvice message is exchanged between financial institutions and between financial institutions and non financial institutions and can contain one or more modification advises.|There is no time limit on the time between the sending of an IdentificationModificationAdvice message and the receipt of the transaction messages that the IdentificationModificationAdvice refers to.|The IdentificationModificationAdvice includes the correct party and/or account identification information, the IdentificationModificationAdvice or the included information may be forwarded to the initiating party of the transaction messages.")]
public partial record IdentificationModificationAdviceV01 : IOuterRecord<IdentificationModificationAdviceV01,IdentificationModificationAdviceV01Document>
    ,IIsoXmlSerilizable<IdentificationModificationAdviceV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.022.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IdModAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => IdentificationModificationAdviceV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the identification assignment.
    /// </summary>
    [IsoId("_sSPRRmtdEeCY4-KZ9JEyUQ_-1640410798")]
    [Description(@"Identifies the identification assignment.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required IdentificationAssignment1 Assignment { get; init; }
    
    /// <summary>
    /// Provides reference information on the original message.
    /// </summary>
    [IsoId("_sSPRR2tdEeCY4-KZ9JEyUQ_-1861905124")]
    [Description(@"Provides reference information on the original message.")]
    [DataMember(Name="OrgnlTxRef")]
    [XmlElement(ElementName="OrgnlTxRef")]
    public OriginalTransactionReference14? OriginalTransactionReference { get; init; }
    
    /// <summary>
    /// Information concerning the identification data that is advised to be modified.
    /// </summary>
    [IsoId("_sSPRSGtdEeCY4-KZ9JEyUQ_791312082")]
    [Description(@"Information concerning the identification data that is advised to be modified.")]
    [DataMember(Name="Mod")]
    [XmlElement(ElementName="Mod")]
    [Required]
    public required IdentificationModification1 Modification { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IdentificationModificationAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IdentificationModificationAdviceV01Document ToDocument()
    {
        return new IdentificationModificationAdviceV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("IdModAdvc");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Assgnmt", xmlNamespace );
        Assignment.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OriginalTransactionReference is OriginalTransactionReference14 OriginalTransactionReferenceValue)
        {
            writer.WriteStartElement(null, "OrgnlTxRef", xmlNamespace );
            OriginalTransactionReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Mod", xmlNamespace );
        Modification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static IdentificationModificationAdviceV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IdentificationModificationAdviceV01"/>.
/// </summary>
[Serializable]
public partial record IdentificationModificationAdviceV01Document : IOuterDocument<IdentificationModificationAdviceV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.022.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IdentificationModificationAdviceV01"/> is required.
    /// </summary>
    [DataMember(Name=IdentificationModificationAdviceV01.XmlTag)]
    public required IdentificationModificationAdviceV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(IdentificationModificationAdviceV01.XmlTag);
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
