﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CurrencyExchange20.  ISO2002 ID# _MqM5RdfiEeqoweZZxm4TPQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed to process a currency exchange or conversion.
/// </summary>
public partial record CurrencyExchange20
     : IIsoXmlSerilizable<CurrencyExchange20>
{
    #nullable enable
    
    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode QuotedCurrency { get; init; } 
    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    public required IsoISODateTime QuotationDate { get; init; } 
    /// <summary>
    /// Lowest limit defined for the exchange rate.
    /// Usage: The currency authority publishes the exchange rate based on the price formed in the foreign exchange market, allowing it to float up and down within the prescribed fluctuation range. It is the lowest exchange rate supported in foreign exchange market transactions.
    /// </summary>
    public ExchangeRateOrPercentage1Choice_? LowLimit { get; init; } 
    /// <summary>
    /// Highest limit defined for the exchange rate.
    /// Usage: The currency authority publishes the exchange rate based on the price formed in the foreign exchange market, allowing it to float up and down within the prescribed fluctuation range. It is the highest exchange rate supported in foreign exchange market transactions.
    /// </summary>
    public ExchangeRateOrPercentage1Choice_? HighLimit { get; init; } 
    
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
        writer.WriteStartElement(null, "XchgRate", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoBaseOneRate(ExchangeRate)); // data type BaseOneRate System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "QtdCcy", xmlNamespace );
        writer.WriteValue(QuotedCurrency.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "QtnDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(QuotationDate)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (LowLimit is ExchangeRateOrPercentage1Choice_ LowLimitValue)
        {
            writer.WriteStartElement(null, "LwLmt", xmlNamespace );
            LowLimitValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (HighLimit is ExchangeRateOrPercentage1Choice_ HighLimitValue)
        {
            writer.WriteStartElement(null, "HghLmt", xmlNamespace );
            HighLimitValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CurrencyExchange20 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
