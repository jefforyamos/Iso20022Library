﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedDate.  ISO2002 ID# _RlgjRdp-Ed-ak6NoX_4Aeg_-1279748182.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat4Choice;

/// <summary>
/// The date is not specified, eg, the date is unknown.
/// </summary>
public partial record NotSpecifiedDate : IDateFormat4Choice
{
    public required DateType6Code Value { get; init; }
}
