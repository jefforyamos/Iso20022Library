﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingNotificationV02.  ISO2002 ID# _TrjmKNEwEd-BzquC8wXy7w_-771376471.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// A notifying party, eg, an issuer, its agent or an intermediary, sends the MeetingNotification message to a party holding the right to vote, to announce a shareholders meeting.
/// Usage
/// The MeetingNotification message is used to announce a shareholders meeting, ie, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.
/// To notify an update, the Amendment building block must be filled in. Any building block that is modified must be included in the amendment message. The information previously notified and not repeated in the amendment message remains valid.
/// To update the resolutions of the agenda, the complete list of resolutions must be repeated in the amendment message. The resolutions that are deleted should be assigned the status Withdrawn.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|A notifying party, eg, an issuer, its agent or an intermediary, sends the MeetingNotification message to a party holding the right to vote, to announce a shareholders meeting.|Usage|The MeetingNotification message is used to announce a shareholders meeting, ie, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.|To notify an update, the Amendment building block must be filled in. Any building block that is modified must be included in the amendment message. The information previously notified and not repeated in the amendment message remains valid.|To update the resolutions of the agenda, the complete list of resolutions must be repeated in the amendment message. The resolutions that are deleted should be assigned the status Withdrawn.")]
public partial record MeetingNotificationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the meeting notification message.
    /// </summary>
    [IsoId("_TrjmKdEwEd-BzquC8wXy7w_-771375282")]
    [Description(@"Identifies the meeting notification message.")]
    [DataMember(Name="MtgNtfctnId")]
    [XmlElement(ElementName="MtgNtfctnId")]
    [Required]
    public required MessageIdentification1 MeetingNotificationIdentification { get; init; }
    
    /// <summary>
    /// Information specific to an amendment.
    /// </summary>
    [IsoId("_TrjmKtEwEd-BzquC8wXy7w_-771374910")]
    [Description(@"Information specific to an amendment.")]
    [DataMember(Name="Amdmnt")]
    [XmlElement(ElementName="Amdmnt")]
    public AmendInformation1? Amendment { get; init; }
    
    /// <summary>
    /// Defines the global status of the event contained in the notification.
    /// </summary>
    [IsoId("_TrswENEwEd-BzquC8wXy7w_-771374490")]
    [Description(@"Defines the global status of the event contained in the notification.")]
    [DataMember(Name="NtfctnSts")]
    [XmlElement(ElementName="NtfctnSts")]
    [Required]
    public required NotificationStatus1 NotificationStatus { get; init; }
    
    /// <summary>
    /// Specifies information about the meeting. This component contains meeting identifications, various deadlines, contact persons, electronic and postal locations for accessing information and proxy assignment parameters.
    /// </summary>
    [IsoId("_TrswEdEwEd-BzquC8wXy7w_-771376385")]
    [Description(@"Specifies information about the meeting. This component contains meeting identifications, various deadlines, contact persons, electronic and postal locations for accessing information and proxy assignment parameters.")]
    [DataMember(Name="Mtg")]
    [XmlElement(ElementName="Mtg")]
    [Required]
    public required MeetingNotice2 Meeting { get; init; }
    
    /// <summary>
    /// Dates and details of the shareholders meeting.
    /// </summary>
    [IsoId("_TrswEtEwEd-BzquC8wXy7w_-771374987")]
    [Description(@"Dates and details of the shareholders meeting.")]
    [DataMember(Name="MtgDtls")]
    [XmlElement(ElementName="MtgDtls")]
    public required IReadonlyCollection<Meeting2> MeetingDetails { get; init; } // Min=1, Max=5
    
    /// <summary>
    /// Party notifying the meeting.
    /// </summary>
    [IsoId("_TrswE9EwEd-BzquC8wXy7w_-771375437")]
    [Description(@"Party notifying the meeting.")]
    [DataMember(Name="NtifngPty")]
    [XmlElement(ElementName="NtifngPty")]
    [Required]
    public required IPartyIdentification9Choice NotifyingParty { get; init; }
    
    /// <summary>
    /// Specifies the institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    [IsoId("_TrswFNEwEd-BzquC8wXy7w_-771375359")]
    [Description(@"Specifies the institution that is the issuer of the security to which the meeting applies.")]
    [DataMember(Name="Issr")]
    [XmlElement(ElementName="Issr")]
    [Required]
    public required IPartyIdentification9Choice Issuer { get; init; }
    
    /// <summary>
    /// Agents of the issuer.
    /// </summary>
    [IsoId("_TrswFdEwEd-BzquC8wXy7w_-771374584")]
    [Description(@"Agents of the issuer.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public required IReadonlyCollection<IssuerAgent1> IssuerAgent { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_TrswFtEwEd-BzquC8wXy7w_1906308006")]
    [Description(@"Net position of a segregated holding, in a single security, within the overall position held in a securities account.")]
    [DataMember(Name="Scty")]
    [XmlElement(ElementName="Scty")]
    public required IReadonlyCollection<SecurityPosition5> Security { get; init; } // Min=1, Max=200
    
    /// <summary>
    /// Detailed information of a resolution proposed to the vote.
    /// </summary>
    [IsoId("_TrswF9EwEd-BzquC8wXy7w_-771375978")]
    [Description(@"Detailed information of a resolution proposed to the vote.")]
    [DataMember(Name="Rsltn")]
    [XmlElement(ElementName="Rsltn")]
    public required IReadonlyCollection<Resolution2> Resolution { get; init; } // Min=0, Max=200
    
    /// <summary>
    /// Specifies the conditions to be allowed to vote, the different voting methods and options, the voting deadlines and the parameters of the incentive premium.
    /// </summary>
    [IsoId("_TrswGNEwEd-BzquC8wXy7w_-771375840")]
    [Description(@"Specifies the conditions to be allowed to vote, the different voting methods and options, the voting deadlines and the parameters of the incentive premium.")]
    [DataMember(Name="Vote")]
    [XmlElement(ElementName="Vote")]
    public VoteParameters1? Vote { get; init; }
    
    /// <summary>
    /// Specifies the entitlement ratio and the different deadlines for calculating the entitlement.
    /// </summary>
    [IsoId("_Tr2hENEwEd-BzquC8wXy7w_-771375902")]
    [Description(@"Specifies the entitlement ratio and the different deadlines for calculating the entitlement.")]
    [DataMember(Name="EntitlmntSpcfctn")]
    [XmlElement(ElementName="EntitlmntSpcfctn")]
    [Required]
    public required EntitlementAssessment1 EntitlementSpecification { get; init; }
    
    /// <summary>
    /// Specifies requirements relative to the use of Power of Attorney.
    /// </summary>
    [IsoId("_Tr2hEdEwEd-BzquC8wXy7w_-771375514")]
    [Description(@"Specifies requirements relative to the use of Power of Attorney.")]
    [DataMember(Name="PwrOfAttnyRqrmnts")]
    [XmlElement(ElementName="PwrOfAttnyRqrmnts")]
    public PowerOfAttorneyRequirements2? PowerOfAttorneyRequirements { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingNotificationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingNotificationV02Document ToDocument()
    {
        return new MeetingNotificationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingNotificationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingNotificationV02Document : IOuterDocument<MeetingNotificationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingNotificationV02"/> is required.
    /// </summary>
    public required MeetingNotificationV02 Message { get; init; }
}
