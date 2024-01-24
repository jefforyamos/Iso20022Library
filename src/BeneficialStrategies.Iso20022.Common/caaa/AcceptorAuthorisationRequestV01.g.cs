﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorAuthorisationRequestV01.  ISO2002 ID# _ghrzxaMVEeCJ6YNENx4h-w_1039526828.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// Scope
/// The AcceptorAuthorisationRequest message is sent by the card acceptor to the acquirer or its agent when an online authorisation is required for the card payment transaction.
/// Usage
/// The AcceptorAuthorisationRequest message may embed the information required for transferring to the acquirer the data needed to perform the financial settlement of the transaction (capture). An intermediary agent may act on behalf of the card acceptor or of the acquirer in providing additional functionality such as: switching to different acquirers, loyalty processing or management of the acceptor system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AcceptorAuthorisationRequest message is sent by the card acceptor to the acquirer or its agent when an online authorisation is required for the card payment transaction.|Usage|The AcceptorAuthorisationRequest message may embed the information required for transferring to the acquirer the data needed to perform the financial settlement of the transaction (capture). An intermediary agent may act on behalf of the card acceptor or of the acquirer in providing additional functionality such as: switching to different acquirers, loyalty processing or management of the acceptor system.")]
public partial record AcceptorAuthorisationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrAuthstnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Authorisation request message management information.
    /// </summary>
    [IsoId("_ghrzxqMVEeCJ6YNENx4h-w_1464733610")]
    [Description(@"Authorisation request message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the authorisation request.
    /// </summary>
    [IsoId("_ghrzx6MVEeCJ6YNENx4h-w_-2042121614")]
    [Description(@"Information related to the authorisation request.")]
    [DataMember(Name="AuthstnReq")]
    [XmlElement(ElementName="AuthstnReq")]
    [Required]
    public required SomeAuthorisationRequestRecord AuthorisationRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_ghrzyKMVEeCJ6YNENx4h-w_-1655113788")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required SomeSecurityTrailerRecord SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorAuthorisationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorAuthorisationRequestV01Document ToDocument()
    {
        return new AcceptorAuthorisationRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorAuthorisationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorAuthorisationRequestV01Document : IOuterDocument<AcceptorAuthorisationRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.001.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorAuthorisationRequestV01"/> is required.
    /// </summary>
    public required AcceptorAuthorisationRequestV01 Message { get; init; }
}
