﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CertificateManagementResponseV05.  ISO2002 ID# _Nwo8kVE_EeyApZmLzm74zA.
//
namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// The CertificateManagementResponse is sent by a terminal manager in response to a CertificateManagementRequest to provide the outcome of the requested service.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CertificateManagementResponse is sent by a terminal manager in response to a CertificateManagementRequest to provide the outcome of the requested service.")]
public partial record CertificateManagementResponseV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CertMgmtRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_Nwo8k1E_EeyApZmLzm74zA")]
    [Description(@"Information related to the protocol management.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required TMSHeader1 Header { get; init; }
    
    /// <summary>
    /// Information related to the result of the certificate management request.
    /// </summary>
    [IsoId("_Nwo8lVE_EeyApZmLzm74zA")]
    [Description(@"Information related to the result of the certificate management request.")]
    [DataMember(Name="CertMgmtRspn")]
    [XmlElement(ElementName="CertMgmtRspn")]
    [Required]
    public required CertificateManagementResponse2 CertificateManagementResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_Nwo8l1E_EeyApZmLzm74zA")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType29? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CertificateManagementResponseV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CertificateManagementResponseV05Document ToDocument()
    {
        return new CertificateManagementResponseV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CertificateManagementResponseV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CertificateManagementResponseV05Document : IOuterDocument<CertificateManagementResponseV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.008.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CertificateManagementResponseV05"/> is required.
    /// </summary>
    public required CertificateManagementResponseV05 Message { get; init; }
}
