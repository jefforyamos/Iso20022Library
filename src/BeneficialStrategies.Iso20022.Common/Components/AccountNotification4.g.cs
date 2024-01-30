﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountNotification4.  ISO2002 ID# _Gr9k4BGeEd-Obe88IjNoEg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the account notification.
/// </summary>
public partial record AccountNotification4
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account owner, to unambiguously identify the account notification.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    public CashAccount16? Account { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IParty12Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; } 
    /// <summary>
    /// Identifies the parent account of the account to be credited with the incoming amount of money.
    /// </summary>
    public CashAccount16? RelatedAccount { get; init; } 
    /// <summary>
    /// Sum of the amounts in all the Item entries.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; } 
    /// <summary>
    /// Date on which the first agent expects the cash to be available to the final agent.
    /// </summary>
    public IsoISODate? ExpectedValueDate { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public IParty12Choice? Debtor { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent { get; init; } 
    /// <summary>
    /// Provides details of the expected amount on the account serviced by the account servicer.
    /// </summary>
    public NotificationItem3? Item { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
