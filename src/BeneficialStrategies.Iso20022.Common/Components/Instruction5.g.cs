﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Instruction5.  ISO2002 ID# _7NKXMfNXEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a meeting vote instruction.
/// </summary>
public partial record Instruction5
{
    #nullable enable
    
    /// <summary>
    /// Identification of the individual instruction.
    /// </summary>
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 
    /// <summary>
    /// Date at which the instruction must be executed.
    /// </summary>
    public IsoISODateTime? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Indicates that a vote execution confirmation is requested.
    /// </summary>
    public required IsoYesNoIndicator VoteExecutionConfirmation { get; init; } 
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    public required SafekeepingAccount12 AccountDetails { get; init; } 
    /// <summary>
    /// Identification of the person appointed by the security holder as the proxy.
    /// </summary>
    public Proxy10? Proxy { get; init; } 
    /// <summary>
    /// Detailed voting instructions.
    /// </summary>
    public VoteDetails5? VoteDetails { get; init; } 
    /// <summary>
    /// Identification of the security holder who will attend and vote at the meeting in person and/or the person assigned by the security holder to attend the meeting without having any voting rights or taking any action.
    /// </summary>
    public IndividualPerson41? MeetingAttendee { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
    /// </summary>
    public SpecificInstructionRequest3? SpecificInstructionRequest { get; init; } 
    
    #nullable disable
}
