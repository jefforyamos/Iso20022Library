﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Environment32.  ISO2002 ID# _3_n-wZx9EeuwYeL1lHu9zw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of a card transaction.
/// </summary>
public partial record Environment32
     : IIsoXmlSerilizable<Environment32>
{
    #nullable enable
    
    /// <summary>
    /// Party in a contractual relationship with an acceptor to acquire card payment transactions.
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
    public PartyIdentification258? Acceptor { get; init; } 
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
    public CardData9? Card { get; init; } 
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    public Wallet2? Wallet { get; init; } 
    /// <summary>
    /// Details of payment token.
    /// </summary>
    public Token3? Token { get; init; } 
    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    public Cardholder19? Cardholder { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Acqrr", xmlNamespace );
        Acquirer.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Originator is PartyIdentification263 OriginatorValue)
        {
            writer.WriteStartElement(null, "Orgtr", xmlNamespace );
            OriginatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Sender is PartyIdentification263 SenderValue)
        {
            writer.WriteStartElement(null, "Sndr", xmlNamespace );
            SenderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Receiver is PartyIdentification263 ReceiverValue)
        {
            writer.WriteStartElement(null, "Rcvr", xmlNamespace );
            ReceiverValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Acceptor is PartyIdentification258 AcceptorValue)
        {
            writer.WriteStartElement(null, "Accptr", xmlNamespace );
            AcceptorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Destination is PartyIdentification263 DestinationValue)
        {
            writer.WriteStartElement(null, "Dstn", xmlNamespace );
            DestinationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Terminal is Terminal6 TerminalValue)
        {
            writer.WriteStartElement(null, "Termnl", xmlNamespace );
            TerminalValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Issuer is PartyIdentification263 IssuerValue)
        {
            writer.WriteStartElement(null, "Issr", xmlNamespace );
            IssuerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Card is CardData9 CardValue)
        {
            writer.WriteStartElement(null, "Card", xmlNamespace );
            CardValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Wallet is Wallet2 WalletValue)
        {
            writer.WriteStartElement(null, "Wllt", xmlNamespace );
            WalletValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Token is Token3 TokenValue)
        {
            writer.WriteStartElement(null, "Tkn", xmlNamespace );
            TokenValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Cardholder is Cardholder19 CardholderValue)
        {
            writer.WriteStartElement(null, "Crdhldr", xmlNamespace );
            CardholderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Environment32 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
