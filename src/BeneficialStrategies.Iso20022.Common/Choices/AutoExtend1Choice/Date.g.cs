﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Date.  ISO2002 ID# _95fqc3ltEeG7BsjMvd1mEw_1257935176.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AutoExtend1Choice;

/// <summary>
/// Auto extension end date.
/// </summary>
public partial record Date : IAutoExtend1Choice
{
    public required IsoISODate Value { get; init; }
}
