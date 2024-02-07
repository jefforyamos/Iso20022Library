﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Construction.  ISO2002 ID# _OTrSERZZEe2QNcZTDeoKnQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityIndustrialProduct2Choice;

/// <summary>
/// Construction related industrial product commodity derivative.
/// </summary>
public partial record Construction : AssetClassCommodityIndustrialProduct2Choice_
     , IIsoXmlSerilizable<Construction>
{
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType6Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public AssetClassSubProductType33Code? SubProduct { get; init; } 
    
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
        if (SubProduct is AssetClassSubProductType33Code SubProductValue)
        {
            writer.WriteStartElement(null, "SubPdct", xmlNamespace );
            writer.WriteValue(SubProductValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static new Construction Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
