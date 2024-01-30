﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorAuthorisationRequestV04.  ISO2002 ID# _51NNAWedEeSh-d9-KfCEyA.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorAuthorisationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check with the issuer (or its agent) that the account associated to the card has the resources to fund the payment. This checking will include validation of the card data and any additional transaction data provided.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorAuthorisationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check with the issuer (or its agent) that the account associated to the card has the resources to fund the payment. This checking will include validation of the card data and any additional transaction data provided.")]
public partial record AcceptorAuthorisationRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrAuthstnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Authorisation request message management information.
    /// </summary>
    [IsoId("_51NNBWedEeSh-d9-KfCEyA")]
    [Description(@"Authorisation request message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header10 Header { get; init; }
    
    /// <summary>
    /// Information related to the authorisation request.
    /// </summary>
    [IsoId("_51NNB2edEeSh-d9-KfCEyA")]
    [Description(@"Information related to the authorisation request.")]
    [DataMember(Name="AuthstnReq")]
    [XmlElement(ElementName="AuthstnReq")]
    [Required]
    public required AcceptorAuthorisationRequest4 AuthorisationRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_51NNCWedEeSh-d9-KfCEyA")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required ContentInformationType11 SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorAuthorisationRequestV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorAuthorisationRequestV04Document ToDocument()
    {
        return new AcceptorAuthorisationRequestV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorAuthorisationRequestV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorAuthorisationRequestV04Document : IOuterDocument<AcceptorAuthorisationRequestV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.001.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorAuthorisationRequestV04"/> is required.
    /// </summary>
    public required AcceptorAuthorisationRequestV04 Message { get; init; }
}
