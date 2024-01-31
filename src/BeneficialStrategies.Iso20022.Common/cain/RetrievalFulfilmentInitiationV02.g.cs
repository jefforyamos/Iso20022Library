﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RetrievalFulfilmentInitiationV02.  ISO2002 ID# _IFkt0YHTEeuwq_rv81SdXw.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.cain;


/// <summary>
/// This record is an implementation of the cain.014.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The RetrievaFulfilmentInitiation message is sent by an acquirer or agent to an issuer to support an issuer's retrieval request.
/// 
/// The RetrievaFulfilmentInitiation message is the activity initiated by the acceptor, the acquirer or the relevant agent to support the issuer who has determined that a transaction information document needs to be examined before a potential chargeback is sent or to satisfy another need of the issuer or the cardholder. Only an issuer or its agent can initiate a retrieval request.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The RetrievaFulfilmentInitiation message is sent by an acquirer or agent to an issuer to support an issuer's retrieval request.||The RetrievaFulfilmentInitiation message is the activity initiated by the acceptor, the acquirer or the relevant agent to support the issuer who has determined that a transaction information document needs to be examined before a potential chargeback is sent or to satisfy another need of the issuer or the cardholder. Only an issuer or its agent can initiate a retrieval request.")]
public partial record RetrievalFulfilmentInitiationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.014.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrvlFlfmtInitn";
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_IFkt04HTEeuwq_rv81SdXw")]
    [Description(@"Information related to the protocol management.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header66 Header { get; init; }
    
    /// <summary>
    /// Information related to the initiation of a retrieval fulfilment
    /// </summary>
    [IsoId("_IFkt1YHTEeuwq_rv81SdXw")]
    [Description(@"Information related to the initiation of a retrieval fulfilment")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required RetrievalFulfilmentInitiation2 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_IFkt14HTEeuwq_rv81SdXw")]
    [Description(@"Trailer of the message containing a MAC.|It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RetrievalFulfilmentInitiationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RetrievalFulfilmentInitiationV02Document ToDocument()
    {
        return new RetrievalFulfilmentInitiationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RetrievalFulfilmentInitiationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RetrievalFulfilmentInitiationV02Document : IOuterDocument<RetrievalFulfilmentInitiationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.014.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RetrievalFulfilmentInitiationV02"/> is required.
    /// </summary>
    public required RetrievalFulfilmentInitiationV02 Message { get; init; }
}
