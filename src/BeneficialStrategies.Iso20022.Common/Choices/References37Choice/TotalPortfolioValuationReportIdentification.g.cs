﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TotalPortfolioValuationReportIdentification.  ISO2002 ID# _LL-j4A39EeKN_Y-2Awiamw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References37Choice;

/// <summary>
/// Unique identification of the report.
/// </summary>
public partial record TotalPortfolioValuationReportIdentification : IReferences37Choice
{
    public required IsoMax35Text Value { get; init; }
}
