﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIAdministrativeResponseV03.  ISO2002 ID# _Q2QMoS5KEeunNvJlR_vCbg.
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
/// The SaleToPOIAdministrativeResponse message is sent by a POI System to a sale system to provide response to an administrative service.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SaleToPOIAdministrativeResponse message is sent by a POI System to a sale system to provide response to an administrative service.")]
public partial record SaleToPOIAdministrativeResponseV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIAdmstvRspn";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_Q2QMoy5KEeunNvJlR_vCbg")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header41 Header { get; init; }
    
    /// <summary>
    /// Information related to the response of an administrative request.
    /// </summary>
    [IsoId("_Q2QMpS5KEeunNvJlR_vCbg")]
    [Description(@"Information related to the response of an administrative request.")]
    [DataMember(Name="AdmstvRspn")]
    [XmlElement(ElementName="AdmstvRspn")]
    [Required]
    public required AdministrativeResponse4 AdministrativeResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_Q2QMpy5KEeunNvJlR_vCbg")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType25? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIAdministrativeResponseV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIAdministrativeResponseV03Document ToDocument()
    {
        return new SaleToPOIAdministrativeResponseV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOIAdministrativeResponseV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIAdministrativeResponseV03Document : IOuterDocument<SaleToPOIAdministrativeResponseV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.008.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIAdministrativeResponseV03"/> is required.
    /// </summary>
    public required SaleToPOIAdministrativeResponseV03 Message { get; init; }
}
