﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ShortNumber.  ISO2002 ID# _dPmKtZBgEeakHoV5BVecAQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DocumentNumber17Choice;

/// <summary>
/// Message type number of the document referenced.
/// </summary>
public partial record ShortNumber : DocumentNumber17Choice_
{
    public required IsoExact3NumericText Value { get; init; }
}
