﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Modifications.  ISO2002 ID# _Z496kTneEem7JZMuWtwtsg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.IntraBalanceOrOperationalError8Choice;

/// <summary>
/// Further details of the intrabalance modification transactions.
/// </summary>
public partial record Modifications : IIntraBalanceOrOperationalError8Choice
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
    public IProcessingStatus71Choice? ProcessingStatus { get; init; } 
    /// <summary>
    /// Further details of the individual intrabalance modification transaction.
    /// </summary>
    public IntraBalanceModification6? Modification { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
