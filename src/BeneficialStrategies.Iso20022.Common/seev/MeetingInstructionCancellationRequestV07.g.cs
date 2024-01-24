﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingInstructionCancellationRequestV07.  ISO2002 ID# _sVyKXfEkEeqRfth943bvEA.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// The MeetingInstructionCancellationRequest message is sent by the same party that sent the
/// MeetingInstruction message. It is sent to request the cancellation of one, some or all of the instructions included in the original MeetingInstruction message.
/// Usage
/// This message must be answered by a MeetingInstructionStatus message. 
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MeetingInstructionCancellationRequest message is sent by the same party that sent the|MeetingInstruction message. It is sent to request the cancellation of one, some or all of the instructions included in the original MeetingInstruction message.|Usage|This message must be answered by a MeetingInstructionStatus message. |This message definition is intended for use with the Business Application Header (BAH).")]
public partial record MeetingInstructionCancellationRequestV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrCxlReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingInstructionCancellationRequestV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingInstructionCancellationRequestV07Document ToDocument()
    {
        return new MeetingInstructionCancellationRequestV07Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The MeetingInstructionCancellationRequest message is sent by the same party that sent the
/// MeetingInstruction message. It is sent to request the cancellation of one, some or all of the instructions included in the original MeetingInstruction message.
/// Usage
/// This message must be answered by a MeetingInstructionStatus message. 
/// This message definition is intended for use with the Business Application Header (BAH).
/// This is the outer document that contains <seealso cref="MeetingInstructionCancellationRequestV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingInstructionCancellationRequestV07Document : IOuterDocument<MeetingInstructionCancellationRequestV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.005.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingInstructionCancellationRequestV07"/> is required.
    /// </summary>
    public required MeetingInstructionCancellationRequestV07 Message { get; init; }
}
