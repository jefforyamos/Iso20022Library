﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesTransactionPostingReportIdentification.  ISO2002 ID# _KDxvwyAaEeu4a6pNulzZ4Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References71Choice;

/// <summary>
/// Unambiguous identification of the report message to be cancelled.
/// </summary>
public partial record SecuritiesTransactionPostingReportIdentification : References71Choice_
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
