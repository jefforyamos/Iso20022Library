﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RenunciationPlus.  ISO2002 ID# _UAyS4Np-Ed-ak6NoX_4Aeg_348286018.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Timeframe2Choice;

/// <summary>
/// An agreed number of days after the renunciation of title documents are received used to define standard timeframes in Redemption e.g R+3 Redemption settlement cycle.
/// </summary>
public partial record RenunciationPlus : ITimeframe2Choice
{
    public required IsoNumber Value { get; init; }
}
