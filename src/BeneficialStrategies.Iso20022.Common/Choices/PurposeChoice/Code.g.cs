﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Rbhg19p-Ed-ak6NoX_4Aeg_-1761336447.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PurposeChoice;

/// <summary>
/// Specifies the type of transaction that resulted in the payment initiation in coded form.
/// </summary>
public partial record Code : PurposeChoice_
{
    public required PaymentPurpose1Code Value { get; init; }
}
