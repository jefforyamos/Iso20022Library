﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIAdministrativeRequestV02.  ISO2002 ID# _kjvmoQ1SEeqjM-rxn3HuXQ.
//
namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// The SaleToPOIAdministrativeRequest message is sent by a sale system to POI System to request for an Administrative service.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SaleToPOIAdministrativeRequest message is sent by a sale system to POI System to request for an Administrative service.")]
public partial record SaleToPOIAdministrativeRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIAdmstvReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_kjvmow1SEeqjM-rxn3HuXQ")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header41 Header { get; init; }
    
    /// <summary>
    /// Information related to the administrative request.
    /// </summary>
    [IsoId("_kjvmpQ1SEeqjM-rxn3HuXQ")]
    [Description(@"Information related to the administrative request.")]
    [DataMember(Name="AdmstvReq")]
    [XmlElement(ElementName="AdmstvReq")]
    [Required]
    public required AdministrativeRequest3 AdministrativeRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_kjvmpw1SEeqjM-rxn3HuXQ")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType21? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIAdministrativeRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIAdministrativeRequestV02Document ToDocument()
    {
        return new SaleToPOIAdministrativeRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOIAdministrativeRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIAdministrativeRequestV02Document : IOuterDocument<SaleToPOIAdministrativeRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.007.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIAdministrativeRequestV02"/> is required.
    /// </summary>
    public required SaleToPOIAdministrativeRequestV02 Message { get; init; }
}
