﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SafekeepingAccountAndHoldings.  ISO2002 ID# _MM9hY_NyEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Disclosure2Choice;

/// <summary>
/// Details of the account, account sub-levels and holdings.
/// </summary>
public partial record SafekeepingAccountAndHoldings : IDisclosure2Choice
{
    #nullable enable
    /// <summary>
    /// Account where financial instruments are maintained. Account held by the responding intermediary with its account servicer.
    /// </summary>
    public required IsoMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is, manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public required IPartyIdentification195Choice AccountServicer { get; init; } 
    /// <summary>
    /// Number of shares held by the responding intermediary on its own account.
    /// </summary>
    public required IFinancialInstrumentQuantity18Choice ShareholdingBalanceOnOwnAccount { get; init; } 
    /// <summary>
    /// Number of shares held by the responding intermediary on account of someone else.
    /// </summary>
    public required IFinancialInstrumentQuantity18Choice ShareholdingBalanceOnClientAccount { get; init; } 
    /// <summary>
    /// Total number of shares held by the responding intermediary.
    /// </summary>
    public required IFinancialInstrumentQuantity18Choice TotalShareholdingBalance { get; init; } 
    /// <summary>
    /// Shareholdings information at account sub level.
    /// </summary>
    public AccountSubLevel22? AccountSubLevel { get; init; } 
    #nullable disable
}
