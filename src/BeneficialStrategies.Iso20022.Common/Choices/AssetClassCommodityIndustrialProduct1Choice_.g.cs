﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AssetClassCommodityIndustrialProduct1Choice.  ISO2002 ID# _5jkmIFrfEeWN79Bl6BUd3g.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Defines commodity attributes of a derivative where the type is industrial product.
/// </summary>
[KnownType(typeof(AssetClassCommodityIndustrialProduct1Choice.Construction))]
[KnownType(typeof(AssetClassCommodityIndustrialProduct1Choice.Manufacturing))]
public abstract partial record AssetClassCommodityIndustrialProduct1Choice_ : IIsoXmlSerilizable<AssetClassCommodityIndustrialProduct1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AssetClassCommodityIndustrialProduct1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cnstrctn" => AssetClassCommodityIndustrialProduct1Choice.Construction.Deserialize(elementWithPayload),
             "Manfctg" => AssetClassCommodityIndustrialProduct1Choice.Manufacturing.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AssetClassCommodityIndustrialProduct1Choice choice.")
        };
    }
}
