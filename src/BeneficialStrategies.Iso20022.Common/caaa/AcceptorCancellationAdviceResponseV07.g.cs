﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCancellationAdviceResponseV07.  ISO2002 ID# _aS0Iods4Eee9e6xduATmQg.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorCancellationAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) about the notification of the payment cancellation.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorCancellationAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) about the notification of the payment cancellation.")]
public partial record AcceptorCancellationAdviceResponseV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCxlAdvcRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Cancellation advice response message management information.
    /// </summary>
    [IsoId("_aS0Ipds4Eee9e6xduATmQg")]
    [Description(@"Cancellation advice response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the cancellation advice response.
    /// </summary>
    [IsoId("_aS0Ip9s4Eee9e6xduATmQg")]
    [Description(@"Information related to the cancellation advice response.")]
    [DataMember(Name="CxlAdvcRspn")]
    [XmlElement(ElementName="CxlAdvcRspn")]
    [Required]
    public required SomeCancellationAdviceResponseRecord CancellationAdviceResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_aS0Iqds4Eee9e6xduATmQg")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCancellationAdviceResponseV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCancellationAdviceResponseV07Document ToDocument()
    {
        return new AcceptorCancellationAdviceResponseV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorCancellationAdviceResponseV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCancellationAdviceResponseV07Document : IOuterDocument<AcceptorCancellationAdviceResponseV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.008.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCancellationAdviceResponseV07"/> is required.
    /// </summary>
    public required AcceptorCancellationAdviceResponseV07 Message { get; init; }
}
