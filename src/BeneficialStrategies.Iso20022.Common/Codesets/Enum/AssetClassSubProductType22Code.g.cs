﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType22Code.  ISO2002 ID# _jP1PYVrAEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Livestock.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jP1PYVrAEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Livestock.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType22Code
{
    /// <summary>
    /// Commodity of type livestock.
    /// Encoded/decoded by serializers as "LSTK".
    /// </summary>
    [EnumMember(Value = "LSTK")]
    [IsoId("_kxU3UVrAEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type livestock.")]
    Livestock = AssetClassSubProductTypeCode.Livestock, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType22CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType22CodeDropdownSource _dropdownSource = new AssetClassSubProductType22CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType22CodeDropdownRow GetMetadata(this AssetClassSubProductType22Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


