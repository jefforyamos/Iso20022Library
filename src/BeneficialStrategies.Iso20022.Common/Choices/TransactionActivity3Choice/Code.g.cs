﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ilsVYTqDEeWVrPy0StzzSg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionActivity3Choice;

/// <summary>
/// Transaction type expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ITransactionActivity3Choice
{
    public required TransactionActivity1Code Value { get; init; }
}
