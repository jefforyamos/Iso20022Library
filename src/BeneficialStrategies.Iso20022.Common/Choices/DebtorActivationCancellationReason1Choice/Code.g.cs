﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _bjMUfvGAEemQ7oqCO5NTQw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DebtorActivationCancellationReason1Choice;

/// <summary>
/// Reason, as published in an external reason code list.
/// </summary>
public partial record Code : DebtorActivationCancellationReason1Choice_
{
    public required ExternalDebtorActivationCancellationReason1Code Value { get; init; }
}
