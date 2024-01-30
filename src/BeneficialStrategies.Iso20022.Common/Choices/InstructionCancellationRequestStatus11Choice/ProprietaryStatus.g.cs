﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryStatus.  ISO2002 ID# _1m6c44luEeavwKddCbm3hg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus11Choice;

/// <summary>
/// Proprietary status related to an instruction cancellation request.
/// </summary>
public partial record ProprietaryStatus : IInstructionCancellationRequestStatus11Choice
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the status related to an instruction.
    /// </summary>
    public required GenericIdentification30 ProprietaryStatusValue { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason related to a proprietary status.
    /// </summary>
    public ProprietaryReason4? ProprietaryReason { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
