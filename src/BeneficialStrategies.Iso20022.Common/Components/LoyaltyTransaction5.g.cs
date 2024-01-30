﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyTransaction5.  ISO2002 ID# _Y8InMXGuEe2TbaNWBpRZpQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the loyalty transaction.
/// </summary>
public partial record LoyaltyTransaction5
{
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
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
    public CardPaymentTransaction127? OriginalPOITransaction { get; init; } 
    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    public Product6? SaleItem { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
