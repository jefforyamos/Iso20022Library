﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Ac1ic9okEeC60axPepSq7g_-1423568581.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketType12Choice;

/// <summary>
/// Market type expressed as an ISO 20022 code.
/// </summary>
public partial record Code : MarketType12Choice_
{
    public required MarketType2Code Value { get; init; }
}
