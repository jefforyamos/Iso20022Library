﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardData7.  ISO2002 ID# _F9FjgY2pEeuPp4VyLQDHhg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Non-protected sensitive data associated with the card or payment token performing the transaction.
/// </summary>
public partial record CardData7
     : IIsoXmlSerilizable<CardData7>
{
    #nullable enable
    
    /// <summary>
    /// Primary Account Number (PAN) of the card or a surrogate of the PAN such as a payment token.
    /// ISO 8583 bit 2
    /// </summary>
    public IsoMax19NumericText? PAN { get; init; } 
    /// <summary>
    /// To indicate whether the PAN is using ProtectedData for encryption or not.
    /// False: The PAN is used in plain text 
    /// True: The PAN is encrypted by using ProtectedData
    /// Default: False
    /// </summary>
    public IsoTrueFalseIndicator? ProtectedPANIndicator { get; init; } 
    /// <summary>
    /// Distinguishes between instances of the same payment card.
    /// ISO 8583 bit 23
    /// </summary>
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; } 
    /// <summary>
    /// Date as from which the card can be used, expressed in one of the following formats: YYYY-MM-DD, YYYY-MM, YY-MM-DD.
    /// ISO 8583:93 & ISO 8583:2003-1 bit 13
    /// </summary>
    public IsoISOYearMonth? EffectiveDate { get; init; } 
    /// <summary>
    /// Expiry date of the card or payment token.
    /// ISO 8583 bit 14.
    /// </summary>
    public IsoISOYearMonth? ExpiryDate { get; init; } 
    /// <summary>
    /// Unique non-financial reference assigned to a given PAN. May be used to link the transaction activity to that PAN.
    /// ISO 8583:87 bit 56 (TLV tag 01/dataset 71)
    /// ISO 8583:93 bit 112 (TLV tag 01/dataset 71)
    /// ISO 8583:2003 bit 51 (TLV tag 01/dataset 71)
    /// </summary>
    public IsoMax35Text? PaymentAccountReference { get; init; } 
    /// <summary>
    /// Leading digits of the PAN that identifies the card portfolio (for example, Issuer Identification Number). This data should not to be presented to the card acceptor or its environment. (for example, acquirer should not to send or make available to merchant).
    /// </summary>
    public IsoMax19NumericText? PANAccountRange { get; init; } 
    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// ISO 8583 bit 20
    /// </summary>
    public ISO3NumericCountryCode? CardCountryCode { get; init; } 
    /// <summary>
    /// Type of card product.
    /// </summary>
    public IsoMax35Text? CardProductType { get; init; } 
    /// <summary>
    /// Sub type of card product.
    /// </summary>
    public IsoMax35Text? CardProductSubType { get; init; } 
    /// <summary>
    /// Identifies the card portfolio. 
    /// </summary>
    public IsoMax35Text? CardPortfolioIdentifier { get; init; } 
    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    public AdditionalData1? AdditionalCardData { get; init; } 
    
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
        if (PAN is IsoMax19NumericText PANValue)
        {
            writer.WriteStartElement(null, "PAN", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax19NumericText(PANValue)); // data type Max19NumericText System.String
            writer.WriteEndElement();
        }
        if (ProtectedPANIndicator is IsoTrueFalseIndicator ProtectedPANIndicatorValue)
        {
            writer.WriteStartElement(null, "PrtctdPANInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(ProtectedPANIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (CardSequenceNumber is IsoMin2Max3NumericText CardSequenceNumberValue)
        {
            writer.WriteStartElement(null, "CardSeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMin2Max3NumericText(CardSequenceNumberValue)); // data type Min2Max3NumericText System.String
            writer.WriteEndElement();
        }
        if (EffectiveDate is IsoISOYearMonth EffectiveDateValue)
        {
            writer.WriteStartElement(null, "FctvDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISOYearMonth(EffectiveDateValue)); // data type ISOYearMonth System.UInt16
            writer.WriteEndElement();
        }
        if (ExpiryDate is IsoISOYearMonth ExpiryDateValue)
        {
            writer.WriteStartElement(null, "XpryDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISOYearMonth(ExpiryDateValue)); // data type ISOYearMonth System.UInt16
            writer.WriteEndElement();
        }
        if (PaymentAccountReference is IsoMax35Text PaymentAccountReferenceValue)
        {
            writer.WriteStartElement(null, "PmtAcctRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PaymentAccountReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PANAccountRange is IsoMax19NumericText PANAccountRangeValue)
        {
            writer.WriteStartElement(null, "PANAcctRg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax19NumericText(PANAccountRangeValue)); // data type Max19NumericText System.String
            writer.WriteEndElement();
        }
        if (CardCountryCode is ISO3NumericCountryCode CardCountryCodeValue)
        {
            writer.WriteStartElement(null, "CardCtryCd", xmlNamespace );
            writer.WriteValue(CardCountryCodeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CardProductType is IsoMax35Text CardProductTypeValue)
        {
            writer.WriteStartElement(null, "CardPdctTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CardProductTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CardProductSubType is IsoMax35Text CardProductSubTypeValue)
        {
            writer.WriteStartElement(null, "CardPdctSubTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CardProductSubTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CardPortfolioIdentifier is IsoMax35Text CardPortfolioIdentifierValue)
        {
            writer.WriteStartElement(null, "CardPrtflIdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CardPortfolioIdentifierValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalCardData is AdditionalData1 AdditionalCardDataValue)
        {
            writer.WriteStartElement(null, "AddtlCardData", xmlNamespace );
            AdditionalCardDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardData7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
