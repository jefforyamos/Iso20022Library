﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesTransactionPendingReportIdentification.  ISO2002 ID# _6EvMP5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References53Choice;

/// <summary>
/// Unambiguous identification of the report message to be cancelled.
/// </summary>
public partial record SecuritiesTransactionPendingReportIdentification : IReferences53Choice
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
