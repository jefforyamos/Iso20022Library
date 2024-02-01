﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraBalanceMovements3.  ISO2002 ID# _YDGlJTneEem7JZMuWtwtsg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the intra-balance movements in the report.
/// </summary>
public partial record IntraBalanceMovements3
{
    #nullable enable
    
    /// <summary>
    /// Account to or from which an entry is made.
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
    /// Further details on the individual intrabalance movement transaction.
    /// </summary>
    public IntraBalanceMovement5[] Movement { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
