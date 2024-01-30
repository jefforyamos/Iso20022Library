﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PerformedTransaction2.  ISO2002 ID# _b8LzcQxsEeqdx6buGpCCQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of performed transactions.
/// </summary>
public partial record PerformedTransaction2
{
    #nullable enable
    
    /// <summary>
    /// Response for this performed transaction.
    /// </summary>
    public required ResponseType9 Response { get; init; } 
    /// <summary>
    /// Unique identification of a sale transaction.
    /// </summary>
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    public TransactionIdentifier1? POITransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the POI reconciliation period.
    /// </summary>
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 
    /// <summary>
    /// Data related to the result of a processed payment transaction.
    /// </summary>
    public RetailerPaymentResult2? PaymentResult { get; init; } 
    /// <summary>
    /// Data related to the result of a processed Loyalty transaction.
    /// </summary>
    public LoyaltyResult2? LoyaltyResult { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Amount of the payment or loyalty to reverse.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
    
    #nullable disable
}
