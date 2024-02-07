﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatisticsByPredefinedTimePeriods1.  ISO2002 ID# _VZS989p-Ed-ak6NoX_4Aeg_-616872931.
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
public partial record StatisticsByPredefinedTimePeriods1
     : IIsoXmlSerilizable<StatisticsByPredefinedTimePeriods1>
{
    #nullable enable
    
    /// <summary>
    /// Highest price for the referenced period.
    /// </summary>
    public PriceValue1? HighestPriceValue12Months { get; init; } 
    /// <summary>
    /// Lowest price for the referenced period.
    /// </summary>
    public PriceValue1? LowestPriceValue12Months { get; init; } 
    /// <summary>
    /// Change in price over a one year period.
    /// </summary>
    public PriceValue2? OneYearPriceChange { get; init; } 
    /// <summary>
    /// Change in price over a three year period.
    /// </summary>
    public PriceValue2? ThreeYearPriceChange { get; init; } 
    /// <summary>
    /// Change in price over a five year period.
    /// </summary>
    public PriceValue2? FiveYearPriceChange { get; init; } 
    
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
        if (HighestPriceValue12Months is PriceValue1 HighestPriceValue12MonthsValue)
        {
            writer.WriteStartElement(null, "HghstPricVal12Mnths", xmlNamespace );
            HighestPriceValue12MonthsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LowestPriceValue12Months is PriceValue1 LowestPriceValue12MonthsValue)
        {
            writer.WriteStartElement(null, "LwstPricVal12Mnths", xmlNamespace );
            LowestPriceValue12MonthsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OneYearPriceChange is PriceValue2 OneYearPriceChangeValue)
        {
            writer.WriteStartElement(null, "OneYrPricChng", xmlNamespace );
            OneYearPriceChangeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ThreeYearPriceChange is PriceValue2 ThreeYearPriceChangeValue)
        {
            writer.WriteStartElement(null, "ThreeYrPricChng", xmlNamespace );
            ThreeYearPriceChangeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FiveYearPriceChange is PriceValue2 FiveYearPriceChangeValue)
        {
            writer.WriteStartElement(null, "FiveYrPricChng", xmlNamespace );
            FiveYearPriceChangeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static StatisticsByPredefinedTimePeriods1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
