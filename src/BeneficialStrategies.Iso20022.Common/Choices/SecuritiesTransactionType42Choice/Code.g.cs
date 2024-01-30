﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _KuGT1c30Eee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionType42Choice;

/// <summary>
/// Securities transaction type expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ISecuritiesTransactionType42Choice
{
    public required SecuritiesTransactionType20Code Value { get; init; }
}
