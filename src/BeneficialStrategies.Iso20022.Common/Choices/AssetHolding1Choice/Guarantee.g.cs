﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Guarantee.  ISO2002 ID# _yMukYK_7EeaE9YROwd69hA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AssetHolding1Choice;

/// <summary>
/// Promise to meet the obligations of a clearing member provided by a third party.
/// </summary>
public partial record Guarantee : IAssetHolding1Choice
{
    #nullable enable
    /// <summary>
    /// Identification of guarantee provider.
    /// </summary>
    public required IPartyIdentification118Choice Provider { get; init; } 
    /// <summary>
    /// Value of the collateral guarantee.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    #nullable disable
}
