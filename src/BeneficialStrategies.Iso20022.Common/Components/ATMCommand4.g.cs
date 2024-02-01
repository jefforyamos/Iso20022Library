﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMCommand4.  ISO2002 ID# _dy_AoYtFEeSxlKlAGYErFg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maintenance command the ATM must perform.
/// </summary>
public partial record ATMCommand4
{
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    public required ATMCommand2Code Type { get; init; } 
    /// <summary>
    /// Urgency of the command.
    /// </summary>
    public required TMSContactLevel2Code Urgency { get; init; } 
    /// <summary>
    /// Date time on which the command must be performed.
    /// </summary>
    public IsoISODateTime? DateTime { get; init; } 
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    /// <summary>
    /// Reason for sending the command.
    /// </summary>
    public ATMCommandReason1Code? Reason { get; init; } 
    /// <summary>
    /// Trace of reasons by the entities in the path from the origin of the command to the ATM.
    /// </summary>
    public ATMCommandReason1Code[] TraceReason { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information about the reason to request this command.
    /// </summary>
    public IsoMax70Text? AdditionalReasonInformation { get; init; } 
    /// <summary>
    /// Specific parameters attached to the command.
    /// </summary>
    public ATMCommandParameters2Choice_? CommandParameters { get; init; } 
    
    #nullable disable
}
