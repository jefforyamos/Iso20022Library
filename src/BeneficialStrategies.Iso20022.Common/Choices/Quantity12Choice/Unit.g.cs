﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unit.  ISO2002 ID# _t8mOFPsrEeCUd_EZYqZ_Uw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity12Choice;

/// <summary>
/// Quantity of assets to be transferred.
/// </summary>
public partial record Unit : IQuantity12Choice
{
    public required IsoDecimalNumber Value { get; init; }
}
