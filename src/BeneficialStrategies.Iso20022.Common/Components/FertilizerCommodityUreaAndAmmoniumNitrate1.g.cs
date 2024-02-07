﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FertilizerCommodityUreaAndAmmoniumNitrate1.  ISO2002 ID# _f4Fn8Fr2EeWN79Bl6BUd3g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of a fertilizer derivative of type urea and ammonium nitrate.
/// </summary>
public partial record FertilizerCommodityUreaAndAmmoniumNitrate1
     : IIsoXmlSerilizable<FertilizerCommodityUreaAndAmmoniumNitrate1>
{
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType5Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public required AssetClassSubProductType44Code SubProduct { get; init; } 
    
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
        writer.WriteStartElement(null, "SubPdct", xmlNamespace );
        writer.WriteValue(SubProduct.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static FertilizerCommodityUreaAndAmmoniumNitrate1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
