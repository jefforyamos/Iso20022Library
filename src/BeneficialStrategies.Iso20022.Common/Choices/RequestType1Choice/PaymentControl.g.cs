﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PaymentControl.  ISO2002 ID# _RZlnJ9p-Ed-ak6NoX_4Aeg_-533116355.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RequestType1Choice;

/// <summary>
/// Request type is a control command on a set of transactions.
/// </summary>
public partial record PaymentControl : IRequestType1Choice
{
    public required RequestType1Code Value { get; init; }
}
