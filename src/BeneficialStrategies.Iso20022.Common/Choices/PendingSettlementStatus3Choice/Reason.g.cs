﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _LrsCYyY4EeW_ZNn8gbfY7Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingSettlementStatus3Choice;

/// <summary>
/// Reason for the settlement pending status.
/// </summary>
public partial record Reason : PendingSettlementStatus3Choice_
{
    public required PendingSettlementStatusReason2Code Value { get; init; }
}
