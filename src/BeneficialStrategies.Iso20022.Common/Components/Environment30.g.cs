﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Environment30.  ISO2002 ID# _ELI3AY2kEeuUX8RS9eNYdA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction for Inquiry.
/// </summary>
public partial record Environment30
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer.
    /// </summary>
    public required PartyIdentification263 Acquirer { get; init; } 
    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    public PartyIdentification263? Originator { get; init; } 
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// </summary>
    public PartyIdentification263? Sender { get; init; } 
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// </summary>
    public PartyIdentification263? Receiver { get; init; } 
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    public PartyIdentification255? Acceptor { get; init; } 
    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    public PartyIdentification263? Destination { get; init; } 
    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    public PartyIdentification263? Issuer { get; init; } 
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    public CardData2? Card { get; init; } 
    /// <summary>
    /// Details of payment token.
    /// </summary>
    public Token2? Token { get; init; } 
    
    #nullable disable
}
