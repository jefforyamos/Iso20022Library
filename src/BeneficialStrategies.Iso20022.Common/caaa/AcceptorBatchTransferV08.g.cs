﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorBatchTransferV08.  ISO2002 ID# _hUUmMdekEeiJyp_aycJaTw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.caaa.AcceptorBatchTransferV08>;

namespace BeneficialStrategies.Iso20022.caaa;


/// <summary>
/// This record is an implementation of the caaa.011.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorBatchTransfer is sent by an acceptor (or its agent) to transfer the financial data of a collection of transactions to the acquirer (or its agent).
/// </summary>
[Serializable]
[Description(@"The AcceptorBatchTransfer is sent by an acceptor (or its agent) to transfer the financial data of a collection of transactions to the acquirer (or its agent).")]
public partial record AcceptorBatchTransferV08 : IOuterRecord<AcceptorBatchTransferV08,AcceptorBatchTransferV08Document>
    ,IIsoXmlSerilizable<AcceptorBatchTransferV08>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.011.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrBtchTrf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AcceptorBatchTransferV08Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Batch capture message management information.
    /// </summary>
    [IsoId("_hUUmNdekEeiJyp_aycJaTw")]
    [Description(@"Batch capture message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header25 Header { get; init; }
    
    /// <summary>
    /// Card payment transactions from one or several data set of transactions.
    /// </summary>
    [IsoId("_hUUmN9ekEeiJyp_aycJaTw")]
    [Description(@"Card payment transactions from one or several data set of transactions.")]
    [DataMember(Name="BtchTrf")]
    [XmlElement(ElementName="BtchTrf")]
    [Required]
    public required CardPaymentBatchTransfer7 BatchTransfer { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_hUUmOdekEeiJyp_aycJaTw")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType16? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorBatchTransferV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorBatchTransferV08Document ToDocument()
    {
        return new AcceptorBatchTransferV08Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AccptrBtchTrf");
    
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
        writer.WriteStartElement(null, "BtchTrf", xmlNamespace );
        BatchTransfer.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecurityTrailer is ContentInformationType16 SecurityTrailerValue)
        {
            writer.WriteStartElement(null, "SctyTrlr", xmlNamespace );
            SecurityTrailerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AcceptorBatchTransferV08 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorBatchTransferV08"/>.
/// </summary>
[Serializable]
public partial record AcceptorBatchTransferV08Document : IOuterDocument<AcceptorBatchTransferV08>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.011.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorBatchTransferV08"/> is required.
    /// </summary>
    [DataMember(Name=AcceptorBatchTransferV08.XmlTag)]
    public required AcceptorBatchTransferV08 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AcceptorBatchTransferV08.XmlTag);
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
