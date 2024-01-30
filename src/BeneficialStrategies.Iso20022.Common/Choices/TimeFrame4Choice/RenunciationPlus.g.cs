﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RenunciationPlus.  ISO2002 ID# _UAew69p-Ed-ak6NoX_4Aeg_500203194.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TimeFrame4Choice;

/// <summary>
/// An agreed number of days after the renunciation of title documents are received used to define standard timeframes in Redemption e.g R+3 Redemption settlement cycle.
/// </summary>
public partial record RenunciationPlus : ITimeFrame4Choice
{
    public required IsoNumber Value { get; init; }
}
