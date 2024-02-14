﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingEntitlementNotificationV07.  ISO2002 ID# _sVyKLfEkEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.003.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingEntitlementNotification is sent by an account servicer to the account owner to advise the entitlement in relation to a meeting.
/// Usage
/// This message is sent to advise the quantity of securities held by an account owner. The balance is specified for the securities for which the meeting is taking place. The message is also used to amend a previously sent MeetingEntitlementNotification. 
/// The MeetingEntitlementNotification message may be sent either before receiving a voting instruction to confirm the entitlement; or after having received a voting instruction to confirm details of the person attending the meeting. 
/// The message may also be used in place of an attendance card or to confirm entitlements in the case of bearer shares.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Description(@"Scope|The MeetingEntitlementNotification is sent by an account servicer to the account owner to advise the entitlement in relation to a meeting.|Usage|This message is sent to advise the quantity of securities held by an account owner. The balance is specified for the securities for which the meeting is taking place. The message is also used to amend a previously sent MeetingEntitlementNotification. |The MeetingEntitlementNotification message may be sent either before receiving a voting instruction to confirm the entitlement; or after having received a voting instruction to confirm details of the person attending the meeting. |The message may also be used in place of an attendance card or to confirm entitlements in the case of bearer shares.|This message definition is intended for use with the Business Application Header (BAH).")]
[IsoId("_sVyKLfEkEeqRfth943bvEA")]
[DisplayName("Meeting Entitlement Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingEntitlementNotificationV07 : IOuterRecord<MeetingEntitlementNotificationV07,MeetingEntitlementNotificationV07Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.003.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgEntitlmntNtfctn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MeetingEntitlementNotificationV07Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MeetingEntitlementNotificationV07 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingEntitlementNotificationV07( NotificationType2Code reqNotificationType,MeetingReference10 reqMeetingReference,PartyIdentification129Choice_ reqIssuer,EligibilityDates1 reqEligibility )
    {
        NotificationType = reqNotificationType;
        MeetingReference = reqMeetingReference;
        Issuer = reqIssuer;
        Eligibility = reqEligibility;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of notification.
    /// </summary>
    [IsoId("_sVyKN_EkEeqRfth943bvEA")]
    [DisplayName("Notification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnTp")]
    #endif
    [IsoXmlTag("NtfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NotificationType2Code NotificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NotificationType2Code NotificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotificationType2Code NotificationType { get; init; } 
    #else
    public NotificationType2Code NotificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the original meeting notification entitlement message which is amended.
    /// </summary>
    [IsoId("_sVyKP_EkEeqRfth943bvEA")]
    [DisplayName("Previous Entitlement Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsEntitlmntNtfctnId")]
    #endif
    [IsoXmlTag("PrvsEntitlmntNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PreviousEntitlementNotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreviousEntitlementNotificationIdentification { get; init; } 
    #else
    public System.String? PreviousEntitlementNotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_sVyKQfEkEeqRfth943bvEA")]
    [DisplayName("Meeting Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgRef")]
    #endif
    [IsoXmlTag("MtgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingReference10 MeetingReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingReference10 MeetingReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingReference10 MeetingReference { get; init; } 
    #else
    public MeetingReference10 MeetingReference { get; set; } 
    #endif
    
    /// <summary>
    /// Institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    [IsoId("_sVyKQ_EkEeqRfth943bvEA")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification129Choice_ Issuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification129Choice_ Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification129Choice_ Issuer { get; init; } 
    #else
    public PartyIdentification129Choice_ Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Security for which the meeting is organised, the account and the positions of the security holder.
    /// </summary>
    [IsoId("_sVyKRfEkEeqRfth943bvEA")]
    [DisplayName("Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scty")]
    #endif
    [IsoXmlTag("Scty")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<SecurityPosition13> Security { get; init; } = new ValueList<SecurityPosition13>(){};
    
    /// <summary>
    /// Date determining eligibility.
    /// </summary>
    [IsoId("_sVyKR_EkEeqRfth943bvEA")]
    [DisplayName("Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Elgblty")]
    #endif
    [IsoXmlTag("Elgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EligibilityDates1 Eligibility { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EligibilityDates1 Eligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EligibilityDates1 Eligibility { get; init; } 
    #else
    public EligibilityDates1 Eligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Person physically attending the meeting as a natural or legal person.
    /// </summary>
    [IsoId("_sVyKSfEkEeqRfth943bvEA")]
    [DisplayName("Meeting Attendee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgAttndee")]
    #endif
    [IsoXmlTag("MtgAttndee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification232Choice_? MeetingAttendee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification232Choice_? MeetingAttendee { get; init; } 
    #else
    public PartyIdentification232Choice_? MeetingAttendee { get; set; } 
    #endif
    
    /// <summary>
    /// Third party agent assigned by the shareholder that is legally authorised to cast a vote on the shareholder&apos;s behalf at the general meeting.
    /// </summary>
    [IsoId("_sVyKS_EkEeqRfth943bvEA")]
    [DisplayName("Proxy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prxy")]
    #endif
    [IsoXmlTag("Prxy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification232Choice_? Proxy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification232Choice_? Proxy { get; init; } 
    #else
    public PartyIdentification232Choice_? Proxy { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_sVyKTfEkEeqRfth943bvEA")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;MeetingEntitlementNotificationV07Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingEntitlementNotificationV07Document ToDocument()
    {
        return new MeetingEntitlementNotificationV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;MeetingEntitlementNotificationV07&quot;/&gt;.
/// </summary>
[Serializable]
public partial record MeetingEntitlementNotificationV07Document : IOuterDocument<MeetingEntitlementNotificationV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.003.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;MeetingEntitlementNotificationV07&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingEntitlementNotificationV07 Message { get; init; }
    #else
    public MeetingEntitlementNotificationV07 Message { get; init; }
    #endif
}
