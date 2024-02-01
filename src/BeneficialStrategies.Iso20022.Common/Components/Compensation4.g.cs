﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Compensation4.  ISO2002 ID# _bq8G4dcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of a payment compensation.
/// </summary>
public partial record Compensation4
{
    #nullable enable
    
    /// <summary>
    /// Amount of money to be paid in compensation.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// Usage: The debtor agent is the payer of the compensation amount.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? DebtorAgentAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// Usage: The creditor agent is the payee of the compensation amount.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    public CashAccount40? CreditorAgentAccount { get; init; } 
    /// <summary>
    /// Reason for the payment compensation.
    /// </summary>
    public required CompensationReason1Choice_ Reason { get; init; } 
    
    #nullable disable
}
