﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnderlyingTradeTransaction1.  ISO2002 ID# _96PRVnltEeG7BsjMvd1mEw_-533314240.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a transaction.
/// </summary>
public partial record UnderlyingTradeTransaction1
{
    #nullable enable
    
    /// <summary>
    /// Type of underlying transaction such as a tender, order, contract.
    /// </summary>
    public required IUnderlyingTradeTransactionType1Choice Type { get; init; } 
    /// <summary>
    /// Identification of the underlying transaction.
    /// </summary>
    public IsoMax35Text? Identification { get; init; } 
    /// <summary>
    /// Date the underlying transaction was issued or awarded.
    /// </summary>
    public IsoISODate? TransactionDate { get; init; } 
    /// <summary>
    /// Date the tender closes.
    /// </summary>
    public IsoISODate? TenderClosingDate { get; init; } 
    /// <summary>
    /// Amount of the underlying transaction.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    /// <summary>
    /// Percentage of the underlying contract covered by the undertaking.
    /// </summary>
    public IsoPercentageRate? ContractAmountPercentage { get; init; } 
    /// <summary>
    /// Additional information related to the underlying transaction.
    /// </summary>
    public IReadOnlyCollection<IsoMax2000Text> AdditionalInformation { get; init; } = [];
    
    #nullable disable
}
