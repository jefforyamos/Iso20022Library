﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingInstructionStatusV06.  ISO2002 ID# _yXBbd6yREemMosWmlQ33EA.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// The MeetingInstructionStatus message is sent by an intermediary to the sender of an instruction to confirm the status of such an instruction. The message gives the status of a complete message or of one or more specific instructions within the message.
/// The message may also be sent by the Issuer or the intermediary to confirm that a vote has been cast.
/// Usage
/// The MeetingInstructionStatus message is used for four purposes.
/// First, it is used to provide a global processing or rejection status of a MeetingInstruction message.
/// Second, it provides the status on the processing of a MeetingInstructionCancellationRequest message, for example, whether the request message is rejected or accepted.
/// Third, it is used to provide a detailed processing or rejection status of one or more instructions within the MeetingInstruction message, for example, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the SingleInstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.
/// Fourth, it is used to confirm that the related vote instruction has been confirmed as cast by the issuer or its agent.
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MeetingInstructionStatus message is sent by an intermediary to the sender of an instruction to confirm the status of such an instruction. The message gives the status of a complete message or of one or more specific instructions within the message.|The message may also be sent by the Issuer or the intermediary to confirm that a vote has been cast.|Usage|The MeetingInstructionStatus message is used for four purposes.|First, it is used to provide a global processing or rejection status of a MeetingInstruction message.|Second, it provides the status on the processing of a MeetingInstructionCancellationRequest message, for example, whether the request message is rejected or accepted.|Third, it is used to provide a detailed processing or rejection status of one or more instructions within the MeetingInstruction message, for example, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the SingleInstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.|Fourth, it is used to confirm that the related vote instruction has been confirmed as cast by the issuer or its agent.|This message definition is intended for use with the Business Application Header.")]
public partial record MeetingInstructionStatusV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrSts";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Type of instruction.
    /// </summary>
    [IsoId("_yXBbf6yREemMosWmlQ33EA")]
    [Description(@"Type of instruction.")]
    [DataMember(Name="InstrTp")]
    [XmlElement(ElementName="InstrTp")]
    [Required]
    public required SomeInstructionTypeRecord InstructionType { get; init; }
    
    /// <summary>
    /// Set of elements that allow to identify unambiguously a meeting.
    /// </summary>
    [IsoId("_yXBbgayREemMosWmlQ33EA")]
    [Description(@"Set of elements that allow to identify unambiguously a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required SomeMeetingReferenceRecord MeetingReference { get; init; }
    
    /// <summary>
    /// Securities for which the meeting is organised.
    /// </summary>
    [IsoId("_yXBbg6yREemMosWmlQ33EA")]
    [Description(@"Securities for which the meeting is organised.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SomeFinancialInstrumentIdentificationRecord FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Type of instruction status.
    /// </summary>
    [IsoId("_yXBbhayREemMosWmlQ33EA")]
    [Description(@"Type of instruction status.")]
    [DataMember(Name="InstrTpSts")]
    [XmlElement(ElementName="InstrTpSts")]
    [Required]
    public required SomeInstructionTypeStatusRecord InstructionTypeStatus { get; init; }
    
    /// <summary>
    /// Party that confirms the receipt of the vote cast.
    /// </summary>
    [IsoId("_meGP0K-iEemJ1NnLPsTFaw")]
    [Description(@"Party that confirms the receipt of the vote cast.")]
    [DataMember(Name="CnfrmgPty")]
    [XmlElement(ElementName="CnfrmgPty")]
    [Required]
    public required SomeConfirmingPartyRecord ConfirmingParty { get; init; }
    
    /// <summary>
    /// Party that cast the voting ballot.
    /// </summary>
    [IsoId("_UojDMK-lEemJ1NnLPsTFaw")]
    [Description(@"Party that cast the voting ballot.")]
    [DataMember(Name="VoteCstgPty")]
    [XmlElement(ElementName="VoteCstgPty")]
    [Required]
    public required SomeVoteCastingPartyRecord VoteCastingParty { get; init; }
    
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_fWGLAK-lEemJ1NnLPsTFaw")]
    [Description(@"Owner of the voting rights.")]
    [DataMember(Name="RghtsHldr")]
    [XmlElement(ElementName="RghtsHldr")]
    public SomeRightsHolderRecord? RightsHolder { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_yXBbh6yREemMosWmlQ33EA")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingInstructionStatusV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingInstructionStatusV06Document ToDocument()
    {
        return new MeetingInstructionStatusV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingInstructionStatusV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingInstructionStatusV06Document : IOuterDocument<MeetingInstructionStatusV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.006.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingInstructionStatusV06"/> is required.
    /// </summary>
    public required MeetingInstructionStatusV06 Message { get; init; }
}
