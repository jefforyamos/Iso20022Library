﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingInstructionCancellationRequestV06.  ISO2002 ID# _yXBbaayREemMosWmlQ33EA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// This record is an implementation of the seev.005.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingInstructionCancellationRequest message is sent by the same party that sent the
/// MeetingInstruction message. It is sent to request the cancellation of one, some or all of the instructions included in the original MeetingInstruction message.
/// Usage
/// This message must be answered by a MeetingInstructionStatus message. 
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Description(@"Scope|The MeetingInstructionCancellationRequest message is sent by the same party that sent the|MeetingInstruction message. It is sent to request the cancellation of one, some or all of the instructions included in the original MeetingInstruction message.|Usage|This message must be answered by a MeetingInstructionStatus message. |This message definition is intended for use with the Business Application Header.")]
[IsoId("_yXBbaayREemMosWmlQ33EA")]
[DisplayName("Meeting Instruction Cancellation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingInstructionCancellationRequestV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.005.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrCxlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.005.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MeetingInstructionCancellationRequestV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingInstructionCancellationRequestV06( System.String reqMeetingInstructionIdentification )
    {
        MeetingInstructionIdentification = reqMeetingInstructionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the original meeting instruction message for which the cancellation is requested or the original meeting instruction message containing the individual instruction(s) that is/are to be cancelled.
    /// </summary>
    [IsoId("_yXBbbayREemMosWmlQ33EA")]
    [DisplayName("Meeting Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgInstrId")]
    #endif
    [IsoXmlTag("MtgInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MeetingInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MeetingInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MeetingInstructionIdentification { get; init; } 
    #else
    public System.String MeetingInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements that allow to identify unambiguously a meeting.
    /// </summary>
    [IsoId("_yXBbb6yREemMosWmlQ33EA")]
    [DisplayName("Meeting Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgRef")]
    #endif
    [IsoXmlTag("MtgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MeetingReference8? MeetingReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingReference8? MeetingReference { get; init; } 
    #else
    public MeetingReference8? MeetingReference { get; set; } 
    #endif
    
    /// <summary>
    /// Security for which the meeting is organised.
    /// </summary>
    [IsoId("_yXBbcayREemMosWmlQ33EA")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies one or more instructions for which the cancellation is requested.
    /// </summary>
    [IsoId("_u_uMQK-aEemJ1NnLPsTFaw")]
    [DisplayName("To Be Cancelled Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ToBeCancInstr")]
    #endif
    [IsoXmlTag("ToBeCancInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancelInstruction1? ToBeCancelledInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancelInstruction1? ToBeCancelledInstruction { get; init; } 
    #else
    public CancelInstruction1? ToBeCancelledInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_yXBbdayREemMosWmlQ33EA")]
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
    
}


// Since MeetingInstructionCancellationRequestV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingInstructionCancellationRequestV06.

