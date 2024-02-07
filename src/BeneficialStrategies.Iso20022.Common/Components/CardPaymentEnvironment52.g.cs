﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentEnvironment52.  ISO2002 ID# _xfvlIY3NEeWjkqXgn_0Imw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the card payment transaction.
/// </summary>
public partial record CardPaymentEnvironment52
     : IIsoXmlSerilizable<CardPaymentEnvironment52>
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    public Acquirer4? Acquirer { get; init; } 
    /// <summary>
    /// Merchant performing the transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    public Organisation25? Merchant { get; init; } 
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    public PointOfInteraction5? POI { get; init; } 
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    public required PaymentCard20 Card { get; init; } 
    /// <summary>
    /// Device used by the customer to perform the payment.
    /// </summary>
    public CustomerDevice1? CustomerDevice { get; init; } 
    /// <summary>
    /// Container of tenders used by the customer to perform the payment.
    /// </summary>
    public CustomerDevice1? Wallet { get; init; } 
    /// <summary>
    /// Payment token information.
    /// </summary>
    public CardPaymentToken3? PaymentToken { get; init; } 
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    public Cardholder11? Cardholder { get; init; } 
    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    public ContentInformationType10? ProtectedCardholderData { get; init; } 
    
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
        if (Acquirer is Acquirer4 AcquirerValue)
        {
            writer.WriteStartElement(null, "Acqrr", xmlNamespace );
            AcquirerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Merchant is Organisation25 MerchantValue)
        {
            writer.WriteStartElement(null, "Mrchnt", xmlNamespace );
            MerchantValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (POI is PointOfInteraction5 POIValue)
        {
            writer.WriteStartElement(null, "POI", xmlNamespace );
            POIValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Card", xmlNamespace );
        Card.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CustomerDevice is CustomerDevice1 CustomerDeviceValue)
        {
            writer.WriteStartElement(null, "CstmrDvc", xmlNamespace );
            CustomerDeviceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Wallet is CustomerDevice1 WalletValue)
        {
            writer.WriteStartElement(null, "Wllt", xmlNamespace );
            WalletValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PaymentToken is CardPaymentToken3 PaymentTokenValue)
        {
            writer.WriteStartElement(null, "PmtTkn", xmlNamespace );
            PaymentTokenValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Cardholder is Cardholder11 CardholderValue)
        {
            writer.WriteStartElement(null, "Crdhldr", xmlNamespace );
            CardholderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProtectedCardholderData is ContentInformationType10 ProtectedCardholderDataValue)
        {
            writer.WriteStartElement(null, "PrtctdCrdhldrData", xmlNamespace );
            ProtectedCardholderDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardPaymentEnvironment52 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
