﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Grain.  ISO2002 ID# _xG_LsU8SEe2PGo0mhYCh1g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityAgricultural6Choice;

/// <summary>
/// Grain agricultural commodity derivative.
/// </summary>
public partial record Grain : AssetClassCommodityAgricultural6Choice_
     , IIsoXmlSerilizable<Grain>
{
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType1Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public AssetClassSubProductType5Code? SubProduct { get; init; } 
    /// <summary>
    /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
    /// </summary>
    public AssetClassDetailedSubProductType30Code? AdditionalSubProduct { get; init; } 
    
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
        if (SubProduct is AssetClassSubProductType5Code SubProductValue)
        {
            writer.WriteStartElement(null, "SubPdct", xmlNamespace );
            writer.WriteValue(SubProductValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AdditionalSubProduct is AssetClassDetailedSubProductType30Code AdditionalSubProductValue)
        {
            writer.WriteStartElement(null, "AddtlSubPdct", xmlNamespace );
            writer.WriteValue(AdditionalSubProductValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static new Grain Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
