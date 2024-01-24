﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCancellationResponseV05.  ISO2002 ID# _7WKrYY1DEeWsypzzYao74A.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorCancellationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to return the outcome of the cancellation request. If the response is positive, the acquirer has voided the financial data from the captured transaction.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorCancellationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to return the outcome of the cancellation request. If the response is positive, the acquirer has voided the financial data from the captured transaction.")]
public partial record AcceptorCancellationResponseV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCxlRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCancellationResponseV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCancellationResponseV05Document ToDocument()
    {
        return new AcceptorCancellationResponseV05Document { Message = this };
    }
}

/// <summary>
/// The AcceptorCancellationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to return the outcome of the cancellation request. If the response is positive, the acquirer has voided the financial data from the captured transaction.
/// This is the outer document that contains <seealso cref="AcceptorCancellationResponseV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCancellationResponseV05Document : IOuterDocument<AcceptorCancellationResponseV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.006.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCancellationResponseV05"/> is required.
    /// </summary>
    public required AcceptorCancellationResponseV05 Message { get; init; }
}
