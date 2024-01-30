﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransactionAmounts3.  ISO2002 ID# _awno0Yq2EeSIDtZ76p6McQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit of amounts for the customer.
/// </summary>
public partial record ATMTransactionAmounts3
{
    #nullable enable
    
    /// <summary>
    /// Type of limit.
    /// </summary>
    public required IsoMax35Text Type { get; init; } 
    /// <summary>
    /// Label of the limit to display or print.
    /// </summary>
    public IsoMax35Text? Label { get; init; } 
    /// <summary>
    /// Currency of the limit amount.
    /// </summary>
    public required ActiveCurrencyCode Currency { get; init; } 
    /// <summary>
    /// Minimum amount value in the currency of the limit.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? MinimumAmount { get; init; } 
    /// <summary>
    /// Maximum amount value in the currency of the limit.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? MaximumAmount { get; init; } 
    
    #nullable disable
}
