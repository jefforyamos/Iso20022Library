﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ForeignExchangeTerms27.  ISO2002 ID# _ckMJipKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the terms of the foreign exchange transaction.
/// </summary>
public partial record ForeignExchangeTerms27
     : IIsoXmlSerilizable<ForeignExchangeTerms27>
{
    #nullable enable
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    public required ActiveCurrencyCode UnitCurrency { get; init; } 
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    public required ActiveCurrencyCode QuotedCurrency { get; init; } 
    /// <summary>
    /// Factor used for the conversion of an amount from one currency into another. This reflects the price at which one currency was bought with another currency.|Usage: ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    /// <summary>
    /// Counter value of a foreign exchange conversion.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAndAmount ResultingAmount { get; init; } 
    
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
        writer.WriteStartElement(null, "UnitCcy", xmlNamespace );
        writer.WriteValue(UnitCurrency.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "QtdCcy", xmlNamespace );
        writer.WriteValue(QuotedCurrency.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "XchgRate", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoBaseOneRate(ExchangeRate)); // data type BaseOneRate System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RsltgAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(ResultingAmount)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static ForeignExchangeTerms27 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
