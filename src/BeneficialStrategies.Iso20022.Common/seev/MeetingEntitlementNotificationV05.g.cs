﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingEntitlementNotificationV05.  ISO2002 ID# _xDAOGVtcEeSwKe7KuKvXhg.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// An account servicer sends the MeetingEntitlementNotification to an issuer, its agent, an intermediary or an account owner to advise the entitlement in relation to a shareholders meeting.
/// Usage
/// This message is sent to advise the quantity of securities held by an account owner. The balance is specified for the securities for which the meeting is taking place.
/// This entitlement message is sent by the account servicer or the registrar to an intermediary, the issuer's agent or the issuer. It is also sent between the account servicer and the account owner or the party holding the right to vote.
/// The message is also used to amend a previously sent MeetingEntitlementNotification. To notify an update, the RelatedReference must be included in the message.
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends the MeetingEntitlementNotification to an issuer, its agent, an intermediary or an account owner to advise the entitlement in relation to a shareholders meeting.|Usage|This message is sent to advise the quantity of securities held by an account owner. The balance is specified for the securities for which the meeting is taking place.|This entitlement message is sent by the account servicer or the registrar to an intermediary, the issuer's agent or the issuer. It is also sent between the account servicer and the account owner or the party holding the right to vote.|The message is also used to amend a previously sent MeetingEntitlementNotification. To notify an update, the RelatedReference must be included in the message.|This message definition is intended for use with the Business Application Header.")]
public partial record MeetingEntitlementNotificationV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgEntitlmntNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the meeting entitlement message to be modified.
    /// </summary>
    [IsoId("_xDAOHVtcEeSwKe7KuKvXhg")]
    [Description(@"Identifies the meeting entitlement message to be modified.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_xDAOH1tcEeSwKe7KuKvXhg")]
    [Description(@"Series of elements which allow to identify a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required SomeMeetingReferenceRecord MeetingReference { get; init; }
    
    /// <summary>
    /// Identifies the security for which the meeting is organised, the account and the positions of the security holder.
    /// </summary>
    [IsoId("_xDAOI1tcEeSwKe7KuKvXhg")]
    [Description(@"Identifies the security for which the meeting is organised, the account and the positions of the security holder.")]
    [DataMember(Name="Scty")]
    [XmlElement(ElementName="Scty")]
    public required IReadonlyCollection<SomeSecurityRecord> Security { get; init; } // Min=1, Max=200
    
    /// <summary>
    /// Defines the dates determining eligibility.
    /// </summary>
    [IsoId("_xDAOJVtcEeSwKe7KuKvXhg")]
    [Description(@"Defines the dates determining eligibility.")]
    [DataMember(Name="Elgblty")]
    [XmlElement(ElementName="Elgblty")]
    [Required]
    public required SomeEligibilityRecord Eligibility { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nfrAIVtoEeSwKe7KuKvXhg")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingEntitlementNotificationV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingEntitlementNotificationV05Document ToDocument()
    {
        return new MeetingEntitlementNotificationV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingEntitlementNotificationV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingEntitlementNotificationV05Document : IOuterDocument<MeetingEntitlementNotificationV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.003.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingEntitlementNotificationV05"/> is required.
    /// </summary>
    public required MeetingEntitlementNotificationV05 Message { get; init; }
}