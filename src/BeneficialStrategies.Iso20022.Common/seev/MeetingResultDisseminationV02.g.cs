﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingResultDisseminationV02.  ISO2002 ID# _Ts5C69EwEd-BzquC8wXy7w_762088787.
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
/// This record is an implementation of the seev.008.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An issuer, its agent or an intermediary sends the MeetingResultDissemination message to another intermediary, to a party holding the right to vote, to a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.
/// Usage
/// The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.
/// This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.
/// </summary>
[Description(@"Scope|An issuer, its agent or an intermediary sends the MeetingResultDissemination message to another intermediary, to a party holding the right to vote, to a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.|Usage|The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.|This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.")]
[IsoId("_Ts5C69EwEd-BzquC8wXy7w_762088787")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Meeting Result Dissemination V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingResultDisseminationV02 : IOuterRecord<MeetingResultDisseminationV02,MeetingResultDisseminationV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.008.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgRsltDssmntn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MeetingResultDisseminationV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MeetingResultDisseminationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingResultDisseminationV02( MessageIdentification1 reqMeetingResultDisseminationIdentification,MeetingReference3 reqMeetingReference,PartyIdentification9Choice_ reqReportingParty )
    {
        MeetingResultDisseminationIdentification = reqMeetingResultDisseminationIdentification;
        MeetingReference = reqMeetingReference;
        ReportingParty = reqReportingParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the meeting dissemination notification message.
    /// </summary>
    [IsoId("_Ts5C7NEwEd-BzquC8wXy7w_-595761646")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Meeting Result Dissemination Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MeetingResultDisseminationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MessageIdentification1 MeetingResultDisseminationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MeetingResultDisseminationIdentification { get; init; } 
    #else
    public MessageIdentification1 MeetingResultDisseminationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information specific to an amemdment.
    /// </summary>
    [IsoId("_Ts5C7dEwEd-BzquC8wXy7w_350846493")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Amendment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmendInformation2? Amendment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmendInformation2? Amendment { get; init; } 
    #else
    public AmendInformation2? Amendment { get; set; } 
    #endif
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TtCz4NEwEd-BzquC8wXy7w_762088836")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Meeting Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingReference3 MeetingReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MeetingReference3 MeetingReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingReference3 MeetingReference { get; init; } 
    #else
    public MeetingReference3 MeetingReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party reporting the meeting results.
    /// </summary>
    [IsoId("_TtCz4dEwEd-BzquC8wXy7w_762088841")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reporting Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification9Choice_ ReportingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification9Choice_ ReportingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification9Choice_ ReportingParty { get; init; } 
    #else
    public PartyIdentification9Choice_ ReportingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the securities for which the meeting is organised.
    /// </summary>
    [IsoId("_TtCz4tEwEd-BzquC8wXy7w_762088866")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(1)]
    [MaxLength(200)]
    #endif
    public ValueList<SecurityPosition5> Security { get; init; } = new ValueList<SecurityPosition5>(){};
    
    /// <summary>
    /// Results per resolution.
    /// </summary>
    [IsoId("_TtCz49EwEd-BzquC8wXy7w_762088823")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Vote Result")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(1)]
    [MaxLength(200)]
    #endif
    public ValueList<Vote5> VoteResult { get; init; } = new ValueList<Vote5>(){};
    
    /// <summary>
    /// Information about the participation to the voting process.
    /// </summary>
    [IsoId("_TtCz5NEwEd-BzquC8wXy7w_762088806")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Participation")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Participation2? Participation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Participation2? Participation { get; init; } 
    #else
    public Participation2? Participation { get; set; } 
    #endif
    
    /// <summary>
    /// Information on where additionnal information can be received.
    /// </summary>
    [IsoId("_TtCz5dEwEd-BzquC8wXy7w_762088789")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress4? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress4? AdditionalInformation { get; init; } 
    #else
    public CommunicationAddress4? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingResultDisseminationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingResultDisseminationV02Document ToDocument()
    {
        return new MeetingResultDisseminationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingResultDisseminationV02"/>.
/// </summary>
[Serializable]
public partial record MeetingResultDisseminationV02Document : IOuterDocument<MeetingResultDisseminationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.008.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingResultDisseminationV02"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingResultDisseminationV02 Message { get; init; }
    #else
    public MeetingResultDisseminationV02 Message { get; init; }
    #endif
}
