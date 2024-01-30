﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Repartition2.  ISO2002 ID# _j9wpsRQXEeKebsB9eKJSkA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates how the amount of the investment plan is split amongst the funds.
/// </summary>
public partial record Repartition2
{
    #nullable enable
    
    /// <summary>
    /// Percentage of amount invested in a funds.
    /// </summary>
    public required IsoPercentageRate Percentage { get; init; } 
    /// <summary>
    /// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
    /// </summary>
    public required FinancialInstrument29 FinancialInstrument { get; init; } 
    /// <summary>
    /// When a fund has multiple currencies within same ISIN, this indicates the currency of the savings or withdrawal plan.
    /// </summary>
    public CurrencyCode? CurrencyOfPlan { get; init; } 
    
    #nullable disable
}
