﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Cash.  ISO2002 ID# _9LXRoK_6EeaE9YROwd69hA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AssetHolding1Choice;

/// <summary>
/// Value of cash collateral.
/// </summary>
public partial record Cash : IAssetHolding1Choice
{
    public required IsoActiveCurrencyAndAmount Value { get; init; }
}
