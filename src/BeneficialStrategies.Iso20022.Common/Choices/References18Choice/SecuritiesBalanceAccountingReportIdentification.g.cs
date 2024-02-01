﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesBalanceAccountingReportIdentification.  ISO2002 ID# _9EijNz9mEeCuVfEpWlZb5g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References18Choice;

/// <summary>
/// Unambiguous identification of the report message to be cancelled.
/// </summary>
public partial record SecuritiesBalanceAccountingReportIdentification : References18Choice_
{
    public required IsoMax35Text Value { get; init; }
}
