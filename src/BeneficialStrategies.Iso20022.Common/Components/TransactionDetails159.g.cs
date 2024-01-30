﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDetails159.  ISO2002 ID# _eZPP9Di8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the details of the transaction.
/// </summary>
public partial record TransactionDetails159
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    public required SettlementTypeAndIdentification22 AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    public IsoRestrictedFINXMax16Text? AccountServicerTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    public IsoRestrictedFINXMax16Text? MarketInfrastructureTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction other than the account owner, the account servicer and the market infrastructure.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ProcessorTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of a transaction that cannot be identified using a standard reference element present in the message.
    /// </summary>
    public IsoRestrictedFINXMax16Text? OtherTransactionIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification156? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public SecuritiesAccount30? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    public BlockChainAddressWallet7? BlockChainAddressOrWallet { get; init; } 
    /// <summary>
    /// Provides additional details on the transaction which can not be included within the structured fields of the message.
    /// </summary>
    public TransactionDetails160? TransactionDetails { get; init; } 
    
    #nullable disable
}
