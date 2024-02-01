﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingInstructionV04.  ISO2002 ID# _Tq9JOdEwEd-BzquC8wXy7w_-1580879636.
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
/// This record is an implementation of the seev.004.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A party holding the right to vote sends the MeetingInstruction message to an intermediary, the issuer or its agent to request the receiving party to act upon one or several instructions.
/// Usage
/// The MeetingInstruction message is used to register for a shareholders meeting, request blocking or registration of securities. It is used to assign a proxy, to specify the names of meeting attendees and to relay vote instructions per resolution electronically.
/// The MeetingInstruction message may only be sent for one security, though several safekeeping places may be specified.
/// Once the message is sent, it cannot be modified. It must be cancelled by a MeetingInstructionCancellationRequest. Only after receipt of a confirmed cancelled status via the MeetingInstructionStatus message, a new MeetingInstruction message can be sent.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|A party holding the right to vote sends the MeetingInstruction message to an intermediary, the issuer or its agent to request the receiving party to act upon one or several instructions.|Usage|The MeetingInstruction message is used to register for a shareholders meeting, request blocking or registration of securities. It is used to assign a proxy, to specify the names of meeting attendees and to relay vote instructions per resolution electronically.|The MeetingInstruction message may only be sent for one security, though several safekeeping places may be specified.|Once the message is sent, it cannot be modified. It must be cancelled by a MeetingInstructionCancellationRequest. Only after receipt of a confirmed cancelled status via the MeetingInstructionStatus message, a new MeetingInstruction message can be sent.")]
public partial record MeetingInstructionV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.004.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstr";
    
    #nullable enable
    /// <summary>
    /// Identifies the meeting instruction message.
    /// </summary>
    [IsoId("_Tq9JOtEwEd-BzquC8wXy7w_1416416792")]
    [Description(@"Identifies the meeting instruction message.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required MessageIdentification1 Identification { get; init; }
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_Tq9JO9EwEd-BzquC8wXy7w_668851111")]
    [Description(@"Series of elements which allow to identify a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required MeetingReference4 MeetingReference { get; init; }
    
    /// <summary>
    /// Party notifying the instructions.
    /// </summary>
    [IsoId("_Tq9JPNEwEd-BzquC8wXy7w_1200693664")]
    [Description(@"Party notifying the instructions.")]
    [DataMember(Name="InstgPty")]
    [XmlElement(ElementName="InstgPty")]
    [Required]
    public required PartyIdentification9Choice_ InstructingParty { get; init; }
    
    /// <summary>
    /// Identifies the security for which the meeting is organised.
    /// </summary>
    [IsoId("_TrG6MNEwEd-BzquC8wXy7w_2100528158")]
    [Description(@"Identifies the security for which the meeting is organised.")]
    [DataMember(Name="SctyId")]
    [XmlElement(ElementName="SctyId")]
    [Required]
    public required SecurityIdentification11 SecurityIdentification { get; init; }
    
    /// <summary>
    /// Identifies the position of the instructing party and the action that they want to take.
    /// </summary>
    [IsoId("_TrG6MdEwEd-BzquC8wXy7w_-1116418800")]
    [Description(@"Identifies the position of the instructing party and the action that they want to take.")]
    [DataMember(Name="Instr")]
    [XmlElement(ElementName="Instr")]
    [Required]
    public required Instruction2 Instruction { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TrG6MtEwEd-BzquC8wXy7w_1093292958")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension2? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingInstructionV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingInstructionV04Document ToDocument()
    {
        return new MeetingInstructionV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingInstructionV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingInstructionV04Document : IOuterDocument<MeetingInstructionV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingInstructionV04"/> is required.
    /// </summary>
    public required MeetingInstructionV04 Message { get; init; }
}
