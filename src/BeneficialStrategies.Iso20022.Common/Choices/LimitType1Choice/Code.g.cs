﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _79FX8aMgEeCJ6YNENx4h-w_418078119.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LimitType1Choice;

/// <summary>
/// Type of the limit, in a coded form.
/// </summary>
public partial record Code : ILimitType1Choice
{
    public required LimitType3Code Value { get; init; }
}
