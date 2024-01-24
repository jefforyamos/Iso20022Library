﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCompletionAdviceResponseV07.  ISO2002 ID# _ULdRgdnHEeeN3v2fup_Shw.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorCompletionAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) of the outcome of the payment transaction, and the transfer the financial data of the transaction contained in the completion advice.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorCompletionAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) of the outcome of the payment transaction, and the transfer the financial data of the transaction contained in the completion advice.")]
public partial record AcceptorCompletionAdviceResponseV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCmpltnAdvcRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCompletionAdviceResponseV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCompletionAdviceResponseV07Document ToDocument()
    {
        return new AcceptorCompletionAdviceResponseV07Document { Message = this };
    }
}

/// <summary>
/// The AcceptorCompletionAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) of the outcome of the payment transaction, and the transfer the financial data of the transaction contained in the completion advice.
/// This is the outer document that contains <seealso cref="AcceptorCompletionAdviceResponseV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCompletionAdviceResponseV07Document : IOuterDocument<AcceptorCompletionAdviceResponseV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.004.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCompletionAdviceResponseV07"/> is required.
    /// </summary>
    public required AcceptorCompletionAdviceResponseV07 Message { get; init; }
}
