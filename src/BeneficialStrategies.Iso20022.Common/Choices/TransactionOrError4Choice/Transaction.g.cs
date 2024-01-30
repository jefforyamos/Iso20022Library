﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Transaction.  ISO2002 ID# _XFBYs249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TransactionOrError4Choice;

/// <summary>
/// Requested information on the payment transaction.
/// </summary>
public partial record Transaction : ITransactionOrError4Choice
{
    #nullable enable
    /// <summary>
    /// Destination of the payment (be it a member or a system or both).
    /// </summary>
    public System2? PaymentTo { get; init; } 
    /// <summary>
    /// Origin of the payment (be it a member or a system or both).
    /// </summary>
    public System2? PaymentFrom { get; init; } 
    /// <summary>
    /// Indicates whether the payment transaction is a debit or credit transaction. |.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Instruction to pay an amount of money to an ultimate beneficiary, on behalf of an originator. This instruction may have to be forwarded several times to complete the settlement chain.|.
    /// </summary>
    public PaymentInstruction32? Payment { get; init; } 
    /// <summary>
    /// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
    /// </summary>
    public CashAccountAndEntry3? AccountEntry { get; init; } 
    /// <summary>
    /// Provides the references of the underlying securities transaction.
    /// </summary>
    public SecuritiesTransactionReferences1? SecuritiesTransactionReferences { get; init; } 
    #nullable disable
}
