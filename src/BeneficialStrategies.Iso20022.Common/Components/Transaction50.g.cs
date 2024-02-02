﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction50.  ISO2002 ID# _8biE05NLEeWGlc8L7oPDIg.
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
public partial record Transaction50
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    [DataMember]
    public required IsoRestrictedFINXMax16Text AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax16Text? AccountServicerTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax16Text? MarketInfrastructureTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction other than the account owner the account servicer and the market infrastructure.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax16Text? ProcessorTransactionIdentification { get; init; } 
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [DataMember]
    public ValueList<IsoRestrictedFINXMax16Text> TradeIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax16Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax16Text? CommonIdentification { get; init; } 
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax16Text? CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the triparty agent's point of view.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax16Text? TripartyAgentCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax16Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax16Text? ClientCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the triparty agent.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax16Text? TripartyCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [DataMember]
    public TransactionDetails91? TransactionDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
