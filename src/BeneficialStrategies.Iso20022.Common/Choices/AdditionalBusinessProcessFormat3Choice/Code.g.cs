﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q10yxNp-Ed-ak6NoX_4Aeg_861159195.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalBusinessProcessFormat3Choice;

/// <summary>
/// Standard code to specify the additional business process "tax refund" linked to a corporate action event.
/// </summary>
public partial record Code : IAdditionalBusinessProcessFormat3Choice
{
    public required AdditionalBusinessProcess3Code Value { get; init; }
}
