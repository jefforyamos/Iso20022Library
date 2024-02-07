﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Precious.  ISO2002 ID# _D1rdVQ2rEeW72qLtWESimw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityMetal1Choice;

/// <summary>
/// Precious metal commodity derivative.
/// </summary>
public partial record Precious : AssetClassCommodityMetal1Choice_
     , IIsoXmlSerilizable<Precious>
{
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType7Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public required AssetClassSubProductType16Code SubProduct { get; init; } 
    /// <summary>
    /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
    /// </summary>
    public required AssetClassDetailedSubProductType11Code AdditionalSubProduct { get; init; } 
    
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
        writer.WriteStartElement(null, "AddtlSubPdct", xmlNamespace );
        writer.WriteValue(AdditionalSubProduct.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Precious Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
