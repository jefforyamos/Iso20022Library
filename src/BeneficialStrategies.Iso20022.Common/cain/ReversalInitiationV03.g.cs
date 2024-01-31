﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReversalInitiationV03.  ISO2002 ID# _U0x9oYHOEeuwq_rv81SdXw.
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
/// This record is an implementation of the cain.005.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ReversalInitiation message is sent by an acquirer, an originator or an agent to an issuer to request or advise of the reversal of an authorisation by the issuer. A reversal is a partial or complete nullification of the effects of a previous authorisation, financial presentment or financial accumulation presentment that cannot be processed as instructed (for example, is undeliverable and cancelled or the acquirer timed out waiting for a response).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ReversalInitiation message is sent by an acquirer, an originator or an agent to an issuer to request or advise of the reversal of an authorisation by the issuer. A reversal is a partial or complete nullification of the effects of a previous authorisation, financial presentment or financial accumulation presentment that cannot be processed as instructed (for example, is undeliverable and cancelled or the acquirer timed out waiting for a response).")]
public partial record ReversalInitiationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.005.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslInitn";
    
    #nullable enable
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_U0yksYHOEeuwq_rv81SdXw")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header62 Header { get; init; }
    
    /// <summary>
    /// Information related to the reversal of an authorisation or financial transaction.
    /// </summary>
    [IsoId("_U0yks4HOEeuwq_rv81SdXw")]
    [Description(@"Information related to the reversal of an authorisation or financial transaction.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required ReversalInitiation2 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_U0yktYHOEeuwq_rv81SdXw")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReversalInitiationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReversalInitiationV03Document ToDocument()
    {
        return new ReversalInitiationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ReversalInitiationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReversalInitiationV03Document : IOuterDocument<ReversalInitiationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.005.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReversalInitiationV03"/> is required.
    /// </summary>
    public required ReversalInitiationV03 Message { get; init; }
}
