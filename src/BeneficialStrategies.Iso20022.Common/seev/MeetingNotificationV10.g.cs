﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingNotificationV10.  ISO2002 ID# _nIzHwTQ7Ee22Z83HpR5E8w.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// The MeetingNotification message is sent by a notifying party, for example, an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to announce a meeting.
/// Usage
/// The MeetingNotification message is used to announce a meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MeetingNotification message is sent by a notifying party, for example, an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to announce a meeting.|Usage|The MeetingNotification message is used to announce a meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.|This message definition is intended for use with the Business Application Header (BAH).")]
public partial record MeetingNotificationV10 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part notification is to continue or that the message is the last page of the multi-part notification.
    /// </summary>
    [IsoId("_nIzH0TQ7Ee22Z83HpR5E8w")]
    [Description(@"Page number of the message and continuation indicator to indicate that the multi-part notification is to continue or that the message is the last page of the multi-part notification.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public SomePaginationRecord? Pagination { get; init; }
    
    /// <summary>
    /// General information about the event notification type and status.
    /// </summary>
    [IsoId("_nIzH0zQ7Ee22Z83HpR5E8w")]
    [Description(@"General information about the event notification type and status.")]
    [DataMember(Name="NtfctnGnlInf")]
    [XmlElement(ElementName="NtfctnGnlInf")]
    [Required]
    public required SomeNotificationGeneralInformationRecord NotificationGeneralInformation { get; init; }
    
    /// <summary>
    /// Information specific to notification amendment as for instance the identification to a previous meeting notification.
    /// </summary>
    [IsoId("_nIzH1TQ7Ee22Z83HpR5E8w")]
    [Description(@"Information specific to notification amendment as for instance the identification to a previous meeting notification.")]
    [DataMember(Name="NtfctnUpd")]
    [XmlElement(ElementName="NtfctnUpd")]
    public SomeNotificationUpdateRecord? NotificationUpdate { get; init; }
    
    /// <summary>
    /// Identification of another meeting event that needs to be closely linked to the processing of the event notified in this meeting notification.
    /// </summary>
    [IsoId("_nIzH1zQ7Ee22Z83HpR5E8w")]
    [Description(@"Identification of another meeting event that needs to be closely linked to the processing of the event notified in this meeting notification.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public SomeEventsLinkageRecord? EventsLinkage { get; init; }
    
    /// <summary>
    /// Information about the meeting like meeting identifications, various deadlines, contact persons, electronic and postal locations for accessing information and proxy assignment parameters.
    /// </summary>
    [IsoId("_nIzH2TQ7Ee22Z83HpR5E8w")]
    [Description(@"Information about the meeting like meeting identifications, various deadlines, contact persons, electronic and postal locations for accessing information and proxy assignment parameters.")]
    [DataMember(Name="Mtg")]
    [XmlElement(ElementName="Mtg")]
    [Required]
    public required SomeMeetingRecord Meeting { get; init; }
    
    /// <summary>
    /// Dates and details of the shareholders meeting.
    /// </summary>
    [IsoId("_nIzH2zQ7Ee22Z83HpR5E8w")]
    [Description(@"Dates and details of the shareholders meeting.")]
    [DataMember(Name="MtgDtls")]
    [XmlElement(ElementName="MtgDtls")]
    public required IReadonlyCollection<SomeMeetingDetailsRecord> MeetingDetails { get; init; } // Min=1, Max=5
    
    /// <summary>
    /// Institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    [IsoId("_nIzH3TQ7Ee22Z83HpR5E8w")]
    [Description(@"Institution that is the issuer of the security to which the meeting applies.")]
    [DataMember(Name="Issr")]
    [XmlElement(ElementName="Issr")]
    [Required]
    public required SomeIssuerRecord Issuer { get; init; }
    
    /// <summary>
    /// Agent of the issuer.
    /// </summary>
    [IsoId("_nIzH3zQ7Ee22Z83HpR5E8w")]
    [Description(@"Agent of the issuer.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public required IReadonlyCollection<SomeIssuerAgentRecord> IssuerAgent { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Financial instrument identification and net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_nIzH4TQ7Ee22Z83HpR5E8w")]
    [Description(@"Financial instrument identification and net position of a segregated holding, in a single security, within the overall position held in a securities account.")]
    [DataMember(Name="Scty")]
    [XmlElement(ElementName="Scty")]
    public required IReadonlyCollection<SomeSecurityRecord> Security { get; init; } // Min=1, Max=200
    
    /// <summary>
    /// Detailed information of a resolution proposed to the vote.
    /// </summary>
    [IsoId("_nIzH4zQ7Ee22Z83HpR5E8w")]
    [Description(@"Detailed information of a resolution proposed to the vote.")]
    [DataMember(Name="Rsltn")]
    [XmlElement(ElementName="Rsltn")]
    public required IReadonlyCollection<SomeResolutionRecord> Resolution { get; init; } // Min=0, Max=1000
    
    /// <summary>
    /// Conditions for voting, the different voting methods and options, the voting deadlines and the parameters of the incentive premium.
    /// </summary>
    [IsoId("_nIzH5TQ7Ee22Z83HpR5E8w")]
    [Description(@"Conditions for voting, the different voting methods and options, the voting deadlines and the parameters of the incentive premium.")]
    [DataMember(Name="Vote")]
    [XmlElement(ElementName="Vote")]
    public SomeVoteRecord? Vote { get; init; }
    
    /// <summary>
    /// Information about the use of power of attorney.
    /// </summary>
    [IsoId("_nIzH5zQ7Ee22Z83HpR5E8w")]
    [Description(@"Information about the use of power of attorney.")]
    [DataMember(Name="PwrOfAttnyRqrmnts")]
    [XmlElement(ElementName="PwrOfAttnyRqrmnts")]
    public SomePowerOfAttorneyRequirementsRecord? PowerOfAttorneyRequirements { get; init; }
    
    /// <summary>
    /// Additional narrative information about the meeting event.
    /// </summary>
    [IsoId("_nIzH6TQ7Ee22Z83HpR5E8w")]
    [Description(@"Additional narrative information about the meeting event.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public SomeAdditionalInformationRecord? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nIzH6zQ7Ee22Z83HpR5E8w")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingNotificationV10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingNotificationV10Document ToDocument()
    {
        return new MeetingNotificationV10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingNotificationV10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingNotificationV10Document : IOuterDocument<MeetingNotificationV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingNotificationV10"/> is required.
    /// </summary>
    public required MeetingNotificationV10 Message { get; init; }
}
