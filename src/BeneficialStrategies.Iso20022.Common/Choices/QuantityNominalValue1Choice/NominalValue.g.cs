﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NominalValue.  ISO2002 ID# _xcCRUHaiEeavseMKyTsJEA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.QuantityNominalValue1Choice;

/// <summary>
/// Total nominal amount of bonds (number of bonds multiplied by the face value).
/// </summary>
public partial record NominalValue : IQuantityNominalValue1Choice
{
    public required IsoActiveOrHistoricCurrencyAndAmount Value { get; init; }
}
