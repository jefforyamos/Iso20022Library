﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FromDateTime.  ISO2002 ID# _T5xr-Np-Ed-ak6NoX_4Aeg_1215657173.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateTimePeriodChoice;

/// <summary>
/// Date and time at which the range starts.
/// </summary>
public partial record FromDateTime : IDateTimePeriodChoice
{
    public required IsoISODateTime Value { get; init; }
}
