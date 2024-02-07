﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AssetClassCommodityFertilizer1Choice.  ISO2002 ID# _J_XoMFr2EeWN79Bl6BUd3g.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Defines commodity attributes of a derivative where the type is fertilizer.
/// </summary>
[KnownType(typeof(AssetClassCommodityFertilizer1Choice.Ammonia))]
[KnownType(typeof(AssetClassCommodityFertilizer1Choice.DiammoniumPhosphate))]
[KnownType(typeof(AssetClassCommodityFertilizer1Choice.Potash))]
[KnownType(typeof(AssetClassCommodityFertilizer1Choice.Sulphur))]
[KnownType(typeof(AssetClassCommodityFertilizer1Choice.Urea))]
[KnownType(typeof(AssetClassCommodityFertilizer1Choice.UreaAndAmmoniumNitrate))]
public abstract partial record AssetClassCommodityFertilizer1Choice_ : IIsoXmlSerilizable<AssetClassCommodityFertilizer1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AssetClassCommodityFertilizer1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Ammn" => AssetClassCommodityFertilizer1Choice.Ammonia.Deserialize(elementWithPayload),
             "DmmnmPhspht" => AssetClassCommodityFertilizer1Choice.DiammoniumPhosphate.Deserialize(elementWithPayload),
             "Ptsh" => AssetClassCommodityFertilizer1Choice.Potash.Deserialize(elementWithPayload),
             "Slphr" => AssetClassCommodityFertilizer1Choice.Sulphur.Deserialize(elementWithPayload),
             "Urea" => AssetClassCommodityFertilizer1Choice.Urea.Deserialize(elementWithPayload),
             "UreaAndAmmnmNtrt" => AssetClassCommodityFertilizer1Choice.UreaAndAmmoniumNitrate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AssetClassCommodityFertilizer1Choice choice.")
        };
    }
}
