﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RoleAndBaselineAcceptanceV01.  ISO2002 ID# _tSUHeNE8Ed-BzquC8wXy7w_1282098535.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.tsmt.RoleAndBaselineAcceptanceV01>;

namespace BeneficialStrategies.Iso20022.tsmt;


/// <summary>
/// This record is an implementation of the tsmt.049.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RoleAndBaselineAcceptance message is sent by a secondary bank to the matching application if it accepts to join the transaction based on the baseline and the role that it is expected to play.
/// Usage
/// The RoleAndBaselineAcceptance message is sent in response to a message that is a direct request to join a transaction.
/// </summary>
[Serializable]
[Description(@"Scope|The RoleAndBaselineAcceptance message is sent by a secondary bank to the matching application if it accepts to join the transaction based on the baseline and the role that it is expected to play.|Usage|The RoleAndBaselineAcceptance message is sent in response to a message that is a direct request to join a transaction.")]
public partial record RoleAndBaselineAcceptanceV01 : IOuterRecord<RoleAndBaselineAcceptanceV01,RoleAndBaselineAcceptanceV01Document>
    ,IIsoXmlSerilizable<RoleAndBaselineAcceptanceV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.049.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RoleAndBaselnAccptnc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => RoleAndBaselineAcceptanceV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the acceptance message.
    /// </summary>
    [IsoId("_tSdRYNE8Ed-BzquC8wXy7w_1282098561")]
    [Description(@"Identifies the acceptance message.")]
    [DataMember(Name="AccptncId")]
    [XmlElement(ElementName="AccptncId")]
    [Required]
    public required MessageIdentification1 AcceptanceIdentification { get; init; }
    
    /// <summary>
    /// Reference to the message that contained the baseline and is accepted.
    /// </summary>
    [IsoId("_tSdRYdE8Ed-BzquC8wXy7w_1662420594")]
    [Description(@"Reference to the message that contained the baseline and is accepted.")]
    [DataMember(Name="RltdMsgRef")]
    [XmlElement(ElementName="RltdMsgRef")]
    [Required]
    public required MessageIdentification1 RelatedMessageReference { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_tSdRYtE8Ed-BzquC8wXy7w_1282098638")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RoleAndBaselineAcceptanceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RoleAndBaselineAcceptanceV01Document ToDocument()
    {
        return new RoleAndBaselineAcceptanceV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("RoleAndBaselnAccptnc");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "AccptncId", xmlNamespace );
        AcceptanceIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RltdMsgRef", xmlNamespace );
        RelatedMessageReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static RoleAndBaselineAcceptanceV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RoleAndBaselineAcceptanceV01"/>.
/// </summary>
[Serializable]
public partial record RoleAndBaselineAcceptanceV01Document : IOuterDocument<RoleAndBaselineAcceptanceV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.049.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RoleAndBaselineAcceptanceV01"/> is required.
    /// </summary>
    [DataMember(Name=RoleAndBaselineAcceptanceV01.XmlTag)]
    public required RoleAndBaselineAcceptanceV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(RoleAndBaselineAcceptanceV01.XmlTag);
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
