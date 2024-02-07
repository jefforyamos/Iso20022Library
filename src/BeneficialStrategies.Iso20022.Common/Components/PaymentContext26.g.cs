﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentContext26.  ISO2002 ID# _0eA4sdwqEeioifFt1dhnJA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment context in which the transaction is performed.
/// </summary>
public partial record PaymentContext26
     : IIsoXmlSerilizable<PaymentContext26>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// </summary>
    public IsoTrueFalseIndicator? CardPresent { get; init; } 
    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// </summary>
    public IsoTrueFalseIndicator? CardholderPresent { get; init; } 
    /// <summary>
    /// On-line or off-line context of the transaction.
    /// </summary>
    public IsoTrueFalseIndicator? OnLineContext { get; init; } 
    /// <summary>
    /// Human attendance at the POI (Point Of Interaction) location during the transaction.
    /// </summary>
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    public TransactionEnvironment1Code? TransactionEnvironment { get; init; } 
    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system.
    /// </summary>
    public TransactionChannel5Code? TransactionChannel { get; init; } 
    /// <summary>
    /// Indicates whether a message can be sent or not on an attendant display (attendant display present or not).
    /// </summary>
    public IsoTrueFalseIndicator? AttendantMessageCapable { get; init; } 
    /// <summary>
    /// Language used to display messages to the attendant.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    public LanguageCode? AttendantLanguage { get; init; } 
    /// <summary>
    /// Entry mode of the card data.
    /// </summary>
    public CardDataReading6Code? CardDataEntryMode { get; init; } 
    /// <summary>
    /// Indicator of a card entry mode fallback.
    /// </summary>
    public CardFallback1Code? FallbackIndicator { get; init; } 
    /// <summary>
    /// Payment options the card acceptor can support.
    /// </summary>
    public SupportedPaymentOption1Code? SupportedOption { get; init; } 
    
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
        if (CardPresent is IsoTrueFalseIndicator CardPresentValue)
        {
            writer.WriteStartElement(null, "CardPres", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(CardPresentValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (CardholderPresent is IsoTrueFalseIndicator CardholderPresentValue)
        {
            writer.WriteStartElement(null, "CrdhldrPres", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(CardholderPresentValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (OnLineContext is IsoTrueFalseIndicator OnLineContextValue)
        {
            writer.WriteStartElement(null, "OnLineCntxt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(OnLineContextValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (AttendanceContext is AttendanceContext1Code AttendanceContextValue)
        {
            writer.WriteStartElement(null, "AttndncCntxt", xmlNamespace );
            writer.WriteValue(AttendanceContextValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TransactionEnvironment is TransactionEnvironment1Code TransactionEnvironmentValue)
        {
            writer.WriteStartElement(null, "TxEnvt", xmlNamespace );
            writer.WriteValue(TransactionEnvironmentValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TransactionChannel is TransactionChannel5Code TransactionChannelValue)
        {
            writer.WriteStartElement(null, "TxChanl", xmlNamespace );
            writer.WriteValue(TransactionChannelValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AttendantMessageCapable is IsoTrueFalseIndicator AttendantMessageCapableValue)
        {
            writer.WriteStartElement(null, "AttndntMsgCpbl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(AttendantMessageCapableValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (AttendantLanguage is LanguageCode AttendantLanguageValue)
        {
            writer.WriteStartElement(null, "AttndntLang", xmlNamespace );
            writer.WriteValue(AttendantLanguageValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CardDataEntryMode is CardDataReading6Code CardDataEntryModeValue)
        {
            writer.WriteStartElement(null, "CardDataNtryMd", xmlNamespace );
            writer.WriteValue(CardDataEntryModeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (FallbackIndicator is CardFallback1Code FallbackIndicatorValue)
        {
            writer.WriteStartElement(null, "FllbckInd", xmlNamespace );
            writer.WriteValue(FallbackIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SupportedOption is SupportedPaymentOption1Code SupportedOptionValue)
        {
            writer.WriteStartElement(null, "SpprtdOptn", xmlNamespace );
            writer.WriteValue(SupportedOptionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static PaymentContext26 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
