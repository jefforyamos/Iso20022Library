﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingVoteExecutionConfirmationV09.  ISO2002 ID# _nIzIDTQ7Ee22Z83HpR5E8w.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// The MeetingVoteExecutionConfirmation message is sent by an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to confirm, to the Sender of the MeetingInstruction message, that their vote has been recorded and counted by the Issuer.
/// Usage
/// This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting.
/// This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MeetingVoteExecutionConfirmation message is sent by an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to confirm, to the Sender of the MeetingInstruction message, that their vote has been recorded and counted by the Issuer.|Usage|This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting.|This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.|This message definition is intended for use with the Business Application Header (BAH).")]
public partial record MeetingVoteExecutionConfirmationV09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgVoteExctnConf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part vote execution confirmation message is to continue or that the message is the last page of the multi-part vote execution confirmation.
    /// </summary>
    [IsoId("_rnQA4TUFEe2tRf29bleifQ")]
    [Description(@"Page number of the message and continuation indicator to indicate that the multi-part vote execution confirmation message is to continue or that the message is the last page of the multi-part vote execution confirmation.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public SomePaginationRecord? Pagination { get; init; }
    
    /// <summary>
    /// Unique identification of the group of vote execution confirmation messages when the vote execution confirmation is split in multiple (paginated) messages.
    /// </summary>
    [IsoId("_52KWoDUFEe2tRf29bleifQ")]
    [Description(@"Unique identification of the group of vote execution confirmation messages when the vote execution confirmation is split in multiple (paginated) messages.")]
    [DataMember(Name="VoteExctnConfId")]
    [XmlElement(ElementName="VoteExctnConfId")]
    public SomeVoteExecutionConfirmationIdentificationRecord? VoteExecutionConfirmationIdentification { get; init; }
    
    /// <summary>
    /// Identification of the original meeting instruction message for which the vote execution  confirmation is provided.
    /// </summary>
    [IsoId("_nIzIFTQ7Ee22Z83HpR5E8w")]
    [Description(@"Identification of the original meeting instruction message for which the vote execution  confirmation is provided.")]
    [DataMember(Name="MtgInstrId")]
    [XmlElement(ElementName="MtgInstrId")]
    [Required]
    public required SomeMeetingInstructionIdentificationRecord MeetingInstructionIdentification { get; init; }
    
    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_nIzIFzQ7Ee22Z83HpR5E8w")]
    [Description(@"Set of elements to allow the unambiguous identification of a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required SomeMeetingReferenceRecord MeetingReference { get; init; }
    
    /// <summary>
    /// Security for which the meeting is organised.
    /// </summary>
    [IsoId("_nIzIGTQ7Ee22Z83HpR5E8w")]
    [Description(@"Security for which the meeting is organised.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SomeFinancialInstrumentIdentificationRecord FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Specifies how a party has voted for each agenda item.
    /// </summary>
    [IsoId("_nIzIGzQ7Ee22Z83HpR5E8w")]
    [Description(@"Specifies how a party has voted for each agenda item.")]
    [DataMember(Name="VoteInstrs")]
    [XmlElement(ElementName="VoteInstrs")]
    public SomeVoteInstructionsRecord? VoteInstructions { get; init; }
    
    /// <summary>
    /// Address to use over the www (HTTP) service where the confirmations of the vote instructions can be found.
    /// </summary>
    [IsoId("_nIzIHTQ7Ee22Z83HpR5E8w")]
    [Description(@"Address to use over the www (HTTP) service where the confirmations of the vote instructions can be found.")]
    [DataMember(Name="VoteInstrsConfURLAdr")]
    [XmlElement(ElementName="VoteInstrsConfURLAdr")]
    public SomeVoteInstructionsConfirmationURLAddressRecord? VoteInstructionsConfirmationURLAddress { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nIzIHzQ7Ee22Z83HpR5E8w")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingVoteExecutionConfirmationV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingVoteExecutionConfirmationV09Document ToDocument()
    {
        return new MeetingVoteExecutionConfirmationV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingVoteExecutionConfirmationV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingVoteExecutionConfirmationV09Document : IOuterDocument<MeetingVoteExecutionConfirmationV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingVoteExecutionConfirmationV09"/> is required.
    /// </summary>
    public required MeetingVoteExecutionConfirmationV09 Message { get; init; }
}
