﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _qwMnsdYYEeiHVOfMzoKxnA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionType47Choice;

/// <summary>
/// Securities transaction type expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ISecuritiesTransactionType47Choice
{
    public required SecuritiesTransactionType23Code Value { get; init; }
}
