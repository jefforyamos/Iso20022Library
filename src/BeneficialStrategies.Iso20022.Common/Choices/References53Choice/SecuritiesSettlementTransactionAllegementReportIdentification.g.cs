﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesSettlementTransactionAllegementReportIdentification.  ISO2002 ID# _6EvMQ5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References53Choice;

/// <summary>
/// Unambiguous identification of the report to be cancelled.
/// </summary>
public partial record SecuritiesSettlementTransactionAllegementReportIdentification : References53Choice_
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
