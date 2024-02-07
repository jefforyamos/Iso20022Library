﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCARESD1V01.  ISO2002 ID# _kTKBcH9ZEeO-N9QmoyzDJw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.supl.DTCCCARESD1V01>;

namespace BeneficialStrategies.Iso20022.supl;


/// <summary>
/// This record is an implementation of the supl.025.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCARESD1 message extends ISO corporate action movement reversal advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[Description(@"The DTCCCARESD1 message extends ISO corporate action movement reversal advice message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCARESD1V01 : IOuterRecord<DTCCCARESD1V01,DTCCCARESD1V01Document>
    ,IIsoXmlSerilizable<DTCCCARESD1V01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.025.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCARESD1";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DTCCCARESD1V01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_cdMVUX9aEeO-N9QmoyzDJw")]
    [Description(@"Information to be extended as supplementary data to corporate action details.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateActionSD12? CorporateActionDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCARESD1V01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCARESD1V01Document ToDocument()
    {
        return new DTCCCARESD1V01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("DTCCCARESD1");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (CorporateActionDetails is CorporateActionSD12 CorporateActionDetailsValue)
        {
            writer.WriteStartElement(null, "CorpActnDtls", xmlNamespace );
            CorporateActionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DTCCCARESD1V01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCARESD1V01"/>.
/// </summary>
[Serializable]
public partial record DTCCCARESD1V01Document : IOuterDocument<DTCCCARESD1V01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.025.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCARESD1V01"/> is required.
    /// </summary>
    [DataMember(Name=DTCCCARESD1V01.XmlTag)]
    public required DTCCCARESD1V01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(DTCCCARESD1V01.XmlTag);
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
