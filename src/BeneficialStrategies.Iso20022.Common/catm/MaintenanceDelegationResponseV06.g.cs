﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MaintenanceDelegationResponseV06.  ISO2002 ID# _FuWhIVE_EeyApZmLzm74zA.
//
namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// The MaintenanceDelegationResponse message is sent by the master terminal manager to a terminal manager to provide the outcome of a maintenance delegation request.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The MaintenanceDelegationResponse message is sent by the master terminal manager to a terminal manager to provide the outcome of a maintenance delegation request.")]
public partial record MaintenanceDelegationResponseV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MntncDlgtnRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Maintenance delegation response message management information.
    /// </summary>
    [IsoId("_FuWhI1E_EeyApZmLzm74zA")]
    [Description(@"Maintenance delegation response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the request of maintenance delegations.
    /// </summary>
    [IsoId("_FuWhJVE_EeyApZmLzm74zA")]
    [Description(@"Information related to the request of maintenance delegations.")]
    [DataMember(Name="MntncDlgtnRspn")]
    [XmlElement(ElementName="MntncDlgtnRspn")]
    [Required]
    public required SomeMaintenanceDelegationResponseRecord MaintenanceDelegationResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_FuWhJ1E_EeyApZmLzm74zA")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MaintenanceDelegationResponseV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MaintenanceDelegationResponseV06Document ToDocument()
    {
        return new MaintenanceDelegationResponseV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MaintenanceDelegationResponseV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MaintenanceDelegationResponseV06Document : IOuterDocument<MaintenanceDelegationResponseV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.006.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MaintenanceDelegationResponseV06"/> is required.
    /// </summary>
    public required MaintenanceDelegationResponseV06 Message { get; init; }
}