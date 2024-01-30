﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIReportRequestV03.  ISO2002 ID# _kfKQcS5LEeunNvJlR_vCbg.
//
namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// The SaleToPOIReportRequest message is sent by sale system to request a report service.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SaleToPOIReportRequest message is sent by sale system to request a report service.")]
public partial record SaleToPOIReportRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIRptReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_kfKQcy5LEeunNvJlR_vCbg")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header41 Header { get; init; }
    
    /// <summary>
    /// Information related to the report request.
    /// </summary>
    [IsoId("_kfKQdS5LEeunNvJlR_vCbg")]
    [Description(@"Information related to the report request.")]
    [DataMember(Name="RptReq")]
    [XmlElement(ElementName="RptReq")]
    [Required]
    public required ReportRequest4 ReportRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_kfKQdy5LEeunNvJlR_vCbg")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType25? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIReportRequestV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIReportRequestV03Document ToDocument()
    {
        return new SaleToPOIReportRequestV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOIReportRequestV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIReportRequestV03Document : IOuterDocument<SaleToPOIReportRequestV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.009.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIReportRequestV03"/> is required.
    /// </summary>
    public required SaleToPOIReportRequestV03 Message { get; init; }
}
