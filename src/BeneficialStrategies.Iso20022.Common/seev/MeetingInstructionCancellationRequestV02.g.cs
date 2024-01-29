﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingInstructionCancellationRequestV02.  ISO2002 ID# _TnFV2tEwEd-BzquC8wXy7w_-50610544.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// The MeetingInstructionCancellationRequest message is sent by the same party that sent the MeetingInstruction message. It is sent to request the cancellation of all instructions included in the original the MeetingInstruction message.
/// Usage
/// This message must be answered by a MeetingInstructionStatus message. Some instructions in the previously sent MeetingInstruction message may have already been executed and cannot be cancelled. This information should appear clearly in the status message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MeetingInstructionCancellationRequest message is sent by the same party that sent the MeetingInstruction message. It is sent to request the cancellation of all instructions included in the original the MeetingInstruction message.|Usage|This message must be answered by a MeetingInstructionStatus message. Some instructions in the previously sent MeetingInstruction message may have already been executed and cannot be cancelled. This information should appear clearly in the status message.")]
public partial record MeetingInstructionCancellationRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrCxlReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Uniquely identifies the cancellation request.
    /// </summary>
    [IsoId("_TnFV29EwEd-BzquC8wXy7w_-50610266")]
    [Description(@"Uniquely identifies the cancellation request.")]
    [DataMember(Name="InstrCxlId")]
    [XmlElement(ElementName="InstrCxlId")]
    [Required]
    public required SomeInstructionCancellationIdentificationRecord InstructionCancellationIdentification { get; init; }
    
    /// <summary>
    /// Identifies the instruction to be cancelled.
    /// </summary>
    [IsoId("_TnFV3NEwEd-BzquC8wXy7w_-50610509")]
    [Description(@"Identifies the instruction to be cancelled.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    [Required]
    public required SomePreviousReferenceRecord PreviousReference { get; init; }
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TnPG0NEwEd-BzquC8wXy7w_-50610526")]
    [Description(@"Series of elements which allow to identify a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    public SomeMeetingReferenceRecord? MeetingReference { get; init; }
    
    /// <summary>
    /// Party requesting the cancellation.
    /// </summary>
    [IsoId("_TnPG0dEwEd-BzquC8wXy7w_-50610497")]
    [Description(@"Party requesting the cancellation.")]
    [DataMember(Name="RqstngPty")]
    [XmlElement(ElementName="RqstngPty")]
    public SomeRequestingPartyRecord? RequestingParty { get; init; }
    
    /// <summary>
    /// Identifies the security for which the meeting is organised.
    /// </summary>
    [IsoId("_TnPG0tEwEd-BzquC8wXy7w_-1638529229")]
    [Description(@"Identifies the security for which the meeting is organised.")]
    [DataMember(Name="SctyId")]
    [XmlElement(ElementName="SctyId")]
    public SomeSecurityIdentificationRecord? SecurityIdentification { get; init; }
    
    /// <summary>
    /// Identifies the account and instructed positions for which the instruction cancellation request applies.
    /// </summary>
    [IsoId("_TnPG09EwEd-BzquC8wXy7w_-2011631186")]
    [Description(@"Identifies the account and instructed positions for which the instruction cancellation request applies.")]
    [DataMember(Name="InstdPos")]
    [XmlElement(ElementName="InstdPos")]
    public SomeInstructedPositionRecord? InstructedPosition { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingInstructionCancellationRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingInstructionCancellationRequestV02Document ToDocument()
    {
        return new MeetingInstructionCancellationRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingInstructionCancellationRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingInstructionCancellationRequestV02Document : IOuterDocument<MeetingInstructionCancellationRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.005.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingInstructionCancellationRequestV02"/> is required.
    /// </summary>
    public required MeetingInstructionCancellationRequestV02 Message { get; init; }
}