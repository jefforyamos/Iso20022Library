﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _dr9yYEeIEeSzluxs8tdrVw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MarketType13Choice;

/// <summary>
/// Market type expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IMarketType13Choice
{
    public required MarketType8Code Value { get; init; }
}
