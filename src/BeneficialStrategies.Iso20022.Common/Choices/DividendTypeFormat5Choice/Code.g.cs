﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _debt0yXfEeO4bIO_HtGo9Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DividendTypeFormat5Choice;

/// <summary>
/// Standard code to specify the frequency of the corporate action event.
/// </summary>
public partial record Code : IDividendTypeFormat5Choice
{
    public required CorporateActionFrequencyType3Code Value { get; init; }
}
