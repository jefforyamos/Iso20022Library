﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AuthorisationRequest.  ISO2002 ID# _bgZKtU0ZEeybj420QgWBkA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction10Choice;

/// <summary>
/// Card payment transaction including an authorisation request.
/// </summary>
public partial record AuthorisationRequest : CardPaymentDataSetTransaction10Choice_
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
    /// Data related to the environment of the card payment transaction to authorise.
    /// </summary>
    public required CardPaymentEnvironment78 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public CardPaymentContext29? Context { get; init; } 
    /// <summary>
    /// Card payment transaction to authorise.
    /// </summary>
    public required CardPaymentTransaction119 Transaction { get; init; } 
    #nullable disable
}
