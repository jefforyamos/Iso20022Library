﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Completion.  ISO2002 ID# _U0k2oY3MEeWjkqXgn_0Imw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction4Choice;

/// <summary>
/// Completed card payment transaction to be captured.
/// </summary>
public partial record Completion : ICardPaymentDataSetTransaction4Choice
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
    public required CardPaymentEnvironment52 Environment { get; init; } 
    /// <summary>
    /// Data related to the context of the transaction.
    /// </summary>
    public CardPaymentContext18? Context { get; init; } 
    /// <summary>
    /// Transaction information to be captured.
    /// </summary>
    public required CardPaymentTransaction60 Transaction { get; init; } 
    #nullable disable
}
