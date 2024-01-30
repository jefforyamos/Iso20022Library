﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalItemReference6.  ISO2002 ID# _b9qOodcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further means of referencing a payment transaction.
/// </summary>
public partial record OriginalItemReference6
{
    #nullable enable
    
    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    public CashAccount40? Account { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IParty40Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; } 
    /// <summary>
    /// Identifies the parent account of the account to be credited with the incoming amount of money.
    /// </summary>
    public CashAccount40? RelatedAccount { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public IParty40Choice? Debtor { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; } 
    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent { get; init; } 
    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    public IPurpose2Choice? Purpose { get; init; } 
    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    public RemittanceLocation7? RelatedRemittanceInformation { get; init; } 
    /// <summary>
    /// Structured information that enables the matching, that is reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    public RemittanceInformation21? RemittanceInformation { get; init; } 
    
    #nullable disable
}
