﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesSettlementTransactionAllegementReportIdentification.  ISO2002 ID# _Wkm3lUfGEey6Is2iMqV8fg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References79Choice;

/// <summary>
/// Unambiguous identification of the report to be cancelled.
/// </summary>
public partial record SecuritiesSettlementTransactionAllegementReportIdentification : IReferences79Choice
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
