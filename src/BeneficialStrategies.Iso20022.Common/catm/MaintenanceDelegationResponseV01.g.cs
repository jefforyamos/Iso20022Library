﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MaintenanceDelegationResponseV01.  ISO2002 ID# _2l24gGqEEeS8RZDTbvnB_A.
//
namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// The master terminal manager provides the outcome of a maintenance delegation request to a terminal manager.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The master terminal manager provides the outcome of a maintenance delegation request to a terminal manager.")]
public partial record MaintenanceDelegationResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MntncDlgtnRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Maintenance delegation response message management information.
    /// </summary>
    [IsoId("_fY2w8GqFEeS8RZDTbvnB_A")]
    [Description(@"Maintenance delegation response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header16 Header { get; init; }
    
    /// <summary>
    /// Information related to the request of maintenance delegations.
    /// </summary>
    [IsoId("_3RHmkGqFEeS8RZDTbvnB_A")]
    [Description(@"Information related to the request of maintenance delegations.")]
    [DataMember(Name="MntncDlgtnRspn")]
    [XmlElement(ElementName="MntncDlgtnRspn")]
    [Required]
    public required MaintenanceDelegationResponse1 MaintenanceDelegationResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_sgPd8GqFEeS8RZDTbvnB_A")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required ContentInformationType12 SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MaintenanceDelegationResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MaintenanceDelegationResponseV01Document ToDocument()
    {
        return new MaintenanceDelegationResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MaintenanceDelegationResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MaintenanceDelegationResponseV01Document : IOuterDocument<MaintenanceDelegationResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.006.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MaintenanceDelegationResponseV01"/> is required.
    /// </summary>
    public required MaintenanceDelegationResponseV01 Message { get; init; }
}
