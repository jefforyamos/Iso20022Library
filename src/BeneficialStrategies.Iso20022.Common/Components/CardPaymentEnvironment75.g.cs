﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentEnvironment75.  ISO2002 ID# _XX2O8QxTEeqEbo60f0v6aw.
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
public partial record CardPaymentEnvironment75
     : IIsoXmlSerilizable<CardPaymentEnvironment75>
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    public Acquirer10? Acquirer { get; init; } 
    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    public Organisation32? Merchant { get; init; } 
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    public PointOfInteraction10? POI { get; init; } 
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    public PaymentCard30? Card { get; init; } 
    /// <summary>
    /// Check Payment instrument.
    /// </summary>
    public Check1? Check { get; init; } 
    /// <summary>
    /// Store value account payment instrument.
    /// </summary>
    public StoredValueAccount2? StoredValueAccount { get; init; } 
    /// <summary>
    /// Store value account associated to the payment.
    /// </summary>
    public LoyaltyAccount2? LoyaltyAccount { get; init; } 
    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    public CustomerDevice1? CustomerDevice { get; init; } 
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    public CustomerDevice1? Wallet { get; init; } 
    /// <summary>
    /// Payment token information.
    /// </summary>
    public CardPaymentToken5? PaymentToken { get; init; } 
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    public Cardholder16? Cardholder { get; init; } 
    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    public ContentInformationType22? ProtectedCardholderData { get; init; } 
    /// <summary>
    /// Sale Retailer Environment for this message.
    /// </summary>
    public RetailerSaleEnvironment2? SaleEnvironment { get; init; } 
    
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
        if (Acquirer is Acquirer10 AcquirerValue)
        {
            writer.WriteStartElement(null, "Acqrr", xmlNamespace );
            AcquirerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Merchant is Organisation32 MerchantValue)
        {
            writer.WriteStartElement(null, "Mrchnt", xmlNamespace );
            MerchantValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (POI is PointOfInteraction10 POIValue)
        {
            writer.WriteStartElement(null, "POI", xmlNamespace );
            POIValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Card is PaymentCard30 CardValue)
        {
            writer.WriteStartElement(null, "Card", xmlNamespace );
            CardValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Check is Check1 CheckValue)
        {
            writer.WriteStartElement(null, "Chck", xmlNamespace );
            CheckValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StoredValueAccount is StoredValueAccount2 StoredValueAccountValue)
        {
            writer.WriteStartElement(null, "StordValAcct", xmlNamespace );
            StoredValueAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LoyaltyAccount is LoyaltyAccount2 LoyaltyAccountValue)
        {
            writer.WriteStartElement(null, "LltyAcct", xmlNamespace );
            LoyaltyAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
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
        if (PaymentToken is CardPaymentToken5 PaymentTokenValue)
        {
            writer.WriteStartElement(null, "PmtTkn", xmlNamespace );
            PaymentTokenValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Cardholder is Cardholder16 CardholderValue)
        {
            writer.WriteStartElement(null, "Crdhldr", xmlNamespace );
            CardholderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProtectedCardholderData is ContentInformationType22 ProtectedCardholderDataValue)
        {
            writer.WriteStartElement(null, "PrtctdCrdhldrData", xmlNamespace );
            ProtectedCardholderDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SaleEnvironment is RetailerSaleEnvironment2 SaleEnvironmentValue)
        {
            writer.WriteStartElement(null, "SaleEnvt", xmlNamespace );
            SaleEnvironmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardPaymentEnvironment75 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
