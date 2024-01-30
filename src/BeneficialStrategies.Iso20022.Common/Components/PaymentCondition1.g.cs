﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentCondition1.  ISO2002 ID# _BmRRkHVjEeiEU7thYTAN1w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the conditions for the execution of the payment.
/// </summary>
public partial record PaymentCondition1
{
    #nullable enable
    
    /// <summary>
    /// Indicates if the debtor is allowed to pay a different amount then the requested amount.
    /// </summary>
    public required IsoTrueFalseIndicator AmountModificationAllowed { get; init; } 
    /// <summary>
    /// Indicates if the debtor is allowed to pay before the requested execution date.
    /// </summary>
    public required IsoTrueFalseIndicator EarlyPaymentAllowed { get; init; } 
    /// <summary>
    /// Penalty to be applied for a delayed payment, that is when the payment is made after the requested execution date.
    /// </summary>
    public IsoMax140Text? DelayPenalty { get; init; } 
    /// <summary>
    /// Discount rate applied for immediate payment upon receipt of the request.
    /// </summary>
    public IAmountOrRate1Choice? ImmediatePaymentRebate { get; init; } 
    /// <summary>
    /// Indicates if a payment guarantee is requested, assuming a payment guarantee contract exists between the different actors.
    /// </summary>
    public required IsoTrueFalseIndicator GuaranteedPaymentRequested { get; init; } 
    
    #nullable disable
}
