﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Market.  ISO2002 ID# _RdnLhtp-Ed-ak6NoX_4Aeg_-394309489.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceType1Choice;

/// <summary>
/// Last reported price of a financial instrument in a market, determined by supply and demand.
/// </summary>
public partial record Market : IPriceType1Choice
{
    #nullable enable
    /// <summary>
    /// Specification of the price type.
    /// </summary>
    public required IYieldedOrValueType1Choice Type { get; init; } 
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    public required IPriceRateOrAmountChoice Value { get; init; } 
    #nullable disable
}
