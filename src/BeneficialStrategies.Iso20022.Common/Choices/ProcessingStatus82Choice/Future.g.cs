﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Future.  ISO2002 ID# _FjyNQxIwEeydmIVkS03esw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus82Choice;

/// <summary>
/// All checks relative to the instruction (except collateral) are successful.
/// </summary>
public partial record Future : IProcessingStatus82Choice
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the reason related to a status.
    /// </summary>
    public GenericIdentification30? Reason { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
