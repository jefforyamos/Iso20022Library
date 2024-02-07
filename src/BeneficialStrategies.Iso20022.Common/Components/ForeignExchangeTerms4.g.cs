﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ForeignExchangeTerms4.  ISO2002 ID# _U36vM9p-Ed-ak6NoX_4Aeg_-1456785777.
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
public partial record ForeignExchangeTerms4
     : IIsoXmlSerilizable<ForeignExchangeTerms4>
{
    #nullable enable
    
    /// <summary>
    /// Currency and amount bought in a foreign exchange trade. The buy amount is received by the buyer.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? BuyAmount { get; init; } 
    /// <summary>
    /// Currency and amount sold in a foreign exchange trade. The sold amount is delivered by the buyer.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SellAmount { get; init; } 
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    public required CurrencyCode UnitCurrency { get; init; } 
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    public required CurrencyCode QuotedCurrency { get; init; } 
    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    public IsoISODateTime? QuotationDate { get; init; } 
    /// <summary>
    /// Party that proposes a foreign exchange rate.
    /// </summary>
    public PartyIdentification2Choice_? QuotingInstitution { get; init; } 
    
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
        if (BuyAmount is IsoActiveCurrencyAnd13DecimalAmount BuyAmountValue)
        {
            writer.WriteStartElement(null, "BuyAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(BuyAmountValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        if (SellAmount is IsoActiveCurrencyAndAmount SellAmountValue)
        {
            writer.WriteStartElement(null, "SellAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(SellAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "UnitCcy", xmlNamespace );
        writer.WriteValue(UnitCurrency.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "QtdCcy", xmlNamespace );
        writer.WriteValue(QuotedCurrency.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "XchgRate", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoBaseOneRate(ExchangeRate)); // data type BaseOneRate System.Decimal
        writer.WriteEndElement();
        if (QuotationDate is IsoISODateTime QuotationDateValue)
        {
            writer.WriteStartElement(null, "QtnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(QuotationDateValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (QuotingInstitution is PartyIdentification2Choice_ QuotingInstitutionValue)
        {
            writer.WriteStartElement(null, "QtgInstn", xmlNamespace );
            QuotingInstitutionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ForeignExchangeTerms4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
