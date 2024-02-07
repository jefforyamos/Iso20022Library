﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AssetClassCommodityAgricultural1Choice.  ISO2002 ID# _VQFYWw2jEeW72qLtWESimw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Defines commodity attributes of a derivative where the type is agricultural.
/// </summary>
[KnownType(typeof(AssetClassCommodityAgricultural1Choice.GrainOilSeed))]
[KnownType(typeof(AssetClassCommodityAgricultural1Choice.Soft))]
[KnownType(typeof(AssetClassCommodityAgricultural1Choice.Potato))]
[KnownType(typeof(AssetClassCommodityAgricultural1Choice.OliveOil))]
[KnownType(typeof(AssetClassCommodityAgricultural1Choice.Dairy))]
[KnownType(typeof(AssetClassCommodityAgricultural1Choice.Forestry))]
[KnownType(typeof(AssetClassCommodityAgricultural1Choice.Seafood))]
[KnownType(typeof(AssetClassCommodityAgricultural1Choice.LiveStock))]
[KnownType(typeof(AssetClassCommodityAgricultural1Choice.Grain))]
public abstract partial record AssetClassCommodityAgricultural1Choice_ : IIsoXmlSerilizable<AssetClassCommodityAgricultural1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AssetClassCommodityAgricultural1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "GrnOilSeed" => AssetClassCommodityAgricultural1Choice.GrainOilSeed.Deserialize(elementWithPayload),
             "Soft" => AssetClassCommodityAgricultural1Choice.Soft.Deserialize(elementWithPayload),
             "Ptt" => AssetClassCommodityAgricultural1Choice.Potato.Deserialize(elementWithPayload),
             "OlvOil" => AssetClassCommodityAgricultural1Choice.OliveOil.Deserialize(elementWithPayload),
             "Dairy" => AssetClassCommodityAgricultural1Choice.Dairy.Deserialize(elementWithPayload),
             "Frstry" => AssetClassCommodityAgricultural1Choice.Forestry.Deserialize(elementWithPayload),
             "Sfd" => AssetClassCommodityAgricultural1Choice.Seafood.Deserialize(elementWithPayload),
             "LiveStock" => AssetClassCommodityAgricultural1Choice.LiveStock.Deserialize(elementWithPayload),
             "Grn" => AssetClassCommodityAgricultural1Choice.Grain.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AssetClassCommodityAgricultural1Choice choice.")
        };
    }
}
