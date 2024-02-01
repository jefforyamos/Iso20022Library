﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryStatus.  ISO2002 ID# _inrW41hYEeSewsfsZR0hxA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus20Choice;

/// <summary>
/// Proprietary status related to an instruction.
/// </summary>
public partial record ProprietaryStatus : InstructionProcessingStatus20Choice_
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the status related to an instruction.
    /// </summary>
    public required GenericIdentification20 ProprietaryStatusValue { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason related to a proprietary status.
    /// </summary>
    public ProprietaryReason1? ProprietaryReason { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
