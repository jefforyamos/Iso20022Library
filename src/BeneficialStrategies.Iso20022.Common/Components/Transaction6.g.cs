﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction6.  ISO2002 ID# _UTaT-9p-Ed-ak6NoX_4Aeg_-954379001.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the details of the transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record Transaction6
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    [DataMember]
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    [DataMember]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [DataMember]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; } 
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax35Text> TradeIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [DataMember]
    public IsoMax35Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CommonIdentification { get; init; } 
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the triparty agent's point of view.
    /// </summary>
    [DataMember]
    public IsoMax35Text? TripartyAgentCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [DataMember]
    public TransactionDetails6? TransactionDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [DataMember]
    public ValueList<Extension2> Extension { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
