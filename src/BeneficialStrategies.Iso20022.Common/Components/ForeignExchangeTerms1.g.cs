﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ForeignExchangeTerms1.  ISO2002 ID# _QK6Nitp-Ed-ak6NoX_4Aeg_651798512.
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
public partial record ForeignExchangeTerms1
     : IIsoXmlSerilizable<ForeignExchangeTerms1>
{
    #nullable enable
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode UnitCurrency { get; init; } 
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode QuotedCurrency { get; init; } 
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
    public PartyIdentification10Choice_? QuotingInstitution { get; init; } 
    
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
        if (QuotationDate is IsoISODateTime QuotationDateValue)
        {
            writer.WriteStartElement(null, "QtnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(QuotationDateValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (QuotingInstitution is PartyIdentification10Choice_ QuotingInstitutionValue)
        {
            writer.WriteStartElement(null, "QtgInstn", xmlNamespace );
            QuotingInstitutionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ForeignExchangeTerms1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
