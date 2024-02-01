﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DetailedStatus.  ISO2002 ID# _C2TSYyYMEei7VPGVFTQkxA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusType2Choice;

/// <summary>
/// Contains the detailed status of the payment.
/// </summary>
public partial record DetailedStatus : PaymentStatusType2Choice_
{
    #nullable enable
    /// <summary>
    /// Identifies the party that issues the status.
    /// </summary>
    public required IsoAnyBICIdentifier Originator { get; init; } 
    /// <summary>
    /// Date and time at which the funds are available,  as reported in the ACSC status update.
    /// </summary>
    public IsoISODateTime? FundsAvailable { get; init; } 
    /// <summary>
    /// Specifies the status of the transaction.
    /// </summary>
    public required PaymentStatus5 TransactionStatus { get; init; } 
    /// <summary>
    /// Identifies the entity to which the entity reporting the status has forwarded the payment transaction.
    /// Usage:
    /// This element can only be used in case the status is ACSP and the reason is G000 or G001.
    /// </summary>
    public IsoAnyBICIdentifier? ForwardedToAgent { get; init; } 
    /// <summary>
    /// Specifies the amount confirmed by the Originator. Depending on the Transaction Status, this amount can be the credited amount, pending amount, rejected amount or transferred amount.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount ConfirmedAmount { get; init; } 
    /// <summary>
    /// Specifies the exchange rate details between two currencies.
    /// </summary>
    public CurrencyExchange12? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? ChargeAmount { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
