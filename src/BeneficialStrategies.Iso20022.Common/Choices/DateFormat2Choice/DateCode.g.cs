﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DateCode.  ISO2002 ID# _RVH96tp-Ed-ak6NoX_4Aeg_1196051519.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat2Choice;

/// <summary>
/// Indicates that date and time are unknown.
/// </summary>
public partial record DateCode : IDateFormat2Choice
{
    public required DateType1Code Value { get; init; }
}
