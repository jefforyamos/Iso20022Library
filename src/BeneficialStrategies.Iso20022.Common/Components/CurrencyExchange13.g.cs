﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CurrencyExchange13.  ISO2002 ID# _M5wl0IW7EeiDBOVr6AJAFA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the details of the currency exchange.
/// </summary>
public partial record CurrencyExchange13
     : IIsoXmlSerilizable<CurrencyExchange13>
{
    #nullable enable
    
    /// <summary>
    /// Currency from which an amount is to be converted in a currency conversion.
    /// </summary>
    public required ActiveCurrencyCode SourceCurrency { get; init; } 
    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    public required ActiveCurrencyCode TargetCurrency { get; init; } 
    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    public ActiveCurrencyCode? UnitCurrency { get; init; } 
    
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
        writer.WriteStartElement(null, "SrcCcy", xmlNamespace );
        writer.WriteValue(SourceCurrency.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TrgtCcy", xmlNamespace );
        writer.WriteValue(TargetCurrency.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "XchgRate", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoBaseOneRate(ExchangeRate)); // data type BaseOneRate System.Decimal
        writer.WriteEndElement();
        if (UnitCurrency is ActiveCurrencyCode UnitCurrencyValue)
        {
            writer.WriteStartElement(null, "UnitCcy", xmlNamespace );
            writer.WriteValue(UnitCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static CurrencyExchange13 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
