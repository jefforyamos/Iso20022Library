﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIReconciliationRequestV04.  ISO2002 ID# _YQhpYU6uEeyGi9JAv6wq7Q.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.casp;


/// <summary>
/// The SaleToPOIReconciliationRequest message is sent by a sale system to request for reconciliation between sale and POI systems.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SaleToPOIReconciliationRequest message is sent by a sale system to request for reconciliation between sale and POI systems.")]
public partial record SaleToPOIReconciliationRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIRcncltnReq";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_YQhpY06uEeyGi9JAv6wq7Q")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header41 Header { get; init; }
    
    /// <summary>
    /// Information related to the reconciliation request.
    /// </summary>
    [IsoId("_YQhpZU6uEeyGi9JAv6wq7Q")]
    [Description(@"Information related to the reconciliation request.")]
    [DataMember(Name="RcncltnReq")]
    [XmlElement(ElementName="RcncltnReq")]
    [Required]
    public required ReconciliationRequest5 ReconciliationRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_YQhpZ06uEeyGi9JAv6wq7Q")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType29? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIReconciliationRequestV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIReconciliationRequestV04Document ToDocument()
    {
        return new SaleToPOIReconciliationRequestV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOIReconciliationRequestV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIReconciliationRequestV04Document : IOuterDocument<SaleToPOIReconciliationRequestV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.003.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIReconciliationRequestV04"/> is required.
    /// </summary>
    public required SaleToPOIReconciliationRequestV04 Message { get; init; }
}
