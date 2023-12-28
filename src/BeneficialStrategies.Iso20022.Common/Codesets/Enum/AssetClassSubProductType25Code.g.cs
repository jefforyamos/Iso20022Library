﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType25Code.  ISO2002 ID# _hwjpcVrKEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Distillates.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hwjpcVrKEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Distillates.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType25Code
{
    /// <summary>
    /// Commodity of type distillates.
    /// Encoded/decoded by serializers as "Distillates".
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_h7wM2VrKEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type distillates.")]
    Distillates,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType25CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType25CodeDropdownSource _dropdownSource = new AssetClassSubProductType25CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType25CodeDropdownRow GetMetadata(this AssetClassSubProductType25Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


