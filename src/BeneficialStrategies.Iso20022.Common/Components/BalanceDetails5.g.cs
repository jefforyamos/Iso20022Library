﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BalanceDetails5.  ISO2002 ID# _m9_jw_NBEeCuA5Tr22BnwA_-1587495854.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance related details for a portfolio.
/// </summary>
public partial record BalanceDetails5
{
    #nullable enable
    
    /// <summary>
    /// Balance type.
    /// </summary>
    public required BalanceType6Choice_ Type { get; init; } 
    /// <summary>
    /// Unrealised gain or loss.
    /// </summary>
    public Unrealised1Code? Unrealised { get; init; } 
    /// <summary>
    /// Balance amount.
    /// </summary>
    public required AmountAndDirection31 Amount { get; init; } 
    /// <summary>
    /// Detailed balance information.
    /// </summary>
    public BalanceDetails6[] DetailedBalance { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
