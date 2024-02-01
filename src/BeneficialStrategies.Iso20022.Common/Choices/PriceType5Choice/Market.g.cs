﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Market.  ISO2002 ID# _SKL8Dc3yEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceType5Choice;

/// <summary>
/// Last reported price of a financial instrument in a market, determined by supply and demand.
/// </summary>
public partial record Market : PriceType5Choice_
{
    #nullable enable
    /// <summary>
    /// Specification of the price type.
    /// </summary>
    public required YieldedOrValueType1Choice_ Type { get; init; } 
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    public required PriceRateOrAmount1Choice_ Value { get; init; } 
    #nullable disable
}
