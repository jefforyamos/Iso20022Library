﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PerAttendee.  ISO2002 ID# _vMYu9fNBEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IncentivePremiumType2Choice;

/// <summary>
/// Indicates that the premium is given per attendee.
/// </summary>
public partial record PerAttendee : IIncentivePremiumType2Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
