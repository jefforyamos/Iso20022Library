﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PerAttendee.  ISO2002 ID# _RDiepNp-Ed-ak6NoX_4Aeg_1361394967.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IncentivePremiumType1Choice;

/// <summary>
/// Indicates that the premium is given per attendee.
/// </summary>
public partial record PerAttendee : IIncentivePremiumType1Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
