﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _oKLSddxKEd-tnM7aRm4nqg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ExposureType4Choice;

/// <summary>
/// Collateral movement exposure type expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IExposureType4Choice
{
    public required ExposureType2Code Value { get; init; }
}
