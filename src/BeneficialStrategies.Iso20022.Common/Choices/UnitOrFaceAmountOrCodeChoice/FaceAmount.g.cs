﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FaceAmount.  ISO2002 ID# _Sokixtp-Ed-ak6NoX_4Aeg_1106804711.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnitOrFaceAmountOrCodeChoice;

/// <summary>
/// Quantity expressed as an amount representing the face amount, ie, the principal, of a debt instrument.
/// </summary>
public partial record FaceAmount : IUnitOrFaceAmountOrCodeChoice
{
    public required IsoCurrencyAndAmount Value { get; init; }
}
