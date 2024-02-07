﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EnergyCommodityOil2.  ISO2002 ID# _KQETYbv4EeiLRYqS-r-R-A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of an energy derivative of type oil.
/// </summary>
public partial record EnergyCommodityOil2
     : IIsoXmlSerilizable<EnergyCommodityOil2>
{
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType2Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public required AssetClassSubProductType8Code SubProduct { get; init; } 
    /// <summary>
    /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
    /// </summary>
    public required AssetClassDetailedSubProductType32Code AdditionalSubProduct { get; init; } 
    
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
        writer.WriteStartElement(null, "AddtlSubPdct", xmlNamespace );
        writer.WriteValue(AdditionalSubProduct.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static EnergyCommodityOil2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
