﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CustomReportV01.  ISO2002 ID# _4z6yUMlHEeuJ35KoBRZFOg.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.caad.CustomReportV01>;

namespace BeneficialStrategies.Iso20022.caad;


/// <summary>
/// This record is an implementation of the caad.010.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Custom Report message can be initiated by any party and received by any party (acquirer, agent, issuer or other party) connected to a network.
/// 
/// This message provides the capability to convey customized reports that are defined by bi-lateral agreement.
/// </summary>
[Serializable]
[Description(@"The Custom Report message can be initiated by any party and received by any party (acquirer, agent, issuer or other party) connected to a network.||This message provides the capability to convey customized reports that are defined by bi-lateral agreement.")]
public partial record CustomReportV01 : IOuterRecord<CustomReportV01,CustomReportV01Document>
    ,IIsoXmlSerilizable<CustomReportV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caad.010.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CstmRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CustomReportV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Information related to protocol management.
    /// </summary>
    [IsoId("_gLegIMlLEeuJ35KoBRZFOg")]
    [Description(@"Information related to protocol management.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header65 Header { get; init; }
    
    /// <summary>
    /// Information related to the customer report.
    /// </summary>
    [IsoId("_rJnosMlLEeuJ35KoBRZFOg")]
    [Description(@"Information related to the customer report.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required CustomReport1 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_t0su4clLEeuJ35KoBRZFOg")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CustomReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CustomReportV01Document ToDocument()
    {
        return new CustomReportV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CstmRpt");
    
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
        writer.WriteStartElement(null, "Body", xmlNamespace );
        Body.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecurityTrailer is ContentInformationType20 SecurityTrailerValue)
        {
            writer.WriteStartElement(null, "SctyTrlr", xmlNamespace );
            SecurityTrailerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CustomReportV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CustomReportV01"/>.
/// </summary>
[Serializable]
public partial record CustomReportV01Document : IOuterDocument<CustomReportV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.010.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CustomReportV01"/> is required.
    /// </summary>
    [DataMember(Name=CustomReportV01.XmlTag)]
    public required CustomReportV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CustomReportV01.XmlTag);
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
