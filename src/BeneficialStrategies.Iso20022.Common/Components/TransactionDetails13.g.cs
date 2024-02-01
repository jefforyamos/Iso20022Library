﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDetails13.  ISO2002 ID# _UdigWNp-Ed-ak6NoX_4Aeg_-2016914974.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the details of the transaction.
/// </summary>
public partial record TransactionDetails13
{
    #nullable enable
    
    /// <summary>
    /// Provides transaction type and identification information.
    /// </summary>
    public required SettlementTypeAndIdentification3 AccountServicerTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    public Identification1? MarketInfrastructureTransactionIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification13Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public required SecuritiesAccount13 SafekeepingAccount { get; init; } 
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    public TransactionDetails10? TransactionDetails { get; init; } 
    
    #nullable disable
}
