﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FromDateTime.  ISO2002 ID# _7Gq0kX3sEeibM9CPDGCw0g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DateTimeSearch2Choice;

/// <summary>
/// Start date of the range.
/// </summary>
public partial record FromDateTime : IDateTimeSearch2Choice
{
    public required IsoISODateTime Value { get; init; }
}
