﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentContext2.  ISO2002 ID# _TEqIoQEcEeCQm6a_G2yO_w_557142939.
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
public partial record PaymentContext2
     : IIsoXmlSerilizable<PaymentContext2>
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
    /// Human attendance at the POI location during the transaction.
    /// </summary>
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    public TransactionEnvironment1Code? TransactionEnvironment { get; init; } 
    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system.
    /// </summary>
    public TransactionChannel1Code? TransactionChannel { get; init; } 
    /// <summary>
    /// Entry mode of the card data.
    /// </summary>
    public required CardDataReading1Code CardDataEntryMode { get; init; } 
    /// <summary>
    /// Indicator of a card entry mode fallback.
    /// </summary>
    public IsoTrueFalseIndicator? FallbackIndicator { get; init; } 
    
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
        if (TransactionChannel is TransactionChannel1Code TransactionChannelValue)
        {
            writer.WriteStartElement(null, "TxChanl", xmlNamespace );
            writer.WriteValue(TransactionChannelValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CardDataNtryMd", xmlNamespace );
        writer.WriteValue(CardDataEntryMode.ToString()); // Enum value
        writer.WriteEndElement();
        if (FallbackIndicator is IsoTrueFalseIndicator FallbackIndicatorValue)
        {
            writer.WriteStartElement(null, "FllbckInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(FallbackIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static PaymentContext2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
