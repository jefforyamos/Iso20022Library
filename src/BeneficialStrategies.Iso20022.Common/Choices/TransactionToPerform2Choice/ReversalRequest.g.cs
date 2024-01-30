﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ReversalRequest.  ISO2002 ID# _ro9DxQxrEeqdx6buGpCCQw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform2Choice;

/// <summary>
/// Content of the Reversal Request message.
/// </summary>
public partial record ReversalRequest : ITransactionToPerform2Choice
{
    #nullable enable
    /// <summary>
    /// Original transaction to reverse.
    /// </summary>
    public CardPaymentTransaction100? OriginalPaymentTransaction { get; init; } 
    /// <summary>
    /// Reason for this reversal.
    /// </summary>
    public required ReversalReason1Code ReversalReason { get; init; } 
    /// <summary>
    /// Amount to reverse (total or partial).
    /// </summary>
    public IsoImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
    /// <summary>
    /// Specific Customer Order linked with the reversal.
    /// </summary>
    public CustomerOrder1? CustomerOrder { get; init; } 
    #nullable disable
}
