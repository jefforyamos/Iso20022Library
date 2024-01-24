﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorRejectionV03.  ISO2002 ID# _cMIJETTgEeO5e9wx3yvd8g.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorRejection message is sent by the acquirer (or its agent) to reject a message request or advice sent by an acceptor (or its agent), to indicate that the received message could not be processed.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorRejection message is sent by the acquirer (or its agent) to reject a message request or advice sent by an acceptor (or its agent), to indicate that the received message could not be processed.")]
public partial record AcceptorRejectionV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrRjctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorRejectionV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorRejectionV03Document ToDocument()
    {
        return new AcceptorRejectionV03Document { Message = this };
    }
}

/// <summary>
/// The AcceptorRejection message is sent by the acquirer (or its agent) to reject a message request or advice sent by an acceptor (or its agent), to indicate that the received message could not be processed.
/// This is the outer document that contains <seealso cref="AcceptorRejectionV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorRejectionV03Document : IOuterDocument<AcceptorRejectionV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.015.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorRejectionV03"/> is required.
    /// </summary>
    public required AcceptorRejectionV03 Message { get; init; }
}
