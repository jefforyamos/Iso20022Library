﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AssetClassCommodityFertilizer4Choice.  ISO2002 ID# _icwoUU8REe2PGo0mhYCh1g.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Defines commodity attributes of a derivative where the type is fertilizer.
/// </summary>
[KnownType(typeof(AssetClassCommodityFertilizer4Choice.Ammonia))]
[KnownType(typeof(AssetClassCommodityFertilizer4Choice.DiammoniumPhosphate))]
[KnownType(typeof(AssetClassCommodityFertilizer4Choice.Potash))]
[KnownType(typeof(AssetClassCommodityFertilizer4Choice.Sulphur))]
[KnownType(typeof(AssetClassCommodityFertilizer4Choice.Urea))]
[KnownType(typeof(AssetClassCommodityFertilizer4Choice.UreaAndAmmoniumNitrate))]
[KnownType(typeof(AssetClassCommodityFertilizer4Choice.Other))]
public abstract partial record AssetClassCommodityFertilizer4Choice_ : IIsoXmlSerilizable<AssetClassCommodityFertilizer4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AssetClassCommodityFertilizer4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Ammn" => AssetClassCommodityFertilizer4Choice.Ammonia.Deserialize(elementWithPayload),
             "DmmnmPhspht" => AssetClassCommodityFertilizer4Choice.DiammoniumPhosphate.Deserialize(elementWithPayload),
             "Ptsh" => AssetClassCommodityFertilizer4Choice.Potash.Deserialize(elementWithPayload),
             "Slphr" => AssetClassCommodityFertilizer4Choice.Sulphur.Deserialize(elementWithPayload),
             "Urea" => AssetClassCommodityFertilizer4Choice.Urea.Deserialize(elementWithPayload),
             "UreaAndAmmnmNtrt" => AssetClassCommodityFertilizer4Choice.UreaAndAmmoniumNitrate.Deserialize(elementWithPayload),
             "Othr" => AssetClassCommodityFertilizer4Choice.Other.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AssetClassCommodityFertilizer4Choice choice.")
        };
    }
}
