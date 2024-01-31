﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIReportResponseV04.  ISO2002 ID# _wMaG8U0-Eeybj420QgWBkA.
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
/// This SaleToPOIReportResponse message is sent by a POI to provide the report previously expected by a sale system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"This SaleToPOIReportResponse message is sent by a POI to provide the report previously expected by a sale system.")]
public partial record SaleToPOIReportResponseV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIRptRspn";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_wMaG800-Eeybj420QgWBkA")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header41 Header { get; init; }
    
    /// <summary>
    /// Information related to the response of a report request.
    /// </summary>
    [IsoId("_wMaG9U0-Eeybj420QgWBkA")]
    [Description(@"Information related to the response of a report request.")]
    [DataMember(Name="RptRspn")]
    [XmlElement(ElementName="RptRspn")]
    [Required]
    public required ReportResponse5 ReportResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_wMaG900-Eeybj420QgWBkA")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType29? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIReportResponseV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIReportResponseV04Document ToDocument()
    {
        return new SaleToPOIReportResponseV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOIReportResponseV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIReportResponseV04Document : IOuterDocument<SaleToPOIReportResponseV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.010.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIReportResponseV04"/> is required.
    /// </summary>
    public required SaleToPOIReportResponseV04 Message { get; init; }
}
