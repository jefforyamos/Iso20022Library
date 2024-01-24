﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RetrievalFulfilmentInitiationV01.  ISO2002 ID# _I-6FQeE1EeeV6-yubHrZaQ.
//
namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// The RetrievaFulfilmentInitiation message is sent by an acquirer or agent to an issuer to support an issuer's retrieval request.
/// The RetrievaFulfilmentInitiation message is the activity initiated by the acceptor, the acquirer or the relevant agent to support the issuer who has determined that a transaction information document needs to be examined before a potential chargeback is sent or to satisfy another need of the issuer or the cardholder. Only an issuer or its agent can initiate a retrieval request.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The RetrievaFulfilmentInitiation message is sent by an acquirer or agent to an issuer to support an issuer's retrieval request.||The RetrievaFulfilmentInitiation message is the activity initiated by the acceptor, the acquirer or the relevant agent to support the issuer who has determined that a transaction information document needs to be examined before a potential chargeback is sent or to satisfy another need of the issuer or the cardholder. Only an issuer or its agent can initiate a retrieval request.")]
public partial record RetrievalFulfilmentInitiationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrvlFlfmtInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RetrievalFulfilmentInitiationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RetrievalFulfilmentInitiationV01Document ToDocument()
    {
        return new RetrievalFulfilmentInitiationV01Document { Message = this };
    }
}

/// <summary>
/// The RetrievaFulfilmentInitiation message is sent by an acquirer or agent to an issuer to support an issuer's retrieval request.
/// The RetrievaFulfilmentInitiation message is the activity initiated by the acceptor, the acquirer or the relevant agent to support the issuer who has determined that a transaction information document needs to be examined before a potential chargeback is sent or to satisfy another need of the issuer or the cardholder. Only an issuer or its agent can initiate a retrieval request.
/// This is the outer document that contains <seealso cref="RetrievalFulfilmentInitiationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RetrievalFulfilmentInitiationV01Document : IOuterDocument<RetrievalFulfilmentInitiationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.014.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RetrievalFulfilmentInitiationV01"/> is required.
    /// </summary>
    public required RetrievalFulfilmentInitiationV01 Message { get; init; }
}
