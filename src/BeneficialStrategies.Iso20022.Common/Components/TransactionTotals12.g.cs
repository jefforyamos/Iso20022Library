﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionTotals12.  ISO2002 ID# _w-XjQSpSEeuUucRY0yCMTA.
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
public partial record TransactionTotals12
{
    #nullable enable
    
    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI terminals performing some categories of transactions.
    /// </summary>
    [DataMember]
    public IsoMax35Text? POIGroupIdentification { get; init; } 
    /// <summary>
    /// Brand name of the card.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CardBrand { get; init; } 
    /// <summary>
    /// Category of cards related the acceptance processing rules defined by the acquirer.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CardProductProfile { get; init; } 
    /// <summary>
    /// Currency associated with the transaction totals.
    /// </summary>
    [DataMember]
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Identification of the type of transaction.
    /// </summary>
    [DataMember]
    public required TypeTransactionTotals2Code Type { get; init; } 
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
    
    #nullable disable
}
