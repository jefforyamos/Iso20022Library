﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorAuthorisationResponseV10.  ISO2002 ID# _ECB-IS5IEeunNvJlR_vCbg.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorAuthorisationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to return the result of the validation made by issuer about the payment transaction.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorAuthorisationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to return the result of the validation made by issuer about the payment transaction.")]
public partial record AcceptorAuthorisationResponseV10 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrAuthstnRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Authorisation response message management information.
    /// </summary>
    [IsoId("_ECB-JS5IEeunNvJlR_vCbg")]
    [Description(@"Authorisation response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header59 Header { get; init; }
    
    /// <summary>
    /// Information related to the response of the authorisation.
    /// </summary>
    [IsoId("_ECB-Jy5IEeunNvJlR_vCbg")]
    [Description(@"Information related to the response of the authorisation.")]
    [DataMember(Name="AuthstnRspn")]
    [XmlElement(ElementName="AuthstnRspn")]
    [Required]
    public required AcceptorAuthorisationResponse10 AuthorisationResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_ECB-KS5IEeunNvJlR_vCbg")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType27? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorAuthorisationResponseV10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorAuthorisationResponseV10Document ToDocument()
    {
        return new AcceptorAuthorisationResponseV10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorAuthorisationResponseV10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorAuthorisationResponseV10Document : IOuterDocument<AcceptorAuthorisationResponseV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.002.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorAuthorisationResponseV10"/> is required.
    /// </summary>
    public required AcceptorAuthorisationResponseV10 Message { get; init; }
}
