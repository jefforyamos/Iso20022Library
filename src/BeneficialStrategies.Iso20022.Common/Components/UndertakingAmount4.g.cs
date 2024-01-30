﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UndertakingAmount4.  ISO2002 ID# _945Ng3ltEeG7BsjMvd1mEw_1350790559.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defined variation amount and balance.
/// </summary>
public partial record UndertakingAmount4
{
    #nullable enable
    
    /// <summary>
    /// Variation amount and currency.
    /// </summary>
    public required IsoActiveCurrencyAndAmount VariationAmount { get; init; } 
    /// <summary>
    /// Calculated undertaking available balance amount resulting from the application of the variation amount.
    /// </summary>
    public IsoActiveCurrencyAndAmount? BalanceAmount { get; init; } 
    
    #nullable disable
}
