﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StartDate.  ISO2002 ID# _HwOT8FxSEeW8MLuBzR10cg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FiscalYear1Choice;

/// <summary>
/// Start date of the fiscal year.
/// </summary>
public partial record StartDate : IFiscalYear1Choice
{
    public required IsoISODate Value { get; init; }
}
