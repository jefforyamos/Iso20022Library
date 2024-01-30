﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CancellationRequestIdentification.  ISO2002 ID# _Ad4rUdokEeC60axPepSq7g_2123239220.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference11Choice;

/// <summary>
/// Unambiguous identification of the cancellation request as known by the instructing party.
/// </summary>
public partial record CancellationRequestIdentification : IIdentificationReference11Choice
{
    public required IsoMax35Text Value { get; init; }
}
