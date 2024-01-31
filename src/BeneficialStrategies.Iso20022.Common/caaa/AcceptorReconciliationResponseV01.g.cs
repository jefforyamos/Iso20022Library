﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorReconciliationResponseV01.  ISO2002 ID# _OV5_1aMVEeCJ6YNENx4h-w_2086001955.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.caaa;


/// <summary>
/// This record is an implementation of the caaa.010.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorReconciliationResponse message is sent by the acquirer to communicate to the card acceptor the totals of the card payment transaction performed for the reconciliation period. An agent never forwards the message.
/// Usage
/// The AcceptorReconciliationResponse message is used to compare the totals between a card acceptor and an acquirer for the reconciliation period.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AcceptorReconciliationResponse message is sent by the acquirer to communicate to the card acceptor the totals of the card payment transaction performed for the reconciliation period. An agent never forwards the message.|Usage|The AcceptorReconciliationResponse message is used to compare the totals between a card acceptor and an acquirer for the reconciliation period.")]
public partial record AcceptorReconciliationResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.010.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrRcncltnRspn";
    
    #nullable enable
    /// <summary>
    /// Reconciliation response message management information.
    /// </summary>
    [IsoId("_OV5_1qMVEeCJ6YNENx4h-w_1779414946")]
    [Description(@"Reconciliation response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header1 Header { get; init; }
    
    /// <summary>
    /// Information related to thereconciliation response.
    /// </summary>
    [IsoId("_OV5_16MVEeCJ6YNENx4h-w_2117740989")]
    [Description(@"Information related to thereconciliation response.")]
    [DataMember(Name="RcncltnRspn")]
    [XmlElement(ElementName="RcncltnRspn")]
    [Required]
    public required AcceptorReconciliationResponse1 ReconciliationResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_OV5_2KMVEeCJ6YNENx4h-w_-1540723473")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required ContentInformationType3 SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorReconciliationResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorReconciliationResponseV01Document ToDocument()
    {
        return new AcceptorReconciliationResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorReconciliationResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorReconciliationResponseV01Document : IOuterDocument<AcceptorReconciliationResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.010.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorReconciliationResponseV01"/> is required.
    /// </summary>
    public required AcceptorReconciliationResponseV01 Message { get; init; }
}
