﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIServiceRequestV04.  ISO2002 ID# _n5ruoU31Eey_VecAUE-C9Q.
//
namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// This SaleToPOIServiceRequest message is sent by a sale system to trig a financial service on POI system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"This SaleToPOIServiceRequest message is sent by a sale system to trig a financial service on POI system.")]
public partial record SaleToPOIServiceRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOISvcReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_n5ruo031Eey_VecAUE-C9Q")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to a service request.
    /// </summary>
    [IsoId("_n5rupU31Eey_VecAUE-C9Q")]
    [Description(@"Information related to a service request.")]
    [DataMember(Name="SvcReq")]
    [XmlElement(ElementName="SvcReq")]
    [Required]
    public required SomeServiceRequestRecord ServiceRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_n5rup031Eey_VecAUE-C9Q")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIServiceRequestV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIServiceRequestV04Document ToDocument()
    {
        return new SaleToPOIServiceRequestV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOIServiceRequestV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIServiceRequestV04Document : IOuterDocument<SaleToPOIServiceRequestV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.001.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIServiceRequestV04"/> is required.
    /// </summary>
    public required SaleToPOIServiceRequestV04 Message { get; init; }
}