﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Date.  ISO2002 ID# _QmL0Qdp-Ed-ak6NoX_4Aeg_-415883940.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat15Choice;

/// <summary>
/// Date expressed as a calendar date.
/// </summary>
public partial record Date : DateFormat15Choice_
{
    public required IsoISODate Value { get; init; }
}
