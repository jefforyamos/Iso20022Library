﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ReversalRequest.  ISO2002 ID# _xaZiVS8QEeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform3Choice;

/// <summary>
/// Content of the Reversal Request message.
/// </summary>
public partial record ReversalRequest : ITransactionToPerform3Choice
{
    #nullable enable
    /// <summary>
    /// Transaction to reverse.
    /// </summary>
    public CardPaymentTransaction110? ReversalTransaction { get; init; } 
    /// <summary>
    /// Data linked to card loyalty during payment.
    /// </summary>
    public LoyaltyRequestData2? LoyaltyData { get; init;  } // Warning: Don't know multiplicity.
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
