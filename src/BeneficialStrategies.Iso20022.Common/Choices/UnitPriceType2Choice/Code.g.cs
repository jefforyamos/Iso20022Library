﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ORWfkQc_EeSyIPzOZ6VzBQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnitPriceType2Choice;

/// <summary>
///  Type of price expressed as a code.
/// </summary>
public partial record Code : IUnitPriceType2Choice
{
    public required TypeOfPrice10Code Value { get; init; }
}
