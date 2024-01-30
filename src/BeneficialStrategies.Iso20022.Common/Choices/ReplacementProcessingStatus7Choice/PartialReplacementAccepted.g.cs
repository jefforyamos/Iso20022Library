﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PartialReplacementAccepted.  ISO2002 ID# _A5TcBdokEeC60axPepSq7g_1826638997.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ReplacementProcessingStatus7Choice;

/// <summary>
/// Replacement of the trade is PartialReplacementAccepted.
/// </summary>
public partial record PartialReplacementAccepted : IReplacementProcessingStatus7Choice
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
