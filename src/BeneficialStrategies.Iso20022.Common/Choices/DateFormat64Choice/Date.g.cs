﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Date.  ISO2002 ID# _TtBUjV99Ee262vCSVgjImg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat64Choice;

/// <summary>
/// Date expressed as a calendar date.
/// </summary>
public partial record Date : DateFormat64Choice_
{
    public required IsoISODate Value { get; init; }
}
