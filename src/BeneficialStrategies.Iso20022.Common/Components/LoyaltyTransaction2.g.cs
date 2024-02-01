﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyTransaction2.  ISO2002 ID# _F20XYQ0zEeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the Loyalty Transaction.
/// </summary>
public partial record LoyaltyTransaction2
{
    #nullable enable
    
    /// <summary>
    /// Data related to the loyalty transaction.
    /// </summary>
    public required LoyaltyTransactionType1Code LoyaltyTransactionType { get; init; } 
    /// <summary>
    /// Currency of the loyalty transaction.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Amount of the payment transaction related to the Loyalty.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    /// <summary>
    /// Data of a previous POI payment transaction.
    /// </summary>
    public CardPaymentTransaction100? OriginalPOITransaction { get; init; } 
    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    public Product6[] SaleItem { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
