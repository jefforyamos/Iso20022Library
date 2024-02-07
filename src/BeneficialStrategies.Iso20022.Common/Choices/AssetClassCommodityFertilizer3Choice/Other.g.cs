﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _QbBSYLv7EeiLRYqS-r-R-A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityFertilizer3Choice;

/// <summary>
/// Other fertilizer commodity derivative.
/// </summary>
public partial record Other : AssetClassCommodityFertilizer3Choice_
     , IIsoXmlSerilizable<Other>
{
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType5Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public required AssetClassSubProductType49Code SubProduct { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "BasePdct", xmlNamespace );
        writer.WriteValue(BaseProduct.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SubPdct", xmlNamespace );
        writer.WriteValue(SubProduct.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Other Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
