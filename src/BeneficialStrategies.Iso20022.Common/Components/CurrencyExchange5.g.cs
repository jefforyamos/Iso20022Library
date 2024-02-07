﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CurrencyExchange5.  ISO2002 ID# _QMGgUNp-Ed-ak6NoX_4Aeg_998870247.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide details of the currency exchange.
/// </summary>
public partial record CurrencyExchange5
     : IIsoXmlSerilizable<CurrencyExchange5>
{
    #nullable enable
    
    /// <summary>
    /// Currency from which an amount is to be converted in a currency conversion.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode SourceCurrency { get; init; } 
    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? TargetCurrency { get; init; } 
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? UnitCurrency { get; init; } 
    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.||Usage: ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    /// <summary>
    /// Unique identification to unambiguously identify the foreign exchange contract.
    /// </summary>
    public IsoMax35Text? ContractIdentification { get; init; } 
    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    public IsoISODateTime? QuotationDate { get; init; } 
    
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
        if (TargetCurrency is ActiveOrHistoricCurrencyCode TargetCurrencyValue)
        {
            writer.WriteStartElement(null, "TrgtCcy", xmlNamespace );
            writer.WriteValue(TargetCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (UnitCurrency is ActiveOrHistoricCurrencyCode UnitCurrencyValue)
        {
            writer.WriteStartElement(null, "UnitCcy", xmlNamespace );
            writer.WriteValue(UnitCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "XchgRate", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoBaseOneRate(ExchangeRate)); // data type BaseOneRate System.Decimal
        writer.WriteEndElement();
        if (ContractIdentification is IsoMax35Text ContractIdentificationValue)
        {
            writer.WriteStartElement(null, "CtrctId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ContractIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (QuotationDate is IsoISODateTime QuotationDateValue)
        {
            writer.WriteStartElement(null, "QtnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(QuotationDateValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
    }
    public static CurrencyExchange5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
