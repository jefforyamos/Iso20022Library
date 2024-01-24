﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CreateMemberV01.  ISO2002 ID# _P8togckHEem3UrxZgQhVAw.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The ModifyMember message is sent by a member to the transaction administrator.
/// It is used to create the profile of a member that the transaction administrator maintains.
/// Usage
/// Based on the criteria defined in the CreateLimit message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ModifyMember message is sent by a member to the transaction administrator.|It is used to create the profile of a member that the transaction administrator maintains.|Usage|Based on the criteria defined in the CreateLimit message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.")]
public partial record CreateMemberV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CretMmb";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_P8toickHEem3UrxZgQhVAw")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required SomeMessageHeaderRecord MessageHeader { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a system member, as assigned by the system, or the system administrator.
    /// </summary>
    [IsoId("_P8toi8kHEem3UrxZgQhVAw")]
    [Description(@"Unique and unambiguous identifier of a system member, as assigned by the system, or the system administrator.")]
    [DataMember(Name="MmbId")]
    [XmlElement(ElementName="MmbId")]
    [Required]
    public required SomeMemberIdentificationRecord MemberIdentification { get; init; }
    
    /// <summary>
    /// New member values.
    /// </summary>
    [IsoId("_P8tojckHEem3UrxZgQhVAw")]
    [Description(@"New member values.")]
    [DataMember(Name="ValSet")]
    [XmlElement(ElementName="ValSet")]
    [Required]
    public required SomeValueSetRecord ValueSet { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_P8toj8kHEem3UrxZgQhVAw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CreateMemberV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CreateMemberV01Document ToDocument()
    {
        return new CreateMemberV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CreateMemberV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CreateMemberV01Document : IOuterDocument<CreateMemberV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.104.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CreateMemberV01"/> is required.
    /// </summary>
    public required CreateMemberV01 Message { get; init; }
}
