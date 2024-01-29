﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecurityMaintenanceRequestV01.  ISO2002 ID# _jTvNwR62Eeu31YsWNiv_cw.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// SCOPE
/// An instructing party sends a SecurityMaintenanceRequest message to an executing/servicing party to request the maintenance of financial instrument details in their system.
/// The instructing party - executing/servicing party relationship may be:
/// - Central Securities Depositories (CSD) who would like to publish security static data, or 
/// - a Corporate, or
/// - a Bank, or
/// - a Market Infrastructure, or 
/// - a Market Data Provider.
/// USAGE
/// The request is sent when the instructing party identified a gap in the security data within the executing/servicing party system. The instructing party needs this security to be updated at the executing /servicing party to perform its activities.
/// Initiator: instructing party.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"SCOPE|An instructing party sends a SecurityMaintenanceRequest message to an executing/servicing party to request the maintenance of financial instrument details in their system.||The instructing party - executing/servicing party relationship may be:|- Central Securities Depositories (CSD) who would like to publish security static data, or |- a Corporate, or|- a Bank, or|- a Market Infrastructure, or |- a Market Data Provider.||USAGE|The request is sent when the instructing party identified a gap in the security data within the executing/servicing party system. The instructing party needs this security to be updated at the executing /servicing party to perform its activities.||Initiator: instructing party.")]
public partial record SecurityMaintenanceRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctyMntncReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_Qqn3IZIxEeuAlLVx8pyt3w")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    public SomeMessageHeaderRecord? MessageHeader { get; init; }
    
    /// <summary>
    /// Request to maintain data's of a security.
    /// </summary>
    [IsoId("_jTvNzx62Eeu31YsWNiv_cw")]
    [Description(@"Request to maintain data's of a security.")]
    [DataMember(Name="UpdTp")]
    [XmlElement(ElementName="UpdTp")]
    [Required]
    public required SomeUpdateTypeRecord UpdateType { get; init; }
    
    /// <summary>
    /// Reason for the update of a security.
    /// </summary>
    [IsoId("_nwYQwZI8EeuAlLVx8pyt3w")]
    [Description(@"Reason for the update of a security.")]
    [DataMember(Name="UpdRsn")]
    [XmlElement(ElementName="UpdRsn")]
    public SomeUpdateReasonRecord? UpdateReason { get; init; }
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_jTvN0R62Eeu31YsWNiv_cw")]
    [Description(@"Identification of the financial instrument.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SomeFinancialInstrumentIdentificationRecord FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_wEnt8ZIzEeuAlLVx8pyt3w")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecurityMaintenanceRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecurityMaintenanceRequestV01Document ToDocument()
    {
        return new SecurityMaintenanceRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecurityMaintenanceRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecurityMaintenanceRequestV01Document : IOuterDocument<SecurityMaintenanceRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.007.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecurityMaintenanceRequestV01"/> is required.
    /// </summary>
    public required SecurityMaintenanceRequestV01 Message { get; init; }
}