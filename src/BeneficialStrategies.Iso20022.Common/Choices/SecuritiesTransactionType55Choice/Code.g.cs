﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _qIKqfffYEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionType55Choice;

/// <summary>
/// Securities transaction type expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ISecuritiesTransactionType55Choice
{
    public required SecuritiesTransactionType22Code Value { get; init; }
}
