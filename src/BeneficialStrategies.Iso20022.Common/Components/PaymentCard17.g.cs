﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentCard17.  ISO2002 ID# _rCe_gYqPEeSRT5rEzcAHEw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card performing the withdrawal transaction.
/// </summary>
public partial record PaymentCard17
     : IIsoXmlSerilizable<PaymentCard17>
{
    #nullable enable
    
    /// <summary>
    /// Entry mode that used to obtain the card data.
    /// </summary>
    public required CardDataReading1Code CardDataEntryMode { get; init; } 
    /// <summary>
    /// Indicate the occurrence of a fall-back on the card entry mode.
    /// </summary>
    public CardFallback1Code? FallbackIndicator { get; init; } 
    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    public ContentInformationType10? ProtectedCardData { get; init; } 
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    public PlainCardData14? PlainCardData { get; init; } 
    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    public IsoMax3Text? CardCountryCode { get; init; } 
    /// <summary>
    /// Currency code of the card issuer (ISO 4217 numeric code).
    /// </summary>
    public IsoExact3AlphaNumericText? CardCurrencyCode { get; init; } 
    /// <summary>
    /// Balance of the captured card or epurse if available.
    /// </summary>
    public IsoCurrencyAndAmount? RetainedCardBalance { get; init; } 
    
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
        writer.WriteStartElement(null, "CardDataNtryMd", xmlNamespace );
        writer.WriteValue(CardDataEntryMode.ToString()); // Enum value
        writer.WriteEndElement();
        if (FallbackIndicator is CardFallback1Code FallbackIndicatorValue)
        {
            writer.WriteStartElement(null, "FllbckInd", xmlNamespace );
            writer.WriteValue(FallbackIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ProtectedCardData is ContentInformationType10 ProtectedCardDataValue)
        {
            writer.WriteStartElement(null, "PrtctdCardData", xmlNamespace );
            ProtectedCardDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PlainCardData is PlainCardData14 PlainCardDataValue)
        {
            writer.WriteStartElement(null, "PlainCardData", xmlNamespace );
            PlainCardDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CardCountryCode is IsoMax3Text CardCountryCodeValue)
        {
            writer.WriteStartElement(null, "CardCtryCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3Text(CardCountryCodeValue)); // data type Max3Text System.String
            writer.WriteEndElement();
        }
        if (CardCurrencyCode is IsoExact3AlphaNumericText CardCurrencyCodeValue)
        {
            writer.WriteStartElement(null, "CardCcyCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact3AlphaNumericText(CardCurrencyCodeValue)); // data type Exact3AlphaNumericText System.String
            writer.WriteEndElement();
        }
        if (RetainedCardBalance is IsoCurrencyAndAmount RetainedCardBalanceValue)
        {
            writer.WriteStartElement(null, "RtndCardBal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(RetainedCardBalanceValue)); // data type CurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
    }
    public static PaymentCard17 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
