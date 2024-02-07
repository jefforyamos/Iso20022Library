﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatisticsByUserDefinedTimePeriod1.  ISO2002 ID# _VZJM-tp-Ed-ak6NoX_4Aeg_16395281.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statistical data related to the price change of a security.
/// </summary>
public partial record StatisticsByUserDefinedTimePeriod1
     : IIsoXmlSerilizable<StatisticsByUserDefinedTimePeriod1>
{
    #nullable enable
    
    /// <summary>
    /// Reference period for the valuation.
    /// </summary>
    public required DateTimePeriodDetails Period { get; init; } 
    /// <summary>
    /// Highest price for the referenced period.
    /// </summary>
    public PriceValue1? HighestPriceValue { get; init; } 
    /// <summary>
    /// Lowest price for the referenced period.
    /// </summary>
    public PriceValue1? LowestPriceValue { get; init; } 
    /// <summary>
    /// Change in price since the last valuation.
    /// </summary>
    public PriceValue2? PriceChange { get; init; } 
    /// <summary>
    /// Rate of income from the financial instrument, usually calculated as total dividends or coupon interest available to investors in the last year,divided by the current price.
    /// </summary>
    public IsoPercentageRate? Yield { get; init; } 
    
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
        writer.WriteStartElement(null, "Prd", xmlNamespace );
        Period.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (HighestPriceValue is PriceValue1 HighestPriceValueValue)
        {
            writer.WriteStartElement(null, "HghstPricVal", xmlNamespace );
            HighestPriceValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LowestPriceValue is PriceValue1 LowestPriceValueValue)
        {
            writer.WriteStartElement(null, "LwstPricVal", xmlNamespace );
            LowestPriceValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PriceChange is PriceValue2 PriceChangeValue)
        {
            writer.WriteStartElement(null, "PricChng", xmlNamespace );
            PriceChangeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Yield is IsoPercentageRate YieldValue)
        {
            writer.WriteStartElement(null, "Yld", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(YieldValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
    }
    public static StatisticsByUserDefinedTimePeriod1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
