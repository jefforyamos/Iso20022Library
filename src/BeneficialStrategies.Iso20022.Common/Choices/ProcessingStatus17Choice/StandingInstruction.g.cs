﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StandingInstruction.  ISO2002 ID# _A5JrA9okEeC60axPepSq7g_1018532153.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus17Choice;

/// <summary>
/// Trade is standing instruction.
/// </summary>
public partial record StandingInstruction : IProcessingStatus17Choice
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the reason related to a status.
    /// </summary>
    public GenericIdentification20? Reason { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
