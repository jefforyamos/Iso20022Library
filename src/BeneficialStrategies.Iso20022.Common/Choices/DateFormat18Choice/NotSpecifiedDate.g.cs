﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedDate.  ISO2002 ID# _QhuyJeENEd-qUMZtd_eZuQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat18Choice;

/// <summary>
/// Date not specified, for example, the date is unknown.
/// </summary>
public partial record NotSpecifiedDate : IDateFormat18Choice
{
    public required DateType8Code Value { get; init; }
}
