﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TotalPortfolioValuationReportIdentification.  ISO2002 ID# _6EvMTZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References53Choice;

/// <summary>
/// Unique identification of the report.
/// </summary>
public partial record TotalPortfolioValuationReportIdentification : References53Choice_
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
