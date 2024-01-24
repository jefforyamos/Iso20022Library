﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIDeviceResponseV04.  ISO2002 ID# _8NC34U6qEeyGi9JAv6wq7Q.
//
namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// The SaleToPOIDeviceResponse message is sent by a POI System to sale system to provide result of a device request.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SaleToPOIDeviceResponse message is sent by a POI System to sale system to provide result of a device request.")]
public partial record SaleToPOIDeviceResponseV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIDvcRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_8NC3406qEeyGi9JAv6wq7Q")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the response of a device request.
    /// </summary>
    [IsoId("_8NC35U6qEeyGi9JAv6wq7Q")]
    [Description(@"Information related to the response of a device request.")]
    [DataMember(Name="DvcRspn")]
    [XmlElement(ElementName="DvcRspn")]
    [Required]
    public required SomeDeviceResponseRecord DeviceResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_8NC3506qEeyGi9JAv6wq7Q")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIDeviceResponseV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIDeviceResponseV04Document ToDocument()
    {
        return new SaleToPOIDeviceResponseV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOIDeviceResponseV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIDeviceResponseV04Document : IOuterDocument<SaleToPOIDeviceResponseV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.017.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIDeviceResponseV04"/> is required.
    /// </summary>
    public required SaleToPOIDeviceResponseV04 Message { get; init; }
}
