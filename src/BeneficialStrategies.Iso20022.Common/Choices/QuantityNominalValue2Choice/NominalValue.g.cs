﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NominalValue.  ISO2002 ID# _b3cSo8pbEem6kd3Y9uIDqg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.QuantityNominalValue2Choice;

/// <summary>
/// Total nominal amount of bonds (number of bonds multiplied by the face value).
/// </summary>
public partial record NominalValue : IQuantityNominalValue2Choice
{
    #nullable enable
    /// <summary>
    /// Amount of money that results in an increase (positively signed) or decrease (negatively signed), with specification of the currency.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates that the amount value is positive or negative.
    /// Usage: When absent, the amount is positive.
    /// </summary>
    public IsoPlusOrMinusIndicator? Sign { get; init; } 
    #nullable disable
}
