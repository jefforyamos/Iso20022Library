﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Yield.  ISO2002 ID# _nspF0MgqEeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice19Choice;

/// <summary>
/// Price expressed as a yield.
/// </summary>
public partial record Yield : SecuritiesTransactionPrice19Choice_
{
    public required IsoPercentageRate Value { get; init; }
}
