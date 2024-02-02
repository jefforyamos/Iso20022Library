﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyTransactionTotals1.  ISO2002 ID# _XpAh0NxiEeioifFt1dhnJA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction totals during the reconciliation period, for a certain type of transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record LoyaltyTransactionTotals1
{
    #nullable enable
    
    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI terminals performing some categories of transactions.
    /// </summary>
    [DataMember]
    public IsoMax35Text? POIGroupIdentification { get; init; } 
    /// <summary>
    /// Unit of the amount, expressed in point or in a monetary value and a currency.
    /// </summary>
    [DataMember]
    public AmountUnit1Code? LoyaltyUnit { get; init; } 
    /// <summary>
    /// Cards category related to the acceptance processing rules defined by the Loyalty provider.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CardProductProfile { get; init; } 
    /// <summary>
    /// Currency associated with the transaction totals.
    /// </summary>
    [DataMember]
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Type of Loyalty transaction for Report.
    /// </summary>
    [DataMember]
    public required LoyaltyTypeTransactionTotals1Code TransactionType { get; init; } 
    /// <summary>
    /// Total number of transactions during a reconciliation period.
    /// </summary>
    [DataMember]
    public required IsoNumber TotalNumber { get; init; } 
    /// <summary>
    /// Total amount of a collection of transactions.
    /// </summary>
    [DataMember]
    public required IsoImpliedCurrencyAndAmount CumulativeAmount { get; init; } 
    /// <summary>
    /// Detailed amounts associated with the total amount of transactions.
    /// </summary>
    [DataMember]
    public DetailedAmount15? DetailedAmount { get; init; } 
    
    #nullable disable
}
