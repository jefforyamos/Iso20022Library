﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentFundCashSettlementInformation7.  ISO2002 ID# _bGuAQRRfEeOKWo1NF21OVw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement instructions to be used to transfer cash from the debtor to the creditor.
/// </summary>
[DataContract]
[XmlType]
public partial record InvestmentFundCashSettlementInformation7
{
    #nullable enable
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a subscription payment.
    /// </summary>
    [DataMember]
    public PaymentInstrument11? SubscriptionPaymentInstrument { get; init; } 
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a redemption payment.
    /// </summary>
    [DataMember]
    public PaymentInstrument12? RedemptionPaymentInstrument { get; init; } 
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a dividend payment.
    /// </summary>
    [DataMember]
    public PaymentInstrument12? DividendPaymentInstrument { get; init; } 
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a savings plan payment.
    /// </summary>
    [DataMember]
    public PaymentInstrument11? SavingsPlanPaymentInstrument { get; init; } 
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for an interest payment.
    /// </summary>
    [DataMember]
    public PaymentInstrument12? InterestPaymentInstrument { get; init; } 
    
    #nullable disable
}
