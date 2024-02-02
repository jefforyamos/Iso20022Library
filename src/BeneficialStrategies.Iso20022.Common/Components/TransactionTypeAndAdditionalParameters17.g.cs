﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionTypeAndAdditionalParameters17.  ISO2002 ID# _vq1XEY7YEeaa5_S8lsRKCQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// </summary>
[DataContract]
[XmlType]
public partial record TransactionTypeAndAdditionalParameters17
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction (unique per piece of collateral) as known by the account owner (or the instructing party managing the account).
    /// </summary>
    [DataMember]
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction (unique per piece of collateral) as known by the account servicer.
    /// </summary>
    [DataMember]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; } 
    /// <summary>
    /// Specifies the type of securities financing transaction, that is, repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing.
    /// </summary>
    [DataMember]
    public required SecuritiesFinancingTransactionType2Code SecuritiesFinancingTransactionType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [DataMember]
    public required DeliveryReceiptType2Code Payment { get; init; } 
    /// <summary>
    /// Identifies the type of securities financing modification requested.
    /// </summary>
    [DataMember]
    public RepurchaseType21Choice_? ModificationType { get; init; } 
    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CommonIdentification { get; init; } 
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [DataMember]
    public IsoMax35Text? PoolIdentification { get; init; } 
    
    #nullable disable
}
