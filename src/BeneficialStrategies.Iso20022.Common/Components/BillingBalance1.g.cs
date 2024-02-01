﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BillingBalance1.  ISO2002 ID# _6SL4XZqlEeGSON8vddiWzQ_313331951.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the balance for the billing services.
/// </summary>
public partial record BillingBalance1
{
    #nullable enable
    
    /// <summary>
    /// Defines the type of balance.
    /// </summary>
    public required BillingBalanceType1Choice_ Type { get; init; } 
    /// <summary>
    /// Balance value.
    /// </summary>
    public required AmountAndDirection34 Value { get; init; } 
    /// <summary>
    /// Identifies the currency type used to report the balance. This is not the ISO code.
    /// </summary>
    public BillingCurrencyType1Code? CurrencyType { get; init; } 
    
    #nullable disable
}
