﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesBalanceAccountingReportIdentification.  ISO2002 ID# _ts-sKQ34EeKN_Y-2Awiamw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References37Choice;

/// <summary>
/// Unambiguous identification of the report message to be cancelled.
/// </summary>
public partial record SecuritiesBalanceAccountingReportIdentification : IReferences37Choice
{
    public required IsoMax35Text Value { get; init; }
}
