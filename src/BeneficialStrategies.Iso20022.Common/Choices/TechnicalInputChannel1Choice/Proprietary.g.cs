﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _Rpr4o9p-Ed-ak6NoX_4Aeg_-450061832.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TechnicalInputChannel1Choice;

/// <summary>
/// Technical channel used to input the instruction, in a proprietary form.
/// </summary>
public partial record Proprietary : ITechnicalInputChannel1Choice
{
    public required IsoMax35Text Value { get; init; }
}
