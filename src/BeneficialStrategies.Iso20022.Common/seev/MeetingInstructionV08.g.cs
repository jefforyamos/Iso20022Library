﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingInstructionV08.  ISO2002 ID# _lKgSgRrdEeyhRdHRjakS2w.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// The MeetingInstruction message is sent by a party holding the right to vote to an intermediary, the issuer or its agent to request the receiving party to act upon one or several instructions.
/// Usage
/// The MeetingInstruction message is used to vote, to require attendance to a meeting, to request registration of securities and assign a proxy. One instruction or multiple instructions can be carried within the same message.
/// Once the message is sent, it cannot be modified. It must be cancelled by a MeetingInstructionCancellationRequest. Only after receipt of a confirmed cancelled status via the
/// MeetingInstructionStatus message, a new MeetingInstruction message can be sent.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MeetingInstruction message is sent by a party holding the right to vote to an intermediary, the issuer or its agent to request the receiving party to act upon one or several instructions.|Usage|The MeetingInstruction message is used to vote, to require attendance to a meeting, to request registration of securities and assign a proxy. One instruction or multiple instructions can be carried within the same message.|Once the message is sent, it cannot be modified. It must be cancelled by a MeetingInstructionCancellationRequest. Only after receipt of a confirmed cancelled status via the|MeetingInstructionStatus message, a new MeetingInstruction message can be sent.|This message definition is intended for use with the Business Application Header (BAH).")]
public partial record MeetingInstructionV08 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstr";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_lKgShxrdEeyhRdHRjakS2w")]
    [Description(@"Set of elements to allow the unambiguous identification of a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required SomeMeetingReferenceRecord MeetingReference { get; init; }
    
    /// <summary>
    /// Security for which the meeting is organised.
    /// </summary>
    [IsoId("_lKgSiRrdEeyhRdHRjakS2w")]
    [Description(@"Security for which the meeting is organised.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SomeFinancialInstrumentIdentificationRecord FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Identification of other messages/documents as well as the messages/documents number.
    /// </summary>
    [IsoId("_lKgSixrdEeyhRdHRjakS2w")]
    [Description(@"Identification of other messages/documents as well as the messages/documents number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public SomeOtherDocumentIdentificationRecord? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// The position of the instructing party and the action that it wants to take.
    /// </summary>
    [IsoId("_lKgSjRrdEeyhRdHRjakS2w")]
    [Description(@"The position of the instructing party and the action that it wants to take.")]
    [DataMember(Name="Instr")]
    [XmlElement(ElementName="Instr")]
    [Required]
    public required SomeInstructionRecord Instruction { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_lKgSjxrdEeyhRdHRjakS2w")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingInstructionV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingInstructionV08Document ToDocument()
    {
        return new MeetingInstructionV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingInstructionV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingInstructionV08Document : IOuterDocument<MeetingInstructionV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingInstructionV08"/> is required.
    /// </summary>
    public required MeetingInstructionV08 Message { get; init; }
}