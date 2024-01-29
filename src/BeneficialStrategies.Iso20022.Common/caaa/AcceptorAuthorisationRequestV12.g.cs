﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorAuthorisationRequestV12.  ISO2002 ID# _LuF5QHMGEe2vXY6MoVq19w.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorAuthorisationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check with the issuer (or its agent) that the account associated to the card has the resources to fund the payment. This checking will include validation of the card data and any additional transaction data provided.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorAuthorisationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check with the issuer (or its agent) that the account associated to the card has the resources to fund the payment. This checking will include validation of the card data and any additional transaction data provided.")]
public partial record AcceptorAuthorisationRequestV12 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrAuthstnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Authorisation request message management information.
    /// </summary>
    [IsoId("_LuF5RHMGEe2vXY6MoVq19w")]
    [Description(@"Authorisation request message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the authorisation request.
    /// </summary>
    [IsoId("_LuJjoXMGEe2vXY6MoVq19w")]
    [Description(@"Information related to the authorisation request.")]
    [DataMember(Name="AuthstnReq")]
    [XmlElement(ElementName="AuthstnReq")]
    [Required]
    public required SomeAuthorisationRequestRecord AuthorisationRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_LuJjo3MGEe2vXY6MoVq19w")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorAuthorisationRequestV12Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorAuthorisationRequestV12Document ToDocument()
    {
        return new AcceptorAuthorisationRequestV12Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorAuthorisationRequestV12"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorAuthorisationRequestV12Document : IOuterDocument<AcceptorAuthorisationRequestV12>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.001.001.12";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorAuthorisationRequestV12"/> is required.
    /// </summary>
    public required AcceptorAuthorisationRequestV12 Message { get; init; }
}