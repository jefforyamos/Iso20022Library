﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _PrK9gtp-Ed-ak6NoX_4Aeg_-607853495.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Purpose1Choice;

/// <summary>
/// User community specific purpose.||Usage: When available, codes provided by local communities should be used.
/// </summary>
public partial record Proprietary : IPurpose1Choice
{
    public required IsoMax35Text Value { get; init; }
}
