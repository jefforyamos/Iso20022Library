﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCompletionAdviceResponseV08.  ISO2002 ID# _46JYoQudEeqw5uEXxQ9H4g.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorCompletionAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) of the outcome of the payment transaction, and the transfer the financial data of the transaction contained in the completion advice.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorCompletionAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) of the outcome of the payment transaction, and the transfer the financial data of the transaction contained in the completion advice.")]
public partial record AcceptorCompletionAdviceResponseV08 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCmpltnAdvcRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Completion advice response message management information.
    /// </summary>
    [IsoId("_46JYpQudEeqw5uEXxQ9H4g")]
    [Description(@"Completion advice response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the completion advice response.
    /// </summary>
    [IsoId("_46JYpwudEeqw5uEXxQ9H4g")]
    [Description(@"Information related to the completion advice response.")]
    [DataMember(Name="CmpltnAdvcRspn")]
    [XmlElement(ElementName="CmpltnAdvcRspn")]
    [Required]
    public required SomeCompletionAdviceResponseRecord CompletionAdviceResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_46JYqQudEeqw5uEXxQ9H4g")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCompletionAdviceResponseV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCompletionAdviceResponseV08Document ToDocument()
    {
        return new AcceptorCompletionAdviceResponseV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorCompletionAdviceResponseV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCompletionAdviceResponseV08Document : IOuterDocument<AcceptorCompletionAdviceResponseV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.004.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCompletionAdviceResponseV08"/> is required.
    /// </summary>
    public required AcceptorCompletionAdviceResponseV08 Message { get; init; }
}
