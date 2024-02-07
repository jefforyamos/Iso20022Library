﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorNonFinancialResponseV01.  ISO2002 ID# _Zf-nIC_tEeugIJ3Gvoevmg.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.caaa.AcceptorNonFinancialResponseV01>;

namespace BeneficialStrategies.Iso20022.caaa;


/// <summary>
/// This record is an implementation of the caaa.023.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorNonFinancialResponse message is sent by the Acquirer (or its Agent) to the POI to provide addintional information.
/// </summary>
[Serializable]
[Description(@"The AcceptorNonFinancialResponse message is sent by the Acquirer (or its Agent) to the POI to provide addintional information.")]
public partial record AcceptorNonFinancialResponseV01 : IOuterRecord<AcceptorNonFinancialResponseV01,AcceptorNonFinancialResponseV01Document>
    ,IIsoXmlSerilizable<AcceptorNonFinancialResponseV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.023.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrNonFinRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AcceptorNonFinancialResponseV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Non Financial response message management information.
    /// </summary>
    [IsoId("_xpdIky_tEeugIJ3Gvoevmg")]
    [Description(@"Non Financial response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header59 Header { get; init; }
    
    /// <summary>
    /// Information related to the non financial response.
    /// </summary>
    [IsoId("_xpdIlC_tEeugIJ3Gvoevmg")]
    [Description(@"Information related to the non financial response.")]
    [DataMember(Name="NonFinRspn")]
    [XmlElement(ElementName="NonFinRspn")]
    [Required]
    public required NonFinancialResponseComponent1 NonFinancialResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_xpdIlS_tEeugIJ3Gvoevmg")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType27? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorNonFinancialResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorNonFinancialResponseV01Document ToDocument()
    {
        return new AcceptorNonFinancialResponseV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AccptrNonFinRspn");
    
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
        writer.WriteStartElement(null, "NonFinRspn", xmlNamespace );
        NonFinancialResponse.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecurityTrailer is ContentInformationType27 SecurityTrailerValue)
        {
            writer.WriteStartElement(null, "SctyTrlr", xmlNamespace );
            SecurityTrailerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AcceptorNonFinancialResponseV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorNonFinancialResponseV01"/>.
/// </summary>
[Serializable]
public partial record AcceptorNonFinancialResponseV01Document : IOuterDocument<AcceptorNonFinancialResponseV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.023.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorNonFinancialResponseV01"/> is required.
    /// </summary>
    [DataMember(Name=AcceptorNonFinancialResponseV01.XmlTag)]
    public required AcceptorNonFinancialResponseV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AcceptorNonFinancialResponseV01.XmlTag);
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
