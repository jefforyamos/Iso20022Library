﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherUnitOfMeasure.  ISO2002 ID# _ZrCckBraEeOVR9VN6fAMUg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnitOfMeasure3Choice;

/// <summary>
/// Identifies the unit of measure not present in the code list.
/// </summary>
public partial record OtherUnitOfMeasure : UnitOfMeasure3Choice_
{
    public required IsoMax35Text Value { get; init; }
}
