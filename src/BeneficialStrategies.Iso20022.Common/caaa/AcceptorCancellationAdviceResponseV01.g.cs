﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCancellationAdviceResponseV01.  ISO2002 ID# _dy5SQqMVEeCJ6YNENx4h-w_-1253418701.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// Scope
/// The AcceptorCancellationAdviceResponse message is sent by the acquirer to acknowledge the proper reception of the AcceptorCancellationAdvice. The message can be sent directly to the card acceptor or through an agent.
/// Usage
/// The AcceptorCancellationAdviceResponse message should be accepted by the card acceptor unless the message received was invalid.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AcceptorCancellationAdviceResponse message is sent by the acquirer to acknowledge the proper reception of the AcceptorCancellationAdvice. The message can be sent directly to the card acceptor or through an agent.|Usage|The AcceptorCancellationAdviceResponse message should be accepted by the card acceptor unless the message received was invalid.")]
public partial record AcceptorCancellationAdviceResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCxlAdvcRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Cancellation advice response message management information.
    /// </summary>
    [IsoId("_dy5SQ6MVEeCJ6YNENx4h-w_-1226388965")]
    [Description(@"Cancellation advice response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header2 Header { get; init; }
    
    /// <summary>
    /// Information related to the cancellation advice response.
    /// </summary>
    [IsoId("_dy5SRKMVEeCJ6YNENx4h-w_-1962834050")]
    [Description(@"Information related to the cancellation advice response.")]
    [DataMember(Name="AccptrCxlAdvcRspn")]
    [XmlElement(ElementName="AccptrCxlAdvcRspn")]
    [Required]
    public required AcceptorCancellationAdviceResponse1 AcceptorCancellationAdviceResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_dy5SRaMVEeCJ6YNENx4h-w_1091066003")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required ContentInformationType3 SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCancellationAdviceResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCancellationAdviceResponseV01Document ToDocument()
    {
        return new AcceptorCancellationAdviceResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorCancellationAdviceResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCancellationAdviceResponseV01Document : IOuterDocument<AcceptorCancellationAdviceResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.008.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCancellationAdviceResponseV01"/> is required.
    /// </summary>
    public required AcceptorCancellationAdviceResponseV01 Message { get; init; }
}
