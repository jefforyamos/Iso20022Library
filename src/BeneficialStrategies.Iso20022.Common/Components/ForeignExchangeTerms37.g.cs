﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ForeignExchangeTerms37.  ISO2002 ID# _UFracZELEem-9Y6mq5ZH3Q.
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
public partial record ForeignExchangeTerms37
     : IIsoXmlSerilizable<ForeignExchangeTerms37>
{
    #nullable enable
    
    /// <summary>
    /// Cash amount resulting from a foreign exchange trade.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ToAmount { get; init; } 
    /// <summary>
    /// Cash amount for which a foreign exchange is required.
    /// </summary>
    public IsoActiveCurrencyAndAmount? FromAmount { get; init; } 
    /// <summary>
    /// Currency from which the quoted currency is converted in an exchange rate calculation.
    /// 1 x <UnitCcy> = <XchgRate> x <QtdCcy>.
    /// </summary>
    public required ActiveCurrencyCode UnitCurrency { get; init; } 
    /// <summary>
    /// Currency into which the unit currency is converted in an exchange rate calculation.
    /// 1 x <UnitCcy> = <XchgRate> x <QtdCcy>.
    /// </summary>
    public required ActiveCurrencyCode QuotedCurrency { get; init; } 
    /// <summary>
    /// Factor used for the conversion of an amount from one currency into another. This reflects that amount of the quoted currency that can be purchased with one unit of the unit currency, as follows: 
    /// 1 x CUR1 = nnn x CUR2, 
    /// where: 
    /// CUR1 is the unit currency 
    /// CUR2 is the quoted currency 
    /// nnn is the exchange rate.
    /// 1 x <UnitCcy> = <XchgRate> x <QtdCcy>.
    /// </summary>
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    public IsoISODateTime? QuotationDate { get; init; } 
    /// <summary>
    /// Party that proposes the foreign exchange rate.
    /// </summary>
    public PartyIdentification139? QuotingInstitution { get; init; } 
    
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
        if (ToAmount is IsoActiveCurrencyAndAmount ToAmountValue)
        {
            writer.WriteStartElement(null, "ToAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(ToAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (FromAmount is IsoActiveCurrencyAndAmount FromAmountValue)
        {
            writer.WriteStartElement(null, "FrAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(FromAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
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
        if (QuotingInstitution is PartyIdentification139 QuotingInstitutionValue)
        {
            writer.WriteStartElement(null, "QtgInstn", xmlNamespace );
            QuotingInstitutionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ForeignExchangeTerms37 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
