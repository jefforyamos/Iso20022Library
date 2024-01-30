﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AuthorisationInitiationV02.  ISO2002 ID# _SBa-kFKeEeeFcfYfFkVztg.
//
namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// AuthorisationInitiation message is sent by an acquirer or an agent to an issuer to request approval of a card transaction by the issuer or to inform the issuer about the completion of the authorisation. It can also be sent by an issuer to an acquirer or agent to advise about the result of an authorisation already performed.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"AuthorisationInitiation message is sent by an acquirer or an agent to an issuer to request approval of a card transaction by the issuer or to inform the issuer about the completion of the authorisation. It can also be sent by an issuer to an acquirer or agent to advise about the result of an authorisation already performed.||")]
public partial record AuthorisationInitiationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AuthstnInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_BfrOEFKfEeeFcfYfFkVztg")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header42 Header { get; init; }
    
    /// <summary>
    /// Information related to the authorisation initiation.
    /// </summary>
    [IsoId("_RkTIQFKfEeeFcfYfFkVztg")]
    [Description(@"Information related to the authorisation initiation.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required AuthorisationInitiation1 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_e333IFKfEeeFcfYfFkVztg")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AuthorisationInitiationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AuthorisationInitiationV02Document ToDocument()
    {
        return new AuthorisationInitiationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AuthorisationInitiationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AuthorisationInitiationV02Document : IOuterDocument<AuthorisationInitiationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.001.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AuthorisationInitiationV02"/> is required.
    /// </summary>
    public required AuthorisationInitiationV02 Message { get; init; }
}
