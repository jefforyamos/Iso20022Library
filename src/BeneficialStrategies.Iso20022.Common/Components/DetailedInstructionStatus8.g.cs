﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedInstructionStatus8.  ISO2002 ID# _RCy3w9p-Ed-ak6NoX_4Aeg_1948673401.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status applying to individual instructions of a MeetingInstruction.
/// </summary>
public partial record DetailedInstructionStatus8
{
    #nullable enable
    
    /// <summary>
    /// Identifies the detailed instruction within an instruction message.
    /// </summary>
    public required IsoMax35Text InstructionIdentification { get; init; } 
    /// <summary>
    /// Identifies the safekeeping account.
    /// </summary>
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Identifies the subaccount of the safekeeping account.
    /// </summary>
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    /// <summary>
    /// Status applying to individual instructions of a MeetingInstruction.
    /// </summary>
    public required IInstructionStatus4Choice InstructionStatus { get; init; } 
    
    #nullable disable
}
