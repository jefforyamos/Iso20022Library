﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ChargesRecord4.  ISO2002 ID# _CJG0EadFEeqY6dwgI6s5vg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further individual record details on the charges related to the payment transaction.
/// </summary>
public partial record ChargesRecord4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the charges record for reconciliation purpose.
    /// Usage: this identification shall be used as the end-to-end identification in the resulting message for the payment of the charges, to allow for automated reconciliation. 
    /// </summary>
    public IsoMax35Text? ChargesRecordIdentification { get; init; } 
    /// <summary>
    /// Identifies the underlying transaction(s) to which the charges apply.
    /// </summary>
    public TransactionReferences7[] UnderlyingTransaction { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Amount of transaction charges to be paid by the charge bearer.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates whether the charges amount is a credit or a debit amount. |Usage: A zero amount is considered to be a credit.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Date and time at which the charges are or will be available.
    /// </summary>
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    /// <summary>
    /// Specifies the debtor agent of the initial transaction, if different from the charges account owner.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; } 
    /// <summary>
    /// Specifies the account of the debtor agent of the initial transaction, when instructing agent is different from the charges account owner.
    /// </summary>
    public CashAccount40? DebtorAgentAccount { get; init; } 
    /// <summary>
    /// Identifies the account that has been debited or credited for the charges, interest or other
    /// adjustment(s).
    /// </summary>
    public required CashAccount40 ChargesAccount { get; init; } 
    /// <summary>
    /// Agent that owns the charges account.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountOwner { get; init; } 
    /// <summary>
    /// Specifies the type of charge.
    /// </summary>
    public ChargeType3Choice_? Type { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment adjustment instruction that may need to be acted upon by the next agent. 
    /// </summary>
    public InstructionForInstructedAgent1? InstructionForInstructedAgent { get; init; } 
    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    public IsoMax140Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
