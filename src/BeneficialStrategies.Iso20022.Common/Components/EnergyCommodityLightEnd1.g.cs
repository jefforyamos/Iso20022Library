﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EnergyCommodityLightEnd1.  ISO2002 ID# _68blkFrWEeWN79Bl6BUd3g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of an energy derivative of type light end.
/// </summary>
public partial record EnergyCommodityLightEnd1
     : IIsoXmlSerilizable<EnergyCommodityLightEnd1>
{
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType2Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public required AssetClassSubProductType27Code SubProduct { get; init; } 
    
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
    public static EnergyCommodityLightEnd1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
