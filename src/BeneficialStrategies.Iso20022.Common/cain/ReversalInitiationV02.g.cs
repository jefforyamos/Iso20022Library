﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReversalInitiationV02.  ISO2002 ID# _ctEcNVT_EeetiruPyDPo0Q.
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
/// This record is an implementation of the cain.005.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ReversalInitiation message is sent by an acquirer, an originator or an agent to an issuer to request or advise of the reversal of an authorisation by the issuer. A reversal is a partial or complete nullification of the effects of a previous authorisation, financial presentment or financial accumulation presentment that cannot be processed as instructed (for example, is undeliverable and cancelled or the acquirer timed out waiting for a response).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ReversalInitiation message is sent by an acquirer, an originator or an agent to an issuer to request or advise of the reversal of an authorisation by the issuer. A reversal is a partial or complete nullification of the effects of a previous authorisation, financial presentment or financial accumulation presentment that cannot be processed as instructed (for example, is undeliverable and cancelled or the acquirer timed out waiting for a response).")]
public partial record ReversalInitiationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.005.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslInitn";
    
    #nullable enable
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_ctEcNlT_EeetiruPyDPo0Q")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header42 Header { get; init; }
    
    /// <summary>
    /// Information related to the reversal of an authorisation or financial transaction.
    /// </summary>
    [IsoId("_ctEcOVT_EeetiruPyDPo0Q")]
    [Description(@"Information related to the reversal of an authorisation or financial transaction.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required ReversalInitiation1 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_ctEcN1T_EeetiruPyDPo0Q")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReversalInitiationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReversalInitiationV02Document ToDocument()
    {
        return new ReversalInitiationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ReversalInitiationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReversalInitiationV02Document : IOuterDocument<ReversalInitiationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.005.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReversalInitiationV02"/> is required.
    /// </summary>
    public required ReversalInitiationV02 Message { get; init; }
}
