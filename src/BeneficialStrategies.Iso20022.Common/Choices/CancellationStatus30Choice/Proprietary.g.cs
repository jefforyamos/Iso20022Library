﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _T_qoCRIwEeydmIVkS03esw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus30Choice;

/// <summary>
/// Instruction is unsettled.
/// </summary>
public partial record Proprietary : ICancellationStatus30Choice
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the status related to an instruction.
    /// </summary>
    public required GenericIdentification30 ProprietaryStatus { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason related to a proprietary status.
    /// </summary>
    public ProprietaryReason4? ProprietaryReason { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
