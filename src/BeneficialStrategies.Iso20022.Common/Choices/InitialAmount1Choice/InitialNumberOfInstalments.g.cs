﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for InitialNumberOfInstalments.  ISO2002 ID# _XuNrcSDaEeWCLu74WLgP4w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InitialAmount1Choice;

/// <summary>
/// Number of pre-paid instalment periods at the time the investment plan is created.
/// </summary>
public partial record InitialNumberOfInstalments : IInitialAmount1Choice
{
    public required IsoNumber Value { get; init; }
}
