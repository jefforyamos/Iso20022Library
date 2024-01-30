﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CancelInstruction3.  ISO2002 ID# _eqOH0RuUEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction to be cancelled.
/// </summary>
public partial record CancelInstruction3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the individual instruction previously sent.
    /// </summary>
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 
    /// <summary>
    /// Account and instructed positions to which the meeting instruction cancellation request applies.
    /// </summary>
    public SafekeepingAccount13? InstructedPosition { get; init; } 
    
    #nullable disable
}
