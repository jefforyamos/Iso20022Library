﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AuthorisationResponse.  ISO2002 ID# _RPup9zKQEeOqyZqt0rCZLg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction2Choice;

/// <summary>
/// Card payment transaction including an authorisation response.
/// </summary>
public partial record AuthorisationResponse : CardPaymentDataSetTransaction2Choice_
{
    #nullable enable
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    public Traceability1? Traceability { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Data related to the environment of the card payment transaction.
    /// </summary>
    public required CardPaymentEnvironment28 Environment { get; init; } 
    /// <summary>
    /// Card payment transaction authorisation result.
    /// </summary>
    public required CardPaymentTransaction32 Transaction { get; init; } 
    /// <summary>
    /// Response to the authorisation request from the acquirer.
    /// </summary>
    public required CardPaymentTransaction24 TransactionResponse { get; init; } 
    #nullable disable
}
