﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingInstructionStatusV03.  ISO2002 ID# _TqDxVdEwEd-BzquC8wXy7w_1419808465.
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
/// This record is an implementation of the seev.006.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Receiver of the MeetingInstruction or MeetingInstructionCancellationRequest sends the MeetingInstructionStatus message to the Sender of these messages.
/// The message gives the status of a complete message or of one or more specific instructions within the message.
/// Usage
/// The MeetingInstructionStatus message is used for four purposes.
/// First, it provides the status on the processing of a MeetingInstructionCancellationRequest message, for example, whether the request message is rejected or accepted.
/// Second, it is used to provide a global processing or rejection status of a MeetingInstruction message.
/// Third, it is used to provide a detailed processing or rejection status of a MeetingInstruction message, for example, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the InstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.
/// The blocking of securities should be confirmed via an MT 508 (Intra-Position Advice).
/// Fourth, it is used as a reminder to request voting instructions. This is done by indicating NONREF in the Identification element of the InstructionIdentification component and by using the status code NotReceived in the ProcessingStatus.
/// </summary>
[Description(@"Scope|The Receiver of the MeetingInstruction or MeetingInstructionCancellationRequest sends the MeetingInstructionStatus message to the Sender of these messages.|The message gives the status of a complete message or of one or more specific instructions within the message.|Usage|The MeetingInstructionStatus message is used for four purposes.|First, it provides the status on the processing of a MeetingInstructionCancellationRequest message, for example, whether the request message is rejected or accepted.|Second, it is used to provide a global processing or rejection status of a MeetingInstruction message.|Third, it is used to provide a detailed processing or rejection status of a MeetingInstruction message, for example, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the InstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.|The blocking of securities should be confirmed via an MT 508 (Intra-Position Advice).|Fourth, it is used as a reminder to request voting instructions. This is done by indicating NONREF in the Identification element of the InstructionIdentification component and by using the status code NotReceived in the ProcessingStatus.")]
[IsoId("_TqDxVdEwEd-BzquC8wXy7w_1419808465")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Meeting Instruction Status V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingInstructionStatusV03 : IOuterRecord<MeetingInstructionStatusV03,MeetingInstructionStatusV03Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.006.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrSts";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MeetingInstructionStatusV03Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MeetingInstructionStatusV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingInstructionStatusV03( MessageIdentification1 reqIdentification,InstructionType1Choice_ reqInstructionType,MeetingReference4 reqMeetingReference,PartyIdentification9Choice_ reqReportingParty,SecurityIdentification11 reqSecurityIdentification,InstructionTypeStatus1Choice_ reqInstructionTypeStatus )
    {
        Identification = reqIdentification;
        InstructionType = reqInstructionType;
        MeetingReference = reqMeetingReference;
        ReportingParty = reqReportingParty;
        SecurityIdentification = reqSecurityIdentification;
        InstructionTypeStatus = reqInstructionTypeStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the meeting instruction status message.
    /// </summary>
    [IsoId("_TqDxVtEwEd-BzquC8wXy7w_800896967")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MessageIdentification1 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 Identification { get; init; } 
    #else
    public MessageIdentification1 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of instruction.
    /// </summary>
    [IsoId("_TqDxV9EwEd-BzquC8wXy7w_163995952")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instruction Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructionType1Choice_ InstructionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public InstructionType1Choice_ InstructionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionType1Choice_ InstructionType { get; init; } 
    #else
    public InstructionType1Choice_ InstructionType { get; set; } 
    #endif
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TqDxWNEwEd-BzquC8wXy7w_-1804950275")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Meeting Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingReference4 MeetingReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MeetingReference4 MeetingReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingReference4 MeetingReference { get; init; } 
    #else
    public MeetingReference4 MeetingReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party reporting the status.
    /// </summary>
    [IsoId("_TqDxWdEwEd-BzquC8wXy7w_-2052453533")]
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
    [IsoId("_TqDxWtEwEd-BzquC8wXy7w_-1766163547")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification11 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecurityIdentification11 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification11 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification11 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of instruction status.
    /// </summary>
    [IsoId("_TqNiUNEwEd-BzquC8wXy7w_1193457913")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instruction Type Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructionTypeStatus1Choice_ InstructionTypeStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public InstructionTypeStatus1Choice_ InstructionTypeStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionTypeStatus1Choice_ InstructionTypeStatus { get; init; } 
    #else
    public InstructionTypeStatus1Choice_ InstructionTypeStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingInstructionStatusV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingInstructionStatusV03Document ToDocument()
    {
        return new MeetingInstructionStatusV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingInstructionStatusV03"/>.
/// </summary>
[Serializable]
public partial record MeetingInstructionStatusV03Document : IOuterDocument<MeetingInstructionStatusV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.006.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingInstructionStatusV03"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingInstructionStatusV03 Message { get; init; }
    #else
    public MeetingInstructionStatusV03 Message { get; init; }
    #endif
}
