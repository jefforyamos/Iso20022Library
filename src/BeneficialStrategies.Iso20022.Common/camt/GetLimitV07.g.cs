﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for GetLimitV07.  ISO2002 ID# _jwlbhxbvEeiyVv5j1vf1VQ.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.camt.GetLimitV07>;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// This record is an implementation of the camt.009.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The GetLimit message is used to request information on the details of one or more limits set by the member (or on behalf of the member) and managed by the transaction administrator.
/// </summary>
[Serializable]
[Description(@"The GetLimit message is used to request information on the details of one or more limits set by the member (or on behalf of the member) and managed by the transaction administrator.")]
public partial record GetLimitV07 : IOuterRecord<GetLimitV07,GetLimitV07Document>
    ,IIsoXmlSerilizable<GetLimitV07>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.009.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetLmt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => GetLimitV07Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbiRbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader9 MessageHeader { get; init; }
    
    /// <summary>
    /// Defines the limit query criteria.
    /// </summary>
    [IsoId("_jwlbixbvEeiyVv5j1vf1VQ")]
    [Description(@"Defines the limit query criteria.")]
    [DataMember(Name="LmtQryDef")]
    [XmlElement(ElementName="LmtQryDef")]
    public LimitQuery4? LimitQueryDefinition { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbjRbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="GetLimitV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public GetLimitV07Document ToDocument()
    {
        return new GetLimitV07Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("GetLmt");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MsgHdr", xmlNamespace );
        MessageHeader.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (LimitQueryDefinition is LimitQuery4 LimitQueryDefinitionValue)
        {
            writer.WriteStartElement(null, "LmtQryDef", xmlNamespace );
            LimitQueryDefinitionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static GetLimitV07 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="GetLimitV07"/>.
/// </summary>
[Serializable]
public partial record GetLimitV07Document : IOuterDocument<GetLimitV07>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.009.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="GetLimitV07"/> is required.
    /// </summary>
    [DataMember(Name=GetLimitV07.XmlTag)]
    public required GetLimitV07 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(GetLimitV07.XmlTag);
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
