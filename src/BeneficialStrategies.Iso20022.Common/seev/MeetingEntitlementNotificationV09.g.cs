﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingEntitlementNotificationV09.  ISO2002 ID# _nIzHYTQ7Ee22Z83HpR5E8w.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// The MeetingEntitlementNotification is sent by an account servicer to the account owner to advise the entitlement in relation to a meeting.
/// Usage
/// This message is sent to advise the quantity of securities held by an account owner. The balance is specified for the securities for which the meeting is taking place. The message is also used to amend a previously sent MeetingEntitlementNotification. 
/// The MeetingEntitlementNotification message may be sent either before receiving a voting instruction to confirm the entitlement; or after having received a voting instruction to confirm details of the person attending the meeting. 
/// The message may also be used in place of an attendance card or to confirm entitlements in the case of bearer shares.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MeetingEntitlementNotification is sent by an account servicer to the account owner to advise the entitlement in relation to a meeting.|Usage|This message is sent to advise the quantity of securities held by an account owner. The balance is specified for the securities for which the meeting is taking place. The message is also used to amend a previously sent MeetingEntitlementNotification. |The MeetingEntitlementNotification message may be sent either before receiving a voting instruction to confirm the entitlement; or after having received a voting instruction to confirm details of the person attending the meeting. |The message may also be used in place of an attendance card or to confirm entitlements in the case of bearer shares.|This message definition is intended for use with the Business Application Header (BAH).")]
public partial record MeetingEntitlementNotificationV09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgEntitlmntNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Type of notification.
    /// </summary>
    [IsoId("_nIzHazQ7Ee22Z83HpR5E8w")]
    [Description(@"Type of notification.")]
    [DataMember(Name="NtfctnTp")]
    [XmlElement(ElementName="NtfctnTp")]
    [Required]
    public required NotificationType2Code NotificationType { get; init; }
    
    /// <summary>
    /// Identification of the original meeting notification entitlement message which is amended.
    /// </summary>
    [IsoId("_nIzHczQ7Ee22Z83HpR5E8w")]
    [Description(@"Identification of the original meeting notification entitlement message which is amended.")]
    [DataMember(Name="PrvsEntitlmntNtfctnId")]
    [XmlElement(ElementName="PrvsEntitlmntNtfctnId")]
    public IsoMax35Text? PreviousEntitlementNotificationIdentification { get; init; }
    
    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_nIzHdTQ7Ee22Z83HpR5E8w")]
    [Description(@"Set of elements to allow the unambiguous identification of a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required MeetingReference10 MeetingReference { get; init; }
    
    /// <summary>
    /// Institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    [IsoId("_nIzHdzQ7Ee22Z83HpR5E8w")]
    [Description(@"Institution that is the issuer of the security to which the meeting applies.")]
    [DataMember(Name="Issr")]
    [XmlElement(ElementName="Issr")]
    [Required]
    public required IPartyIdentification129Choice Issuer { get; init; }
    
    /// <summary>
    /// Security for which the meeting is organised, the account and the positions of the security holder.
    /// </summary>
    [IsoId("_nIzHeTQ7Ee22Z83HpR5E8w")]
    [Description(@"Security for which the meeting is organised, the account and the positions of the security holder.")]
    [DataMember(Name="Scty")]
    [XmlElement(ElementName="Scty")]
    public required IReadonlyCollection<SecurityPosition18> Security { get; init; } // Min=1, Max=200
    
    /// <summary>
    /// Date determining eligibility.
    /// </summary>
    [IsoId("_nIzHezQ7Ee22Z83HpR5E8w")]
    [Description(@"Date determining eligibility.")]
    [DataMember(Name="Elgblty")]
    [XmlElement(ElementName="Elgblty")]
    [Required]
    public required EligibilityDates1 Eligibility { get; init; }
    
    /// <summary>
    /// Person physically attending the meeting as a natural or legal person.
    /// </summary>
    [IsoId("_nIzHfTQ7Ee22Z83HpR5E8w")]
    [Description(@"Person physically attending the meeting as a natural or legal person.")]
    [DataMember(Name="MtgAttndee")]
    [XmlElement(ElementName="MtgAttndee")]
    public IPartyIdentification232Choice? MeetingAttendee { get; init; }
    
    /// <summary>
    /// Third party agent assigned by the shareholder that is legally authorised to cast a vote on the shareholder's behalf at the general meeting.
    /// </summary>
    [IsoId("_nIzHfzQ7Ee22Z83HpR5E8w")]
    [Description(@"Third party agent assigned by the shareholder that is legally authorised to cast a vote on the shareholder's behalf at the general meeting.")]
    [DataMember(Name="Prxy")]
    [XmlElement(ElementName="Prxy")]
    public IPartyIdentification232Choice? Proxy { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nIzHgTQ7Ee22Z83HpR5E8w")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingEntitlementNotificationV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingEntitlementNotificationV09Document ToDocument()
    {
        return new MeetingEntitlementNotificationV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingEntitlementNotificationV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingEntitlementNotificationV09Document : IOuterDocument<MeetingEntitlementNotificationV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.003.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingEntitlementNotificationV09"/> is required.
    /// </summary>
    public required MeetingEntitlementNotificationV09 Message { get; init; }
}
