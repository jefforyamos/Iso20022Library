﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EnvironmentalCommodityWeather2.  ISO2002 ID# _Dqy6gU8SEe2PGo0mhYCh1g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of an environmental derivative of type weather.
/// </summary>
public partial record EnvironmentalCommodityWeather2
     : IIsoXmlSerilizable<EnvironmentalCommodityWeather2>
{
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType3Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public AssetClassSubProductType30Code? SubProduct { get; init; } 
    
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
        writer.WriteStartElement(null, "BasePdct", xmlNamespace );
        writer.WriteValue(BaseProduct.ToString()); // Enum value
        writer.WriteEndElement();
        if (SubProduct is AssetClassSubProductType30Code SubProductValue)
        {
            writer.WriteStartElement(null, "SubPdct", xmlNamespace );
            writer.WriteValue(SubProductValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static EnvironmentalCommodityWeather2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
