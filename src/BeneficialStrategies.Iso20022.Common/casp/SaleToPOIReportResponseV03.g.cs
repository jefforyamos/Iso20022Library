﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIReportResponseV03.  ISO2002 ID# _oON8IS5LEeunNvJlR_vCbg.
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
/// This record is an implementation of the casp.010.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This SaleToPOIReportResponse message is sent by a POI to provide the report previously expected by a sale system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"This SaleToPOIReportResponse message is sent by a POI to provide the report previously expected by a sale system.")]
public partial record SaleToPOIReportResponseV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "casp.010.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIRptRspn";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_oON8Iy5LEeunNvJlR_vCbg")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header41 Header { get; init; }
    
    /// <summary>
    /// Information related to the response of a report request.
    /// </summary>
    [IsoId("_oON8JS5LEeunNvJlR_vCbg")]
    [Description(@"Information related to the response of a report request.")]
    [DataMember(Name="RptRspn")]
    [XmlElement(ElementName="RptRspn")]
    [Required]
    public required ReportResponse4 ReportResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_oON8Jy5LEeunNvJlR_vCbg")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType25? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIReportResponseV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIReportResponseV03Document ToDocument()
    {
        return new SaleToPOIReportResponseV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOIReportResponseV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIReportResponseV03Document : IOuterDocument<SaleToPOIReportResponseV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.010.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIReportResponseV03"/> is required.
    /// </summary>
    public required SaleToPOIReportResponseV03 Message { get; init; }
}
