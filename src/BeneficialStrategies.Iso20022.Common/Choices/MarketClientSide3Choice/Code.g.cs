﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Aamt0tokEeC60axPepSq7g_-975714094.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MarketClientSide3Choice;

/// <summary>
/// Market side or a client side information expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IMarketClientSide3Choice
{
    public required MarketClientSideCode Value { get; init; }
}
