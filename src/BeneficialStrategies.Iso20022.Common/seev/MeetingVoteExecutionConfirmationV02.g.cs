﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingVoteExecutionConfirmationV02.  ISO2002 ID# _Ttyay9EwEd-BzquC8wXy7w_1192448161.
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
/// This record is an implementation of the seev.007.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An issuer, its agent or an intermediary sends the MeetingVoteExecutionConfirmation message to confirm to the Sender of the MeetingInstruction message, the execution of their voting instruction.
/// Usage
/// This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting and confirms that the vote has been processed as instructed via the MeetingInstruction message.
/// This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An issuer, its agent or an intermediary sends the MeetingVoteExecutionConfirmation message to confirm to the Sender of the MeetingInstruction message, the execution of their voting instruction.|Usage|This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting and confirms that the vote has been processed as instructed via the MeetingInstruction message.|This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.")]
public partial record MeetingVoteExecutionConfirmationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.007.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgVoteExctnConf";
    
    #nullable enable
    /// <summary>
    /// Identifies the vote execution confirmation message.
    /// </summary>
    [IsoId("_TtyazNEwEd-BzquC8wXy7w_1192448199")]
    [Description(@"Identifies the vote execution confirmation message.")]
    [DataMember(Name="VoteExctnConfId")]
    [XmlElement(ElementName="VoteExctnConfId")]
    [Required]
    public required MessageIdentification1 VoteExecutionConfirmationIdentification { get; init; }
    
    /// <summary>
    /// Identifies the meeting instruction message.
    /// </summary>
    [IsoId("_Tt8LwNEwEd-BzquC8wXy7w_1192448163")]
    [Description(@"Identifies the meeting instruction message.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    [Required]
    public required MessageIdentification RelatedReference { get; init; }
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_Tt8LwdEwEd-BzquC8wXy7w_1192448179")]
    [Description(@"Series of elements which allow to identify a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required MeetingReference3 MeetingReference { get; init; }
    
    /// <summary>
    /// Party confirming the votes.
    /// </summary>
    [IsoId("_Tt8LwtEwEd-BzquC8wXy7w_1192448214")]
    [Description(@"Party confirming the votes.")]
    [DataMember(Name="RptgPty")]
    [XmlElement(ElementName="RptgPty")]
    [Required]
    public required PartyIdentification9Choice_ ReportingParty { get; init; }
    
    /// <summary>
    /// Identifies the securities for which the meeting is organised.
    /// </summary>
    [IsoId("_Tt8Lw9EwEd-BzquC8wXy7w_-1409853595")]
    [Description(@"Identifies the securities for which the meeting is organised.")]
    [DataMember(Name="SctyId")]
    [XmlElement(ElementName="SctyId")]
    [Required]
    public required SecurityIdentification3 SecurityIdentification { get; init; }
    
    /// <summary>
    /// Specifies how a party has voted for each agenda item.
    /// </summary>
    [IsoId("_Tt8LxNEwEd-BzquC8wXy7w_603156788")]
    [Description(@"Specifies how a party has voted for each agenda item.")]
    [DataMember(Name="VoteInstr")]
    [XmlElement(ElementName="VoteInstr")]
    [Required]
    public required DetailedInstructionStatus2 VoteInstruction { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingVoteExecutionConfirmationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingVoteExecutionConfirmationV02Document ToDocument()
    {
        return new MeetingVoteExecutionConfirmationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingVoteExecutionConfirmationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingVoteExecutionConfirmationV02Document : IOuterDocument<MeetingVoteExecutionConfirmationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingVoteExecutionConfirmationV02"/> is required.
    /// </summary>
    public required MeetingVoteExecutionConfirmationV02 Message { get; init; }
}
