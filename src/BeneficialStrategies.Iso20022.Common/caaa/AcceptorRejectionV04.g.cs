﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorRejectionV04.  ISO2002 ID# _Bu3IsWpCEeS4VPLpYyQgxQ.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorRejection message is sent by the acquirer (or its agent) to reject a message request or advice sent by an acceptor (or its agent), to indicate that the received message could not be processed.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorRejection message is sent by the acquirer (or its agent) to reject a message request or advice sent by an acceptor (or its agent), to indicate that the received message could not be processed.")]
public partial record AcceptorRejectionV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrRjctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Rejection message management information.
    /// </summary>
    [IsoId("_Bu3ItWpCEeS4VPLpYyQgxQ")]
    [Description(@"Rejection message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header13 Header { get; init; }
    
    /// <summary>
    /// Information related to the reject.
    /// </summary>
    [IsoId("_Bu3It2pCEeS4VPLpYyQgxQ")]
    [Description(@"Information related to the reject.")]
    [DataMember(Name="Rjct")]
    [XmlElement(ElementName="Rjct")]
    [Required]
    public required AcceptorRejection2 Reject { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorRejectionV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorRejectionV04Document ToDocument()
    {
        return new AcceptorRejectionV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorRejectionV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorRejectionV04Document : IOuterDocument<AcceptorRejectionV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.015.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorRejectionV04"/> is required.
    /// </summary>
    public required AcceptorRejectionV04 Message { get; init; }
}
