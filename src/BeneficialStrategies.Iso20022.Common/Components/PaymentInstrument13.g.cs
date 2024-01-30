﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentInstrument13.  ISO2002 ID# __Ai3oCC0EeWJd9HF2tO7BA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument used to process a payment instruction.
/// </summary>
public partial record PaymentInstrument13
{
    #nullable enable
    
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    public required ActiveCurrencyCode SettlementCurrency { get; init; } 
    /// <summary>
    /// Percentage of the dividend payment not to be reinvested, that is, to be paid in cash.
    /// </summary>
    public IsoPercentageBoundedRate? DividendPercentage { get; init; } 
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a subscription payment.
    /// </summary>
    public IPaymentInstrument18Choice? SubscriptionPaymentInstrument { get; init; } 
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a redemption payment.
    /// </summary>
    public IPaymentInstrument19Choice? RedemptionPaymentInstrument { get; init; } 
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a dividend payment.
    /// </summary>
    public IPaymentInstrument19Choice? DividendPaymentInstrument { get; init; } 
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a savings plan payment.
    /// </summary>
    public IPaymentInstrument18Choice? SavingsPlanPaymentInstrument { get; init; } 
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for an interest payment.
    /// </summary>
    public IPaymentInstrument19Choice? InterestPaymentInstrument { get; init; } 
    
    #nullable disable
}
