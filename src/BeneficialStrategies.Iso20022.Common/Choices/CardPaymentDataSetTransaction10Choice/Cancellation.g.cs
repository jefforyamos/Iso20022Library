﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Cancellation.  ISO2002 ID# _bgZKs00ZEeybj420QgWBkA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction10Choice;

/// <summary>
/// Cancelled card payment transaction to be captured.
/// </summary>
public partial record Cancellation : ICardPaymentDataSetTransaction10Choice
{
    #nullable enable
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    public Traceability8? Traceability { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Data related to the environment of the cancelled transaction captured in batch.
    /// </summary>
    public required CardPaymentEnvironment78 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public CardPaymentContext29? Context { get; init; } 
    /// <summary>
    /// Card payment cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    public required CardPaymentTransaction116 Transaction { get; init; } 
    #nullable disable
}
