﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _NzE0NzQ4-AOSNFX-5096945.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeMarket1Choice;

/// <summary>
/// Standard trade market code.
/// </summary>
public partial record Code : TradeMarket1Choice_
{
    public required ExternalTradeMarket1Code Value { get; init; }
}
