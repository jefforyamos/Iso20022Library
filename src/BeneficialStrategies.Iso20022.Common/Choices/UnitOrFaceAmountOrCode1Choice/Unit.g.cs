﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unit.  ISO2002 ID# _SoH219p-Ed-ak6NoX_4Aeg_361302789.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnitOrFaceAmountOrCode1Choice;

/// <summary>
/// Quantity expressed as a number, eg, a number of shares.
/// </summary>
public partial record Unit : UnitOrFaceAmountOrCode1Choice_
{
    public required IsoDecimalNumber Value { get; init; }
}
