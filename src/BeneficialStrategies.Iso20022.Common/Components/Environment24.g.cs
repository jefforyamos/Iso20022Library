﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Environment24.  ISO2002 ID# _TAJ1wYaZEeuSbct6WWD-Ng.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction for Inquiry.
/// </summary>
public partial record Environment24
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    public required PartyIdentification263 Acquirer { get; init; } 
    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    public PartyIdentification263? Originator { get; init; } 
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    public PartyIdentification263? Sender { get; init; } 
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    public PartyIdentification263? Receiver { get; init; } 
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    public required PartyIdentification255 Acceptor { get; init; } 
    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    public PartyIdentification263? Destination { get; init; } 
    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    public Terminal6? Terminal { get; init; } 
    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    public PartyIdentification263? Issuer { get; init; } 
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    public required CardData9 Card { get; init; } 
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    public Wallet2? Wallet { get; init; } 
    /// <summary>
    /// Details of payment token.
    /// </summary>
    public Token2? Token { get; init; } 
    /// <summary>
    /// Information about the cardholder.
    /// </summary>
    public Cardholder19? Cardholder { get; init; } 
    
    #nullable disable
}
