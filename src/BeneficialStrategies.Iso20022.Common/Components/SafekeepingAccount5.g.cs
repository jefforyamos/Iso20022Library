﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SafekeepingAccount5.  ISO2002 ID# _0mLLh4jyEeONZKAAW4pOaQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account on which a securities entry is made.
/// </summary>
public partial record SafekeepingAccount5
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public required PartyIdentification100 AccountOwner { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public required PartyIdentification100 AccountServicer { get; init; } 
    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    public BeneficialOwner2[] BeneficialOwner { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Report on the net position of a financial instrument, on the account, for a certain date.
    /// </summary>
    public AggregateHoldingBalance1[] BalanceForAccount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Agent of the financial instrument, for example, the transfer agent.
    /// </summary>
    public Intermediary28? Agent { get; init; } 
    /// <summary>
    /// Holdings of level 1.
    /// </summary>
    public AccountSubLevel1[] AccountSubLevel1 { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Difference in holdings between the safekeeping account and the sub-accounts of level 1.
    /// </summary>
    public AggregateHoldingBalance2[] AccountSubLevel1Difference { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
