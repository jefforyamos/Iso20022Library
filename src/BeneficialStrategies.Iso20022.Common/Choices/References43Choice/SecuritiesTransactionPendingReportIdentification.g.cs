﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesTransactionPendingReportIdentification.  ISO2002 ID# _5pbMczqnEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References43Choice;

/// <summary>
/// Unambiguous identification of the report message to be cancelled.
/// </summary>
public partial record SecuritiesTransactionPendingReportIdentification : IReferences43Choice
{
    public required IsoMax35Text Value { get; init; }
}
