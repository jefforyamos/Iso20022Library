﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ForeignExchange1.  ISO2002 ID# _8F9mqLu7EeSXxOgurgHGgw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the foreign exchange.
/// </summary>
public partial record ForeignExchange1
     : IIsoXmlSerilizable<ForeignExchange1>
{
    #nullable enable
    
    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode ForeignCurrency { get; init; } 
    /// <summary>
    /// Foreign exchange rate between the source and the foreign currency applicable to the first leg of the FX swap transaction. The foreign exchange spot rate will be reported as the number of foreign currency units per one unit of the source currency.
    /// </summary>
    public required IsoBaseOneRate ExchangeSpotRate { get; init; } 
    /// <summary>
    /// Difference between the foreign exchange spot rate and the foreign exchange forward rate expressed in basis points quoted in accordance with the prevailing market conventions for the currency pair. 
    /// Usage:
    /// This value can be either positive or negative.
    /// </summary>
    public required IsoDecimalNumber ExchangeForwardPoint { get; init; } 
    
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
        writer.WriteStartElement(null, "FrgnCcy", xmlNamespace );
        writer.WriteValue(ForeignCurrency.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "XchgSpotRate", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoBaseOneRate(ExchangeSpotRate)); // data type BaseOneRate System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "XchgFwdPt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoDecimalNumber(ExchangeForwardPoint)); // data type DecimalNumber System.UInt64
        writer.WriteEndElement();
    }
    public static ForeignExchange1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
