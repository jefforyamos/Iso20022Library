﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _durwodEfEeiO-eodGv5iKQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionType43Choice;

/// <summary>
/// Securities transaction type expressed as an ISO 20022 code.
/// </summary>
public partial record Code : SecuritiesTransactionType43Choice_
{
    public required SecuritiesTransactionType25Code Value { get; init; }
}
