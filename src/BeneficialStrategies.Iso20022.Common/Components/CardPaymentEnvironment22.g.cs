﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentEnvironment22.  ISO2002 ID# _p6r_UTG1EeOH78pE3LSlGw.
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
public partial record CardPaymentEnvironment22
     : IIsoXmlSerilizable<CardPaymentEnvironment22>
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    public Acquirer2? Acquirer { get; init; } 
    /// <summary>
    /// Merchant performing the card payment.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    public Organisation8? Merchant { get; init; } 
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    public required PointOfInteraction3 POI { get; init; } 
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    public PaymentCard8? Card { get; init; } 
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    public Cardholder6? Cardholder { get; init; } 
    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    public ContentInformationType7? ProtectedCardholderData { get; init; } 
    
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
        if (Acquirer is Acquirer2 AcquirerValue)
        {
            writer.WriteStartElement(null, "Acqrr", xmlNamespace );
            AcquirerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Merchant is Organisation8 MerchantValue)
        {
            writer.WriteStartElement(null, "Mrchnt", xmlNamespace );
            MerchantValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "POI", xmlNamespace );
        POI.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Card is PaymentCard8 CardValue)
        {
            writer.WriteStartElement(null, "Card", xmlNamespace );
            CardValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Cardholder is Cardholder6 CardholderValue)
        {
            writer.WriteStartElement(null, "Crdhldr", xmlNamespace );
            CardholderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProtectedCardholderData is ContentInformationType7 ProtectedCardholderDataValue)
        {
            writer.WriteStartElement(null, "PrtctdCrdhldrData", xmlNamespace );
            ProtectedCardholderDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardPaymentEnvironment22 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
