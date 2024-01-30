﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestToPayCreditorEnrolmentStatusReportV01.  ISO2002 ID# _rNNBr-HzEeqbls7Gk4-ckA.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// The RequestToPayCreditorEnrolmentStatusReport message is sent from the RTP (Request To Pay) directory provider to the creditor RTP provider and optionally from the creditor RTP provider to the creditor or any of the forwarding agent to provide the status of the initial creation, amendment or cancellation request.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The RequestToPayCreditorEnrolmentStatusReport message is sent from the RTP (Request To Pay) directory provider to the creditor RTP provider and optionally from the creditor RTP provider to the creditor or any of the forwarding agent to provide the status of the initial creation, amendment or cancellation request.")]
public partial record RequestToPayCreditorEnrolmentStatusReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqToPayCdtrEnrlmntStsRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the status report of the creditor enrolment.
    /// </summary>
    [IsoId("_rNNBs-HzEeqbls7Gk4-ckA")]
    [Description(@"Set of characteristics to identify the message and parties playing a role in the status report of the creditor enrolment.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required EnrolmentHeader2 Header { get; init; }
    
    /// <summary>
    /// Status of the creditor enrolment instruction (that is request, amendment or cancellation).
    /// </summary>
    [IsoId("_rNNBteHzEeqbls7Gk4-ckA")]
    [Description(@"Status of the creditor enrolment instruction (that is request, amendment or cancellation).")]
    [DataMember(Name="OrgnlEnrlmntAndSts")]
    [XmlElement(ElementName="OrgnlEnrlmntAndSts")]
    [Required]
    public required EnrolmentStatus2 OriginalEnrolmentAndStatus { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rNNBt-HzEeqbls7Gk4-ckA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RequestToPayCreditorEnrolmentStatusReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestToPayCreditorEnrolmentStatusReportV01Document ToDocument()
    {
        return new RequestToPayCreditorEnrolmentStatusReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RequestToPayCreditorEnrolmentStatusReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RequestToPayCreditorEnrolmentStatusReportV01Document : IOuterDocument<RequestToPayCreditorEnrolmentStatusReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.069.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RequestToPayCreditorEnrolmentStatusReportV01"/> is required.
    /// </summary>
    public required RequestToPayCreditorEnrolmentStatusReportV01 Message { get; init; }
}
