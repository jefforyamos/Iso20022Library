﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _8VKXS5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TransactionActivity4Choice;

/// <summary>
/// Transaction type expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ITransactionActivity4Choice
{
    public required TransactionActivity1Code Value { get; init; }
}
