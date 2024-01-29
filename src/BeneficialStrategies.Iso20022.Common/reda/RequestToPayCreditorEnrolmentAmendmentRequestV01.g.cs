﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestToPayCreditorEnrolmentAmendmentRequestV01.  ISO2002 ID# _rNNBkeHzEeqbls7Gk4-ckA.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// The RequestToPayCreditorEnrolmentAmendmentRequest message is sent by the creditor RTP (Request To Pay) provider to an RTP directory provider and optionally by the creditor to a creditor RTP provider to request for the amendment of the creditor registration in the RTP directory. 
/// The message may also be forwarded to any authorised third party, as defined in the local scheme
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The RequestToPayCreditorEnrolmentAmendmentRequest message is sent by the creditor RTP (Request To Pay) provider to an RTP directory provider and optionally by the creditor to a creditor RTP provider to request for the amendment of the creditor registration in the RTP directory. |The message may also be forwarded to any authorised third party, as defined in the local scheme")]
public partial record RequestToPayCreditorEnrolmentAmendmentRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqToPayCdtrEnrlmntAmdmntReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the amendment of the creditor enrolment.
    /// </summary>
    [IsoId("_rNNBleHzEeqbls7Gk4-ckA")]
    [Description(@"Set of characteristics to identify the message and parties playing a role in the amendment of the creditor enrolment.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Provides further details on the creditor enrolment amendment request.
    /// </summary>
    [IsoId("_rNNBl-HzEeqbls7Gk4-ckA")]
    [Description(@"Provides further details on the creditor enrolment amendment request.")]
    [DataMember(Name="AmdmntData")]
    [XmlElement(ElementName="AmdmntData")]
    [Required]
    public required SomeAmendmentDataRecord AmendmentData { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rNNBmeHzEeqbls7Gk4-ckA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RequestToPayCreditorEnrolmentAmendmentRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestToPayCreditorEnrolmentAmendmentRequestV01Document ToDocument()
    {
        return new RequestToPayCreditorEnrolmentAmendmentRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RequestToPayCreditorEnrolmentAmendmentRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RequestToPayCreditorEnrolmentAmendmentRequestV01Document : IOuterDocument<RequestToPayCreditorEnrolmentAmendmentRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.067.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RequestToPayCreditorEnrolmentAmendmentRequestV01"/> is required.
    /// </summary>
    public required RequestToPayCreditorEnrolmentAmendmentRequestV01 Message { get; init; }
}