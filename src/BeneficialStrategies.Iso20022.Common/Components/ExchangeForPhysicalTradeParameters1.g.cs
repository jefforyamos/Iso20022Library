﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ExchangeForPhysicalTradeParameters1.  ISO2002 ID# _Syi-L9p-Ed-ak6NoX_4Aeg_1763199616.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Technique whereby a position in the underlying is traded for a futures position in the physical commodity markets.
/// </summary>
public partial record ExchangeForPhysicalTradeParameters1
     : IIsoXmlSerilizable<ExchangeForPhysicalTradeParameters1>
{
    #nullable enable
    
    /// <summary>
    /// Unexpected divergence between the price behaviour of an underlying position or portfolio and the price behaviour of a hedging position or benchmark.
    /// </summary>
    public IsoPercentageRate? OutsideIndex { get; init; } 
    /// <summary>
    /// Difference between the value of a future and the value of the underlying equities after allowing for the discounted cash flows associated with the underlying stocks.
    /// </summary>
    public IsoActiveCurrencyAndAmount? FairValue { get; init; } 
    /// <summary>
    /// Value of a futures position involved in an Exchange For Physical trade.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ValueForFutures { get; init; } 
    
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
        if (OutsideIndex is IsoPercentageRate OutsideIndexValue)
        {
            writer.WriteStartElement(null, "OutsdIndx", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(OutsideIndexValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (FairValue is IsoActiveCurrencyAndAmount FairValueValue)
        {
            writer.WriteStartElement(null, "FairVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(FairValueValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ValueForFutures is IsoActiveCurrencyAndAmount ValueForFuturesValue)
        {
            writer.WriteStartElement(null, "ValForFutrs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(ValueForFuturesValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
    }
    public static ExchangeForPhysicalTradeParameters1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
