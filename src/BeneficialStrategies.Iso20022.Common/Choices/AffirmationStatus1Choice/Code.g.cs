﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UaaT2dp-Ed-ak6NoX_4Aeg_961869263.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AffirmationStatus1Choice;

/// <summary>
/// Provides the status of the trade at confirmation level at the time the settlement instruction was sent.
/// </summary>
public partial record Code : IAffirmationStatus1Choice
{
    public required AffirmationStatus1Code Value { get; init; }
}
