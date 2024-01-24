﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingNotificationV05.  ISO2002 ID# _xDAOX1tcEeSwKe7KuKvXhg.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// A notifying party, for example, an issuer, its agent or an intermediary, sends the MeetingNotification message to a party holding the right to vote, to announce a shareholders meeting.
/// Usage
/// The MeetingNotification message is used to announce a shareholders meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.
/// To notify an update, the Amendment building block must be filled in. Any building block that is modified must be included in the amendment message. The information previously notified and not repeated in the amendment message remains valid.
/// To update the resolutions of the agenda, the complete list of resolutions must be repeated in the amendment message. The resolutions that are deleted should be assigned the status Withdrawn.
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|A notifying party, for example, an issuer, its agent or an intermediary, sends the MeetingNotification message to a party holding the right to vote, to announce a shareholders meeting.|Usage|The MeetingNotification message is used to announce a shareholders meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.|To notify an update, the Amendment building block must be filled in. Any building block that is modified must be included in the amendment message. The information previously notified and not repeated in the amendment message remains valid.|To update the resolutions of the agenda, the complete list of resolutions must be repeated in the amendment message. The resolutions that are deleted should be assigned the status Withdrawn.|This message definition is intended for use with the Business Application Header.")]
public partial record MeetingNotificationV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information specific to an amendment.
    /// </summary>
    [IsoId("_xDJ_BVtcEeSwKe7KuKvXhg")]
    [Description(@"Information specific to an amendment.")]
    [DataMember(Name="Amdmnt")]
    [XmlElement(ElementName="Amdmnt")]
    public SomeAmendmentRecord? Amendment { get; init; }
    
    /// <summary>
    /// Defines the global status of the event contained in the notification.
    /// </summary>
    [IsoId("_xDJ_B1tcEeSwKe7KuKvXhg")]
    [Description(@"Defines the global status of the event contained in the notification.")]
    [DataMember(Name="NtfctnSts")]
    [XmlElement(ElementName="NtfctnSts")]
    [Required]
    public required SomeNotificationStatusRecord NotificationStatus { get; init; }
    
    /// <summary>
    /// Specifies information about the meeting. This component contains meeting identifications, various deadlines, contact persons, electronic and postal locations for accessing information and proxy assignment parameters.
    /// </summary>
    [IsoId("_xDJ_CVtcEeSwKe7KuKvXhg")]
    [Description(@"Specifies information about the meeting. This component contains meeting identifications, various deadlines, contact persons, electronic and postal locations for accessing information and proxy assignment parameters.")]
    [DataMember(Name="Mtg")]
    [XmlElement(ElementName="Mtg")]
    [Required]
    public required SomeMeetingRecord Meeting { get; init; }
    
    /// <summary>
    /// Dates and details of the shareholders meeting.
    /// </summary>
    [IsoId("_xDJ_C1tcEeSwKe7KuKvXhg")]
    [Description(@"Dates and details of the shareholders meeting.")]
    [DataMember(Name="MtgDtls")]
    [XmlElement(ElementName="MtgDtls")]
    public required IReadonlyCollection<SomeMeetingDetailsRecord> MeetingDetails { get; init; } // Min=1, Max=5
    
    /// <summary>
    /// Specifies the institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    [IsoId("_xDJ_D1tcEeSwKe7KuKvXhg")]
    [Description(@"Specifies the institution that is the issuer of the security to which the meeting applies.")]
    [DataMember(Name="Issr")]
    [XmlElement(ElementName="Issr")]
    [Required]
    public required SomeIssuerRecord Issuer { get; init; }
    
    /// <summary>
    /// Agents of the issuer.
    /// </summary>
    [IsoId("_xDJ_EVtcEeSwKe7KuKvXhg")]
    [Description(@"Agents of the issuer.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public required IReadonlyCollection<SomeIssuerAgentRecord> IssuerAgent { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_xDJ_E1tcEeSwKe7KuKvXhg")]
    [Description(@"Net position of a segregated holding, in a single security, within the overall position held in a securities account.")]
    [DataMember(Name="Scty")]
    [XmlElement(ElementName="Scty")]
    public required IReadonlyCollection<SomeSecurityRecord> Security { get; init; } // Min=1, Max=200
    
    /// <summary>
    /// Detailed information of a resolution proposed to the vote.
    /// </summary>
    [IsoId("_xDJ_FVtcEeSwKe7KuKvXhg")]
    [Description(@"Detailed information of a resolution proposed to the vote.")]
    [DataMember(Name="Rsltn")]
    [XmlElement(ElementName="Rsltn")]
    public required IReadonlyCollection<SomeResolutionRecord> Resolution { get; init; } // Min=0, Max=1000
    
    /// <summary>
    /// Specifies the conditions to be allowed to vote, the different voting methods and options, the voting deadlines and the parameters of the incentive premium.
    /// </summary>
    [IsoId("_xDJ_F1tcEeSwKe7KuKvXhg")]
    [Description(@"Specifies the conditions to be allowed to vote, the different voting methods and options, the voting deadlines and the parameters of the incentive premium.")]
    [DataMember(Name="Vote")]
    [XmlElement(ElementName="Vote")]
    public SomeVoteRecord? Vote { get; init; }
    
    /// <summary>
    /// Specifies the entitlement ratio and the different deadlines for calculating the entitlement.
    /// </summary>
    [IsoId("_xDJ_GVtcEeSwKe7KuKvXhg")]
    [Description(@"Specifies the entitlement ratio and the different deadlines for calculating the entitlement.")]
    [DataMember(Name="EntitlmntSpcfctn")]
    [XmlElement(ElementName="EntitlmntSpcfctn")]
    public SomeEntitlementSpecificationRecord? EntitlementSpecification { get; init; }
    
    /// <summary>
    /// Specifies requirements relative to the use of Power of Attorney.
    /// </summary>
    [IsoId("_xDJ_G1tcEeSwKe7KuKvXhg")]
    [Description(@"Specifies requirements relative to the use of Power of Attorney.")]
    [DataMember(Name="PwrOfAttnyRqrmnts")]
    [XmlElement(ElementName="PwrOfAttnyRqrmnts")]
    public SomePowerOfAttorneyRequirementsRecord? PowerOfAttorneyRequirements { get; init; }
    
    /// <summary>
    /// Provides additional narrative information about the corporate event.
    /// </summary>
    [IsoId("_xDJ_HVtcEeSwKe7KuKvXhg")]
    [Description(@"Provides additional narrative information about the corporate event.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public SomeAdditionalInformationRecord? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_dkX0oVtoEeSwKe7KuKvXhg")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingNotificationV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingNotificationV05Document ToDocument()
    {
        return new MeetingNotificationV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingNotificationV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingNotificationV05Document : IOuterDocument<MeetingNotificationV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingNotificationV05"/> is required.
    /// </summary>
    public required MeetingNotificationV05 Message { get; init; }
}
