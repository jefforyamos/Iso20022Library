﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _d3GXAe3DEeqc-LCjwLsUVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateCode33Choice;

/// <summary>
/// Standard code to specify the type of date.
/// </summary>
public partial record Code : DateCode33Choice_
{
    public required DateType9Code Value { get; init; }
}
