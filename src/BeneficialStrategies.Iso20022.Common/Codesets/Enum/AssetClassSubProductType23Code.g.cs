﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType23Code.  ISO2002 ID# _0UwTgVrBEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Seafood.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0UwTgVrBEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Seafood.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType23Code
{
    /// <summary>
    /// Commodity of type seafood.
    /// Encoded/decoded by serializers as "Seafood".
    /// </summary>
    [EnumMember(Value = "SEAF")]
    [IsoId("_0hERMVrBEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type seafood.")]
    Seafood,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType23CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType23CodeDropdownSource _dropdownSource = new AssetClassSubProductType23CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType23CodeDropdownRow GetMetadata(this AssetClassSubProductType23Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


