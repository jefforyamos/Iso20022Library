﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MaintenanceDelegationRequestV06.  ISO2002 ID# _u9CRUQ00EeqUVL7sB4m7NA.
//
namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// The MaintenanceDelegationRequest message is sent by a terminal manager to the master terminal manager to request delegation of maintenance functions or maintenance operation on the terminal estate managed by the master terminal manager.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The MaintenanceDelegationRequest message is sent by a terminal manager to the master terminal manager to request delegation of maintenance functions or maintenance operation on the terminal estate managed by the master terminal manager.")]
public partial record MaintenanceDelegationRequestV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MntncDlgtnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_u9CRUw00EeqUVL7sB4m7NA")]
    [Description(@"Information related to the protocol management.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    public SomeHeaderRecord? Header { get; init; }
    
    /// <summary>
    /// Information related to the request of maintenance delegations.
    /// </summary>
    [IsoId("_u9CRVQ00EeqUVL7sB4m7NA")]
    [Description(@"Information related to the request of maintenance delegations.")]
    [DataMember(Name="MntncDlgtnReq")]
    [XmlElement(ElementName="MntncDlgtnReq")]
    [Required]
    public required SomeMaintenanceDelegationRequestRecord MaintenanceDelegationRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_u9CRVw00EeqUVL7sB4m7NA")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required SomeSecurityTrailerRecord SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MaintenanceDelegationRequestV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MaintenanceDelegationRequestV06Document ToDocument()
    {
        return new MaintenanceDelegationRequestV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MaintenanceDelegationRequestV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MaintenanceDelegationRequestV06Document : IOuterDocument<MaintenanceDelegationRequestV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.005.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MaintenanceDelegationRequestV06"/> is required.
    /// </summary>
    public required MaintenanceDelegationRequestV06 Message { get; init; }
}