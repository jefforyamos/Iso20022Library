﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QmxqINp-Ed-ak6NoX_4Aeg_-132072527.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralCancellationType1Choice;

/// <summary>
/// Provides the cancellation reason using an ISO 20022 code.
/// </summary>
public partial record Code : ICollateralCancellationType1Choice
{
    public required CollateralManagementCancellationReason1Code Value { get; init; }
}
