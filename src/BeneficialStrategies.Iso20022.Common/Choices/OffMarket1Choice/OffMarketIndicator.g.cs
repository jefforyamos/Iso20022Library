﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OffMarketIndicator.  ISO2002 ID# _TCpPodp-Ed-ak6NoX_4Aeg_2045804810.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OffMarket1Choice;

/// <summary>
/// Indicates that the trade was executed off-exchange.
/// </summary>
public partial record OffMarketIndicator : IOffMarket1Choice
{
    public required OffMarket1Code Value { get; init; }
}
