﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Environment31.  ISO2002 ID# _XWJLIZx9EeuwYeL1lHu9zw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
public partial record Environment31
     : IIsoXmlSerilizable<Environment31>
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
    /// The party providing source of funds.
    /// </summary>
    public PartyIdentification257? Payer { get; init; } 
    /// <summary>
    /// The party receiving funds.
    /// </summary>
    public PartyIdentification257? Payee { get; init; } 
    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    public Terminal4? Terminal { get; init; } 
    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    public PartyIdentification263? Issuer { get; init; } 
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    public CardData6? Card { get; init; } 
    /// <summary>
    /// Identification of the customer device performing the transaction.
    /// </summary>
    public CustomerDevice4? CustomerDevice { get; init; } 
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
        if (Acceptor is PartyIdentification255 AcceptorValue)
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
        if (Payer is PartyIdentification257 PayerValue)
        {
            writer.WriteStartElement(null, "Pyer", xmlNamespace );
            PayerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Payee is PartyIdentification257 PayeeValue)
        {
            writer.WriteStartElement(null, "Pyee", xmlNamespace );
            PayeeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Terminal is Terminal4 TerminalValue)
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
        if (Card is CardData6 CardValue)
        {
            writer.WriteStartElement(null, "Card", xmlNamespace );
            CardValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CustomerDevice is CustomerDevice4 CustomerDeviceValue)
        {
            writer.WriteStartElement(null, "CstmrDvc", xmlNamespace );
            CustomerDeviceValue.Serialize(writer, xmlNamespace);
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
    public static Environment31 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
