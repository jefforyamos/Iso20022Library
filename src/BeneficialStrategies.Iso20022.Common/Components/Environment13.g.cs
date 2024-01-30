﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Environment13.  ISO2002 ID# _CwhA8UP8EeiFlYmBVFSxUw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
public partial record Environment13
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    public required PartyIdentification197 Acquirer { get; init; } 
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    public PartyIdentification197? Sender { get; init; } 
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    public PartyIdentification197? Receiver { get; init; } 
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    public PartyIdentification203? Acceptor { get; init; } 
    /// <summary>
    /// Person initiating a payment to the benefit of a payee.
    /// </summary>
    public PartyIdentification211? Payer { get; init; } 
    /// <summary>
    /// Person to the benefit of whom a payment is performed.
    /// </summary>
    public PartyIdentification211? Payee { get; init; } 
    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    public Terminal2? Terminal { get; init; } 
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    public required CardData5 Card { get; init; } 
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    public Wallet1? Wallet { get; init; } 
    /// <summary>
    /// Details of payment token.
    /// </summary>
    public Token1? Token { get; init; } 
    
    #nullable disable
}
