﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unit.  ISO2002 ID# _SoH20tp-Ed-ak6NoX_4Aeg_144255614.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnitOrFaceAmountChoice;

/// <summary>
/// Quantity expressed as a number, eg, a number of shares.
/// </summary>
public partial record Unit : IUnitOrFaceAmountChoice
{
    public required IsoDecimalNumber Value { get; init; }
}
