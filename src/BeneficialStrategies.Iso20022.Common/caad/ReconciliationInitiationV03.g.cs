﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReconciliationInitiationV03.  ISO2002 ID# _--ZoIYv9EeuC5632vxUfGg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.caad;


/// <summary>
/// This record is an implementation of the caad.005.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ReconciliationInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer).
/// 
/// Reconciliation is the exchange between two interchanging parties (Acquirer, Issuer or Agent) of totals and/or counts of messages within a specific session.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ReconciliationInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer).||Reconciliation is the exchange between two interchanging parties (Acquirer, Issuer or Agent) of totals and/or counts of messages within a specific session.")]
public partial record ReconciliationInitiationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caad.005.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RcncltnInitn";
    
    #nullable enable
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_--ZoI4v9EeuC5632vxUfGg")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header60 Header { get; init; }
    
    /// <summary>
    /// Information related to the reconciliation.
    /// </summary>
    [IsoId("_--ZoJYv9EeuC5632vxUfGg")]
    [Description(@"Information related to the reconciliation.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required ReconciliationInitiation2 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_--ZoJ4v9EeuC5632vxUfGg")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReconciliationInitiationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReconciliationInitiationV03Document ToDocument()
    {
        return new ReconciliationInitiationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ReconciliationInitiationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReconciliationInitiationV03Document : IOuterDocument<ReconciliationInitiationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.005.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReconciliationInitiationV03"/> is required.
    /// </summary>
    public required ReconciliationInitiationV03 Message { get; init; }
}
