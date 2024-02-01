﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction61.  ISO2002 ID# _yHkX2aOAEeeDTpy0mhI4TQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the transaction.
/// </summary>
public partial record Transaction61
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction other than the account owner the account servicer and the market infrastructure.
    /// </summary>
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; } 
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    public IsoMax35Text[] TradeIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    public IsoMax35Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    public IsoMax35Text? CommonIdentification { get; init; } 
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public IsoMax35Text? CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent's/service-provider's point of view.
    /// </summary>
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    public TransactionDetails104? TransactionDetails { get; init; } 
    
    #nullable disable
}
