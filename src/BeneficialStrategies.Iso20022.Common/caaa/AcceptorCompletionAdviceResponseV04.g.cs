﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCompletionAdviceResponseV04.  ISO2002 ID# _26bowWlwEeSGkpGpjm7tzg.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorCompletionAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) of the outcome of the payment transaction, and the transfer the financial data of the transaction contained in the completion advice.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorCompletionAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) of the outcome of the payment transaction, and the transfer the financial data of the transaction contained in the completion advice.")]
public partial record AcceptorCompletionAdviceResponseV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCmpltnAdvcRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Completion advice response message management information.
    /// </summary>
    [IsoId("_26boxWlwEeSGkpGpjm7tzg")]
    [Description(@"Completion advice response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the completion advice response.
    /// </summary>
    [IsoId("_26box2lwEeSGkpGpjm7tzg")]
    [Description(@"Information related to the completion advice response.")]
    [DataMember(Name="CmpltnAdvcRspn")]
    [XmlElement(ElementName="CmpltnAdvcRspn")]
    [Required]
    public required SomeCompletionAdviceResponseRecord CompletionAdviceResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_26boyWlwEeSGkpGpjm7tzg")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required SomeSecurityTrailerRecord SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCompletionAdviceResponseV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCompletionAdviceResponseV04Document ToDocument()
    {
        return new AcceptorCompletionAdviceResponseV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorCompletionAdviceResponseV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCompletionAdviceResponseV04Document : IOuterDocument<AcceptorCompletionAdviceResponseV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.004.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCompletionAdviceResponseV04"/> is required.
    /// </summary>
    public required AcceptorCompletionAdviceResponseV04 Message { get; init; }
}
