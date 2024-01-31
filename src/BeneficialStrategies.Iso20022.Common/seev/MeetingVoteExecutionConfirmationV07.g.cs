﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingVoteExecutionConfirmationV07.  ISO2002 ID# _sV77O_EkEeqRfth943bvEA.
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
public partial record MeetingVoteExecutionConfirmationV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgVoteExctnConf";
    
    #nullable enable
    /// <summary>
    /// Identification of the original meeting instruction message for which the vote execution  confirmation is provided.
    /// </summary>
    [IsoId("_sV77Q_EkEeqRfth943bvEA")]
    [Description(@"Identification of the original meeting instruction message for which the vote execution  confirmation is provided.")]
    [DataMember(Name="MtgInstrId")]
    [XmlElement(ElementName="MtgInstrId")]
    [Required]
    public required IsoMax35Text MeetingInstructionIdentification { get; init; }
    
    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_sV77RfEkEeqRfth943bvEA")]
    [Description(@"Set of elements to allow the unambiguous identification of a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required MeetingReference10 MeetingReference { get; init; }
    
    /// <summary>
    /// Security for which the meeting is organised.
    /// </summary>
    [IsoId("_sV77R_EkEeqRfth943bvEA")]
    [Description(@"Security for which the meeting is organised.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Specifies how a party has voted for each agenda item.
    /// </summary>
    [IsoId("_sV77SfEkEeqRfth943bvEA")]
    [Description(@"Specifies how a party has voted for each agenda item.")]
    [DataMember(Name="VoteInstrs")]
    [XmlElement(ElementName="VoteInstrs")]
    public DetailedInstructionStatus15? VoteInstructions { get; init; }
    
    /// <summary>
    /// Address to use over the www (HTTP) service where the confirmations of the vote instructions can be found.
    /// </summary>
    [IsoId("_sV77S_EkEeqRfth943bvEA")]
    [Description(@"Address to use over the www (HTTP) service where the confirmations of the vote instructions can be found.")]
    [DataMember(Name="VoteInstrsConfURLAdr")]
    [XmlElement(ElementName="VoteInstrsConfURLAdr")]
    public IsoMax2048Text? VoteInstructionsConfirmationURLAddress { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_sV77TfEkEeqRfth943bvEA")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingVoteExecutionConfirmationV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingVoteExecutionConfirmationV07Document ToDocument()
    {
        return new MeetingVoteExecutionConfirmationV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingVoteExecutionConfirmationV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingVoteExecutionConfirmationV07Document : IOuterDocument<MeetingVoteExecutionConfirmationV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingVoteExecutionConfirmationV07"/> is required.
    /// </summary>
    public required MeetingVoteExecutionConfirmationV07 Message { get; init; }
}
