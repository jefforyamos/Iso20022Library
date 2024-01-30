﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Completion.  ISO2002 ID# _438TcdeiEeiJyp_aycJaTw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction7Choice;

/// <summary>
/// Completed card payment transaction to be captured.
/// </summary>
public partial record Completion : ICardPaymentDataSetTransaction7Choice
{
    #nullable enable
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    public Traceability5? Traceability { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Data related to the environment of the transaction in a transaction captured in batch.
    /// </summary>
    public required CardPaymentEnvironment68 Environment { get; init; } 
    /// <summary>
    /// Data related to the context of the transaction.
    /// </summary>
    public CardPaymentContext27? Context { get; init; } 
    /// <summary>
    /// Transaction information to be captured.
    /// </summary>
    public required CardPaymentTransaction89 Transaction { get; init; } 
    #nullable disable
}
