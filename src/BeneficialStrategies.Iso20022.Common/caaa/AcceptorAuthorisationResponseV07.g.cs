﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorAuthorisationResponseV07.  ISO2002 ID# _8KyGwdnGEeeN3v2fup_Shw.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorAuthorisationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to return the result of the validation made by issuer about the payment transaction.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorAuthorisationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to return the result of the validation made by issuer about the payment transaction.")]
public partial record AcceptorAuthorisationResponseV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrAuthstnRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Authorisation response message management information.
    /// </summary>
    [IsoId("_8Kyt09nGEeeN3v2fup_Shw")]
    [Description(@"Authorisation response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header35 Header { get; init; }
    
    /// <summary>
    /// Information related to the response of the authorisation.
    /// </summary>
    [IsoId("_8Kyt1dnGEeeN3v2fup_Shw")]
    [Description(@"Information related to the response of the authorisation.")]
    [DataMember(Name="AuthstnRspn")]
    [XmlElement(ElementName="AuthstnRspn")]
    [Required]
    public required AcceptorAuthorisationResponse7 AuthorisationResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_8Kyt19nGEeeN3v2fup_Shw")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType16? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorAuthorisationResponseV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorAuthorisationResponseV07Document ToDocument()
    {
        return new AcceptorAuthorisationResponseV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorAuthorisationResponseV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorAuthorisationResponseV07Document : IOuterDocument<AcceptorAuthorisationResponseV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.002.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorAuthorisationResponseV07"/> is required.
    /// </summary>
    public required AcceptorAuthorisationResponseV07 Message { get; init; }
}
