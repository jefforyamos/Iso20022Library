﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _7TP5EUHTEeasdbKMiqizqA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancelledReason12Choice;

/// <summary>
/// No reason available or to report for the cancelled status.
/// </summary>
public partial record NoSpecifiedReason : ICancelledReason12Choice
{
    public required NoReasonCode Value { get; init; }
}
