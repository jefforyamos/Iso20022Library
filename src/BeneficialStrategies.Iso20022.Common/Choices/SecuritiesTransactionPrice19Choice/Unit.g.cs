﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unit.  ISO2002 ID# _ijNt4MgqEeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice19Choice;

/// <summary>
/// Price expressed in units.
/// </summary>
public partial record Unit : ISecuritiesTransactionPrice19Choice
{
    public required IsoLongFraction19DecimalNumber Value { get; init; }
}
