﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CreditorPaymentActivationRequestStatusReportV03.  ISO2002 ID# _g6BqUSNqEeKdIYatzYH-pQ.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.pain.CreditorPaymentActivationRequestStatusReportV03>;

namespace BeneficialStrategies.Iso20022.pain;


/// <summary>
/// This record is an implementation of the pain.014.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CreditorPaymentActivationRequestStatusReport message is sent by a party to the next party in the creditor payment activation request chain. It is used to inform the latter about the positive or negative status of a creditor payment activation request (either single or file).
/// </summary>
[Serializable]
[Description(@"The CreditorPaymentActivationRequestStatusReport message is sent by a party to the next party in the creditor payment activation request chain. It is used to inform the latter about the positive or negative status of a creditor payment activation request (either single or file).")]
public partial record CreditorPaymentActivationRequestStatusReportV03 : IOuterRecord<CreditorPaymentActivationRequestStatusReportV03,CreditorPaymentActivationRequestStatusReportV03Document>
    ,IIsoXmlSerilizable<CreditorPaymentActivationRequestStatusReportV03>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.014.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CdtrPmtActvtnReqStsRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CreditorPaymentActivationRequestStatusReportV03Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_g6BqYyNqEeKdIYatzYH-pQ")]
    [Description(@"Set of characteristics shared by all individual transactions included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader46 GroupHeader { get; init; }
    
    /// <summary>
    /// Original group information concerning the group of transactions, to which the status report message refers to.
    /// </summary>
    [IsoId("_g6BqZyNqEeKdIYatzYH-pQ")]
    [Description(@"Original group information concerning the group of transactions, to which the status report message refers to.")]
    [DataMember(Name="OrgnlGrpInfAndSts")]
    [XmlElement(ElementName="OrgnlGrpInfAndSts")]
    [Required]
    public required OriginalGroupInformation25 OriginalGroupInformationAndStatus { get; init; }
    
    /// <summary>
    /// Information concerning the original payment information, to which the status report message refers.
    /// </summary>
    [IsoId("_g6BqayNqEeKdIYatzYH-pQ")]
    [Description(@"Information concerning the original payment information, to which the status report message refers.")]
    [DataMember(Name="OrgnlPmtInfAndSts")]
    [XmlElement(ElementName="OrgnlPmtInfAndSts")]
    public OriginalPaymentInstruction9? OriginalPaymentInformationAndStatus { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_g6BqbyNqEeKdIYatzYH-pQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CreditorPaymentActivationRequestStatusReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CreditorPaymentActivationRequestStatusReportV03Document ToDocument()
    {
        return new CreditorPaymentActivationRequestStatusReportV03Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CdtrPmtActvtnReqStsRpt");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "GrpHdr", xmlNamespace );
        GroupHeader.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OrgnlGrpInfAndSts", xmlNamespace );
        OriginalGroupInformationAndStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OriginalPaymentInformationAndStatus is OriginalPaymentInstruction9 OriginalPaymentInformationAndStatusValue)
        {
            writer.WriteStartElement(null, "OrgnlPmtInfAndSts", xmlNamespace );
            OriginalPaymentInformationAndStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CreditorPaymentActivationRequestStatusReportV03 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CreditorPaymentActivationRequestStatusReportV03"/>.
/// </summary>
[Serializable]
public partial record CreditorPaymentActivationRequestStatusReportV03Document : IOuterDocument<CreditorPaymentActivationRequestStatusReportV03>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.014.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CreditorPaymentActivationRequestStatusReportV03"/> is required.
    /// </summary>
    [DataMember(Name=CreditorPaymentActivationRequestStatusReportV03.XmlTag)]
    public required CreditorPaymentActivationRequestStatusReportV03 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CreditorPaymentActivationRequestStatusReportV03.XmlTag);
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
