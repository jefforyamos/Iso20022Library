﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Instruction7.  ISO2002 ID# _wxo4kTT5Ee2j2eQlcOSMKg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a meeting vote instruction.
/// </summary>
[DataContract]
[XmlType]
public partial record Instruction7
{
    #nullable enable
    
    /// <summary>
    /// Identification of the individual instruction.
    /// </summary>
    [DataMember]
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 
    /// <summary>
    /// Date at which the instruction must be executed.
    /// </summary>
    [DataMember]
    public IsoISODateTime? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Indicates that a vote execution confirmation is requested.
    /// </summary>
    [DataMember]
    public required IsoYesNoIndicator VoteExecutionConfirmation { get; init; } 
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [DataMember]
    public required SafekeepingAccount15 AccountDetails { get; init; } 
    /// <summary>
    /// Identification of the person appointed by the security holder as the proxy.
    /// </summary>
    [DataMember]
    public Proxy12? Proxy { get; init; } 
    /// <summary>
    /// Detailed voting instructions.
    /// </summary>
    [DataMember]
    public VoteDetails6? VoteDetails { get; init; } 
    /// <summary>
    /// Identification of the security holder who will attend and vote at the meeting in person and/or the person assigned by the security holder to attend the meeting without having any voting rights or taking any action.
    /// </summary>
    [DataMember]
    public ValueList<IndividualPerson41> MeetingAttendee { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
    /// </summary>
    [DataMember]
    public SpecificInstructionRequest4? SpecificInstructionRequest { get; init; } 
    
    #nullable disable
}
