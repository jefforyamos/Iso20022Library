﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestToPayCreditorEnrolmentCancellationRequestV01.  ISO2002 ID# _rNNBm-HzEeqbls7Gk4-ckA.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.reda.RequestToPayCreditorEnrolmentCancellationRequestV01>;

namespace BeneficialStrategies.Iso20022.reda;


/// <summary>
/// This record is an implementation of the reda.068.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The RequestToPayCreditorEnrolmentCancellationRequest message is sent by the creditor RTP (Request To Pay) provider to an RTP directory provider and optionally by the creditor to a creditor RTP provider to request for the cancellation of the creditor registration in the RTP directory. 
/// The message may also be forwarded to any authorised third party, as defined in the local scheme
/// </summary>
[Serializable]
[Description(@"The RequestToPayCreditorEnrolmentCancellationRequest message is sent by the creditor RTP (Request To Pay) provider to an RTP directory provider and optionally by the creditor to a creditor RTP provider to request for the cancellation of the creditor registration in the RTP directory. |The message may also be forwarded to any authorised third party, as defined in the local scheme")]
public partial record RequestToPayCreditorEnrolmentCancellationRequestV01 : IOuterRecord<RequestToPayCreditorEnrolmentCancellationRequestV01,RequestToPayCreditorEnrolmentCancellationRequestV01Document>
    ,IIsoXmlSerilizable<RequestToPayCreditorEnrolmentCancellationRequestV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.068.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqToPayCdtrEnrlmntCxlReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => RequestToPayCreditorEnrolmentCancellationRequestV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the cancellation of the creditor enrolment.
    /// </summary>
    [IsoId("_rNNBn-HzEeqbls7Gk4-ckA")]
    [Description(@"Set of characteristics to identify the message and parties playing a role in the cancellation of the creditor enrolment.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required EnrolmentHeader2 Header { get; init; }
    
    /// <summary>
    /// Set of elements used to provide details on the cancellation request.
    /// </summary>
    [IsoId("_rNNBoeHzEeqbls7Gk4-ckA")]
    [Description(@"Set of elements used to provide details on the cancellation request.")]
    [DataMember(Name="CxlData")]
    [XmlElement(ElementName="CxlData")]
    [Required]
    public required CreditorEnrolmentCancellation2 CancellationData { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rNNBo-HzEeqbls7Gk4-ckA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RequestToPayCreditorEnrolmentCancellationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestToPayCreditorEnrolmentCancellationRequestV01Document ToDocument()
    {
        return new RequestToPayCreditorEnrolmentCancellationRequestV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("ReqToPayCdtrEnrlmntCxlReq");
    
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
        writer.WriteStartElement(null, "CxlData", xmlNamespace );
        CancellationData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RequestToPayCreditorEnrolmentCancellationRequestV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RequestToPayCreditorEnrolmentCancellationRequestV01"/>.
/// </summary>
[Serializable]
public partial record RequestToPayCreditorEnrolmentCancellationRequestV01Document : IOuterDocument<RequestToPayCreditorEnrolmentCancellationRequestV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.068.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RequestToPayCreditorEnrolmentCancellationRequestV01"/> is required.
    /// </summary>
    [DataMember(Name=RequestToPayCreditorEnrolmentCancellationRequestV01.XmlTag)]
    public required RequestToPayCreditorEnrolmentCancellationRequestV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(RequestToPayCreditorEnrolmentCancellationRequestV01.XmlTag);
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
