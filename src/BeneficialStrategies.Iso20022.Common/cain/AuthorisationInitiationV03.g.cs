﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AuthorisationInitiationV03.  ISO2002 ID# _eVcboYEKEeu6D49Gi-ZPwQ.
//
namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// AuthorisationInitiation message is sent by an acquirer or an agent to an issuer to request approval of a card transaction by the issuer or to inform the issuer about the completion of the authorisation. It can also be sent by an issuer to an acquirer or agent to advise about the result of an authorisation already performed.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"AuthorisationInitiation message is sent by an acquirer or an agent to an issuer to request approval of a card transaction by the issuer or to inform the issuer about the completion of the authorisation. It can also be sent by an issuer to an acquirer or agent to advise about the result of an authorisation already performed.||")]
public partial record AuthorisationInitiationV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AuthstnInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AuthorisationInitiationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AuthorisationInitiationV03Document ToDocument()
    {
        return new AuthorisationInitiationV03Document { Message = this };
    }
}

/// <summary>
/// AuthorisationInitiation message is sent by an acquirer or an agent to an issuer to request approval of a card transaction by the issuer or to inform the issuer about the completion of the authorisation. It can also be sent by an issuer to an acquirer or agent to advise about the result of an authorisation already performed.
/// This is the outer document that contains <seealso cref="AuthorisationInitiationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AuthorisationInitiationV03Document : IOuterDocument<AuthorisationInitiationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.001.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AuthorisationInitiationV03"/> is required.
    /// </summary>
    public required AuthorisationInitiationV03 Message { get; init; }
}
