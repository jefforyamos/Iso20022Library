﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PartyAuditTrailQueryV01.  ISO2002 ID# _-fQN8ZeSEeen_cyMrluY4w.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// The PartyAuditTrailQuery message is sent by an instructing party to the executing party to query for the party audit trail recorded in the system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The PartyAuditTrailQuery message is sent by an instructing party to the executing party to query for the party audit trail recorded in the system.")]
public partial record PartyAuditTrailQueryV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyAudtTrlQry";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_LFFxEVhGEeih3fUfzR38Ig")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    public SomeMessageHeaderRecord? MessageHeader { get; init; }
    
    /// <summary>
    /// Defines the criteria to be used to query the party audit trail by the executing system.
    /// </summary>
    [IsoId("_-fQN-ZeSEeen_cyMrluY4w")]
    [Description(@"Defines the criteria to be used to query the party audit trail by the executing system.")]
    [DataMember(Name="SchCrit")]
    [XmlElement(ElementName="SchCrit")]
    [Required]
    public required SomeSearchCriteriaRecord SearchCriteria { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_-fQN-5eSEeen_cyMrluY4w")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PartyAuditTrailQueryV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PartyAuditTrailQueryV01Document ToDocument()
    {
        return new PartyAuditTrailQueryV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PartyAuditTrailQueryV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PartyAuditTrailQueryV01Document : IOuterDocument<PartyAuditTrailQueryV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.042.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PartyAuditTrailQueryV01"/> is required.
    /// </summary>
    public required PartyAuditTrailQueryV01 Message { get; init; }
}
