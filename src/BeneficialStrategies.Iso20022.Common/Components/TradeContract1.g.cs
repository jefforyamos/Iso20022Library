﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeContract1.  ISO2002 ID# _1lQO0NLJEeSdq5yU2aaSNw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Agreement between the parties, stipulating the terms and conditions of the delivery of goods or services.
/// </summary>
public partial record TradeContract1
{
    #nullable enable
    
    /// <summary>
    /// Contract document referenced from this trade agreement.
    /// </summary>
    public DocumentIdentification22? ContractDocumentIdentification { get; init; } 
    /// <summary>
    /// Amount of the trade contract.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Party that is specified as the buyer for this trade agreement.
    /// </summary>
    public TradeParty2[] Buyer { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Party that is specified as the seller for this trade agreement.
    /// </summary>
    public TradeParty2[] Seller { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Planned final payment date at the time of issuance.
    /// </summary>
    public required IsoISODate MaturityDate { get; init; } 
    /// <summary>
    /// Indicates whether the contract duration is extended or not.
    /// </summary>
    public required IsoTrueFalseIndicator ProlongationFlag { get; init; } 
    /// <summary>
    /// Start date of the trade contract.
    /// </summary>
    public required IsoISODate StartDate { get; init; } 
    /// <summary>
    /// Currency in which the trade is being settled.
    /// </summary>
    public required ActiveCurrencyCode SettlementCurrency { get; init; } 
    /// <summary>
    /// Provides details on the currency exchange rate and contract.
    /// </summary>
    public ExchangeRate1? ExchangeRateInformation { get; init; } 
    /// <summary>
    /// Schedule of the payments defined for the trade contract.
    /// </summary>
    public InterestPaymentDateRange1? PaymentSchedule { get; init; } 
    /// <summary>
    /// Schedule of the shipment.
    /// </summary>
    public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; } 
    /// <summary>
    /// Documents provided as attachments to the trade contract.
    /// </summary>
    public DocumentGeneralInformation3[] Attachment { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
