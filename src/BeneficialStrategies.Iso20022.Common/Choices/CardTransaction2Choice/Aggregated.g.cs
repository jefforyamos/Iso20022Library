﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Aggregated.  ISO2002 ID# _0jmr8Tj3EeSz-s1QOUJaOg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CardTransaction2Choice;

/// <summary>
/// Card transaction details, based on card transaction aggregated data performed by the card acquirer.
/// </summary>
public partial record Aggregated : ICardTransaction2Choice
{
    #nullable enable
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    public CardPaymentServiceType2Code? AdditionalService { get; init; } 
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    public ExternalCardTransactionCategory1Code? TransactionCategory { get; init; } 
    /// <summary>
    /// Unique identification of the sales reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    public IsoMax35Text? SaleReconciliationIdentification { get; init; } 
    /// <summary>
    /// Range of sequence numbers on which the globalisation applies.
    /// </summary>
    public CardSequenceNumberRange1? SequenceNumberRange { get; init; } 
    /// <summary>
    /// Date range on which the globalisation applies.
    /// </summary>
    public IDateOrDateTimePeriodChoice? TransactionDateRange { get; init; } 
    #nullable disable
}
