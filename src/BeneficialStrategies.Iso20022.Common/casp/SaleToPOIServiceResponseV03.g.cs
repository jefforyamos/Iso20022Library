﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIServiceResponseV03.  ISO2002 ID# _7itroS5LEeunNvJlR_vCbg.
//
namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// The SaleToPOIServiceResponse message is sent by a POI to provide the outcome of a financial service.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SaleToPOIServiceResponse message is sent by a POI to provide the outcome of a financial service.")]
public partial record SaleToPOIServiceResponseV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOISvcRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics related to the transfer of the response.
    /// </summary>
    [IsoId("_7itroy5LEeunNvJlR_vCbg")]
    [Description(@"Set of characteristics related to the transfer of the response.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the response of a service request.
    /// </summary>
    [IsoId("_7itrpS5LEeunNvJlR_vCbg")]
    [Description(@"Information related to the response of a service request.")]
    [DataMember(Name="SvcRspn")]
    [XmlElement(ElementName="SvcRspn")]
    [Required]
    public required SomeServiceResponseRecord ServiceResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_7itrpy5LEeunNvJlR_vCbg")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIServiceResponseV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIServiceResponseV03Document ToDocument()
    {
        return new SaleToPOIServiceResponseV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOIServiceResponseV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIServiceResponseV03Document : IOuterDocument<SaleToPOIServiceResponseV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.002.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIServiceResponseV03"/> is required.
    /// </summary>
    public required SaleToPOIServiceResponseV03 Message { get; init; }
}
