﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PaymentSD1V01.  ISO2002 ID# _ZAIu0PwLEeGHDMP28rpT3g_-1117810318.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.supl.PaymentSD1V01>;

namespace BeneficialStrategies.Iso20022.supl;


/// <summary>
/// This record is an implementation of the supl.017.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Supplementary data for payment message definitions.
/// </summary>
[Serializable]
[Description(@"Supplementary data for payment message definitions.")]
public partial record PaymentSD1V01 : IOuterRecord<PaymentSD1V01,PaymentSD1V01Document>
    ,IIsoXmlSerilizable<PaymentSD1V01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.017.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PmtSD1";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => PaymentSD1V01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Structured card remittance information supplied in a payment.
    /// </summary>
    [IsoId("_ZAIu0fwLEeGHDMP28rpT3g_-1719162242")]
    [Description(@"Structured card remittance information supplied in a payment.")]
    [DataMember(Name="CardRmtInf")]
    [XmlElement(ElementName="CardRmtInf")]
    [Required]
    public required TransactionData1 CardRemittanceInformation { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PaymentSD1V01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PaymentSD1V01Document ToDocument()
    {
        return new PaymentSD1V01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("PmtSD1");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "CardRmtInf", xmlNamespace );
        CardRemittanceInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static PaymentSD1V01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PaymentSD1V01"/>.
/// </summary>
[Serializable]
public partial record PaymentSD1V01Document : IOuterDocument<PaymentSD1V01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.017.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PaymentSD1V01"/> is required.
    /// </summary>
    [DataMember(Name=PaymentSD1V01.XmlTag)]
    public required PaymentSD1V01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(PaymentSD1V01.XmlTag);
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
