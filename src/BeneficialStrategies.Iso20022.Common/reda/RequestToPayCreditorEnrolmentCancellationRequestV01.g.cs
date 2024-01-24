﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestToPayCreditorEnrolmentCancellationRequestV01.  ISO2002 ID# _rNNBm-HzEeqbls7Gk4-ckA.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// The RequestToPayCreditorEnrolmentCancellationRequest message is sent by the creditor RTP (Request To Pay) provider to an RTP directory provider and optionally by the creditor to a creditor RTP provider to request for the cancellation of the creditor registration in the RTP directory. 
/// The message may also be forwarded to any authorised third party, as defined in the local scheme
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The RequestToPayCreditorEnrolmentCancellationRequest message is sent by the creditor RTP (Request To Pay) provider to an RTP directory provider and optionally by the creditor to a creditor RTP provider to request for the cancellation of the creditor registration in the RTP directory. |The message may also be forwarded to any authorised third party, as defined in the local scheme")]
public partial record RequestToPayCreditorEnrolmentCancellationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqToPayCdtrEnrlmntCxlReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RequestToPayCreditorEnrolmentCancellationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestToPayCreditorEnrolmentCancellationRequestV01Document ToDocument()
    {
        return new RequestToPayCreditorEnrolmentCancellationRequestV01Document { Message = this };
    }
}

/// <summary>
/// The RequestToPayCreditorEnrolmentCancellationRequest message is sent by the creditor RTP (Request To Pay) provider to an RTP directory provider and optionally by the creditor to a creditor RTP provider to request for the cancellation of the creditor registration in the RTP directory. 
/// The message may also be forwarded to any authorised third party, as defined in the local scheme
/// This is the outer document that contains <seealso cref="RequestToPayCreditorEnrolmentCancellationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RequestToPayCreditorEnrolmentCancellationRequestV01Document : IOuterDocument<RequestToPayCreditorEnrolmentCancellationRequestV01>
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
    public required RequestToPayCreditorEnrolmentCancellationRequestV01 Message { get; init; }
}
