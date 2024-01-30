﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraBalanceMovement5.  ISO2002 ID# _YN1OfzneEem7JZMuWtwtsg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the intra-balance movements data.
/// </summary>
public partial record IntraBalanceMovement5
{
    #nullable enable
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public CashAccount38? CashAccount { get; init; } 
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    public SystemPartyIdentification8? CashAccountOwner { get; init; } 
    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    /// <summary>
    /// Status and status reason of the transaction.
    /// </summary>
    public IntraBalanceStatusAndReason2? StatusAndReason { get; init; } 
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
    /// Identification of the transaction as assigned by the processor.
    /// </summary>
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; } 
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    public IsoMax35Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public IsoMax35Text? CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Identifies additional details of the transaction.
    /// </summary>
    public IntraBalanceMovement6? MovementDetails { get; init; } 
    
    #nullable disable
}
