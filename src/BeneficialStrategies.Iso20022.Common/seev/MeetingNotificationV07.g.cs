﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingNotificationV07.  ISO2002 ID# _XO5EMTkqEequeo9XmZe9AQ.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.001.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
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
public partial record MeetingNotificationV07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.001.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgNtfctn";
    
    #nullable enable
    /// <summary>
    /// General information about the event notification type and status.
    /// </summary>
    [IsoId("_XO5EQTkqEequeo9XmZe9AQ")]
    [Description(@"General information about the event notification type and status.")]
    [DataMember(Name="NtfctnGnlInf")]
    [XmlElement(ElementName="NtfctnGnlInf")]
    [Required]
    public required NotificationGeneralInformation2 NotificationGeneralInformation { get; init; }
    
    /// <summary>
    /// Information specific to notification amendment as for instance the identification to a previous meeting notification.
    /// </summary>
    [IsoId("_XO5EQzkqEequeo9XmZe9AQ")]
    [Description(@"Information specific to notification amendment as for instance the identification to a previous meeting notification.")]
    [DataMember(Name="NtfctnUpd")]
    [XmlElement(ElementName="NtfctnUpd")]
    public NotificationUpdate1? NotificationUpdate { get; init; }
    
    /// <summary>
    /// Identification of another meeting event that needs to be closely linked to the processing of the event notified in this meeting notification.
    /// </summary>
    [IsoId("_XO5ERTkqEequeo9XmZe9AQ")]
    [Description(@"Identification of another meeting event that needs to be closely linked to the processing of the event notified in this meeting notification.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public MeetingEventReference1? EventsLinkage { get; init; }
    
    /// <summary>
    /// Specifies information about the meeting like meeting identifications, various deadlines, contact persons, electronic and postal locations for accessing information and proxy assignment parameters.
    /// </summary>
    [IsoId("_XO5ERzkqEequeo9XmZe9AQ")]
    [Description(@"Specifies information about the meeting like meeting identifications, various deadlines, contact persons, electronic and postal locations for accessing information and proxy assignment parameters.")]
    [DataMember(Name="Mtg")]
    [XmlElement(ElementName="Mtg")]
    [Required]
    public required MeetingNotice5 Meeting { get; init; }
    
    /// <summary>
    /// Dates and details of the shareholders meeting.
    /// </summary>
    [IsoId("_XO5ESTkqEequeo9XmZe9AQ")]
    [Description(@"Dates and details of the shareholders meeting.")]
    [DataMember(Name="MtgDtls")]
    [XmlElement(ElementName="MtgDtls")]
    public required IReadOnlyCollection<Meeting5> MeetingDetails { get; init; } = []; // Min=1, Max=5
    
    /// <summary>
    /// Institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    [IsoId("_XO5ESzkqEequeo9XmZe9AQ")]
    [Description(@"Institution that is the issuer of the security to which the meeting applies.")]
    [DataMember(Name="Issr")]
    [XmlElement(ElementName="Issr")]
    [Required]
    public required IssuerInformation3 Issuer { get; init; }
    
    /// <summary>
    /// Agent of the issuer.
    /// </summary>
    [IsoId("_XO5ETTkqEequeo9XmZe9AQ")]
    [Description(@"Agent of the issuer.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public required IReadOnlyCollection<IssuerAgent3> IssuerAgent { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Financial instrument identification and net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_XO5ETzkqEequeo9XmZe9AQ")]
    [Description(@"Financial instrument identification and net position of a segregated holding, in a single security, within the overall position held in a securities account.")]
    [DataMember(Name="Scty")]
    [XmlElement(ElementName="Scty")]
    public required IReadOnlyCollection<SecurityPosition10> Security { get; init; } = []; // Min=1, Max=200
    
    /// <summary>
    /// Detailed information of a resolution proposed to the vote.
    /// </summary>
    [IsoId("_XO5EUTkqEequeo9XmZe9AQ")]
    [Description(@"Detailed information of a resolution proposed to the vote.")]
    [DataMember(Name="Rsltn")]
    [XmlElement(ElementName="Rsltn")]
    public required IReadOnlyCollection<Resolution4> Resolution { get; init; } = []; // Min=0, Max=1000
    
    /// <summary>
    /// Conditions to be allowed to vote, the different voting methods and options, the voting deadlines and the parameters of the incentive premium.
    /// </summary>
    [IsoId("_XO5EUzkqEequeo9XmZe9AQ")]
    [Description(@"Conditions to be allowed to vote, the different voting methods and options, the voting deadlines and the parameters of the incentive premium.")]
    [DataMember(Name="Vote")]
    [XmlElement(ElementName="Vote")]
    public VoteParameters5? Vote { get; init; }
    
    /// <summary>
    /// Information about the use of Power of Attorney.
    /// </summary>
    [IsoId("_XO5EVTkqEequeo9XmZe9AQ")]
    [Description(@"Information about the use of Power of Attorney.")]
    [DataMember(Name="PwrOfAttnyRqrmnts")]
    [XmlElement(ElementName="PwrOfAttnyRqrmnts")]
    public PowerOfAttorneyRequirements4? PowerOfAttorneyRequirements { get; init; }
    
    /// <summary>
    /// Additional narrative information about the corporate event.
    /// </summary>
    [IsoId("_XO5EVzkqEequeo9XmZe9AQ")]
    [Description(@"Additional narrative information about the corporate event.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CorporateEventNarrative2? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_XO5EWTkqEequeo9XmZe9AQ")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingNotificationV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingNotificationV07Document ToDocument()
    {
        return new MeetingNotificationV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingNotificationV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingNotificationV07Document : IOuterDocument<MeetingNotificationV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingNotificationV07"/> is required.
    /// </summary>
    public required MeetingNotificationV07 Message { get; init; }
}
