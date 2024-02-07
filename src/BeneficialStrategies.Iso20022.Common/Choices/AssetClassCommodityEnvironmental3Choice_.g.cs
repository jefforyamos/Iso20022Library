﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AssetClassCommodityEnvironmental3Choice.  ISO2002 ID# _9bs7AU8REe2PGo0mhYCh1g.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Defines commodity attributes of a derivative where the type is environmental.
/// </summary>
[KnownType(typeof(AssetClassCommodityEnvironmental3Choice.Emissions))]
[KnownType(typeof(AssetClassCommodityEnvironmental3Choice.Weather))]
[KnownType(typeof(AssetClassCommodityEnvironmental3Choice.CarbonRelated))]
[KnownType(typeof(AssetClassCommodityEnvironmental3Choice.Other))]
public abstract partial record AssetClassCommodityEnvironmental3Choice_ : IIsoXmlSerilizable<AssetClassCommodityEnvironmental3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AssetClassCommodityEnvironmental3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Emssns" => AssetClassCommodityEnvironmental3Choice.Emissions.Deserialize(elementWithPayload),
             "Wthr" => AssetClassCommodityEnvironmental3Choice.Weather.Deserialize(elementWithPayload),
             "CrbnRltd" => AssetClassCommodityEnvironmental3Choice.CarbonRelated.Deserialize(elementWithPayload),
             "Othr" => AssetClassCommodityEnvironmental3Choice.Other.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AssetClassCommodityEnvironmental3Choice choice.")
        };
    }
}
