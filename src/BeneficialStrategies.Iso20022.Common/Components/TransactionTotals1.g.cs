﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionTotals1.  ISO2002 ID# _TGSgYwEcEeCQm6a_G2yO_w_12313043.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction totals during the reconciliation period, for a certain type of transaction.
/// </summary>
public partial record TransactionTotals1
{
    #nullable enable
    
    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI terminals performing some categories of transactions.
    /// </summary>
    public IsoMax35Text? POIGroupIdentification { get; init; } 
    /// <summary>
    /// Category of cards related the acceptance processing rules defined by the acquirer.
    /// </summary>
    public IsoExact4NumericText? CardProductProfile { get; init; } 
    /// <summary>
    /// Currency associated with the transaction totals.
    /// </summary>
    public CurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Identification of the type of transaction.
    /// </summary>
    public required TypeTransactionTotals1Code Type { get; init; } 
    /// <summary>
    /// Total number of transactions during a reconciliation period.
    /// </summary>
    public required IsoMax35NumericText TotalNumber { get; init; } 
    /// <summary>
    /// Total amount of a collection of transactions.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount CumulativeAmount { get; init; } 
    
    #nullable disable
}
