﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Hx_vwTqLEeWVrPy0StzzSg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeDateCode3Choice;

/// <summary>
/// Trade date expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ITradeDateCode3Choice
{
    public required DateType3Code Value { get; init; }
}
