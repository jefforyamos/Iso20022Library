﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for GetMemberV04.  ISO2002 ID# _jwlbjxbvEeiyVv5j1vf1VQ.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The GetMember message is sent by a member to the transaction administrator.
/// It is used to request information on static data maintained by the transaction administrator and related to the participants in the system and their membership status vis-a-vis this system.
/// Usage
/// The transaction administrator is in charge of providing the members with business information. The term business information covers all information related to the management of the system, that is, not related to the transactions entered into the system. The type of business information available can vary depending on the system. Among other things, it can refer to information about the membership of the system.
/// At any time during the operating hours of the system, the member can query the transaction administrator to get information about the static data related to the members of the system.
/// The member can request information based on the following elements:
/// - identification of the member within the system
/// - membership status
/// - type of member
/// - contact details for the member: name, address
/// - account number of the member
/// - identification of contact persons for the member
/// This message will be replied to by a ReturnMember message.
/// Additional information on the generic design of the Get/Return messages can be found in the MDR Part 1 section How to Use the Cash Management Messages.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The GetMember message is sent by a member to the transaction administrator.|It is used to request information on static data maintained by the transaction administrator and related to the participants in the system and their membership status vis-a-vis this system.|Usage|The transaction administrator is in charge of providing the members with business information. The term business information covers all information related to the management of the system, that is, not related to the transactions entered into the system. The type of business information available can vary depending on the system. Among other things, it can refer to information about the membership of the system.|At any time during the operating hours of the system, the member can query the transaction administrator to get information about the static data related to the members of the system.|The member can request information based on the following elements:|- identification of the member within the system|- membership status|- type of member|- contact details for the member: name, address|- account number of the member|- identification of contact persons for the member|This message will be replied to by a ReturnMember message.|Additional information on the generic design of the Get/Return messages can be found in the MDR Part 1 section How to Use the Cash Management Messages.")]
public partial record GetMemberV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetMmb";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbkRbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader9 MessageHeader { get; init; }
    
    /// <summary>
    /// Definition of the member query.
    /// </summary>
    [IsoId("_jwlbkxbvEeiyVv5j1vf1VQ")]
    [Description(@"Definition of the member query.")]
    [DataMember(Name="MmbQryDef")]
    [XmlElement(ElementName="MmbQryDef")]
    public MemberQueryDefinition4? MemberQueryDefinition { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlblRbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="GetMemberV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public GetMemberV04Document ToDocument()
    {
        return new GetMemberV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="GetMemberV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record GetMemberV04Document : IOuterDocument<GetMemberV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.013.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="GetMemberV04"/> is required.
    /// </summary>
    public required GetMemberV04 Message { get; init; }
}
