﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType37Code.  ISO2002 ID# _18yyEVryEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Pulp.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_18yyEVryEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Pulp.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType37Code
{
    /// <summary>
    /// Commodity of type pulp.
    /// Encoded/decoded by serializers as "PULP".
    /// </summary>
    [EnumMember(Value = "PULP")]
    [IsoId("_2IP0JVryEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type pulp.")]
    Pulp = AssetClassSubProductTypeCode.Pulp, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType37CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType37CodeDropdownSource _dropdownSource = new AssetClassSubProductType37CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType37CodeDropdownRow GetMetadata(this AssetClassSubProductType37Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


