﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOISessionManagementResponseV05.  ISO2002 ID# _2hkSEXO-Ee2pK6udhxEaHA.
//
namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// The SaleToPOISessionManagementResponse message is sent by a POI to provide the result of an administrative service related to session management.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SaleToPOISessionManagementResponse message is sent by a POI to provide the result of an administrative service related to session management.")]
public partial record SaleToPOISessionManagementResponseV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOISsnMgmtRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_2hk5IXO-Ee2pK6udhxEaHA")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the response of a session management request.
    /// </summary>
    [IsoId("_2hlgMXO-Ee2pK6udhxEaHA")]
    [Description(@"Information related to the response of a session management request.")]
    [DataMember(Name="SsnMgmtRspn")]
    [XmlElement(ElementName="SsnMgmtRspn")]
    [Required]
    public required SomeSessionManagementResponseRecord SessionManagementResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_2hlgM3O-Ee2pK6udhxEaHA")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOISessionManagementResponseV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOISessionManagementResponseV05Document ToDocument()
    {
        return new SaleToPOISessionManagementResponseV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOISessionManagementResponseV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOISessionManagementResponseV05Document : IOuterDocument<SaleToPOISessionManagementResponseV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOISessionManagementResponseV05"/> is required.
    /// </summary>
    public required SaleToPOISessionManagementResponseV05 Message { get; init; }
}
