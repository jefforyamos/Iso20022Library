﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ZWOBQO3NEeqc-LCjwLsUVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BidRangeType1Choice;

/// <summary>
/// Bid range type expressed as a code value.
/// </summary>
public partial record Code : IBidRangeType1Choice
{
    public required BidRangeType1Code Value { get; init; }
}
