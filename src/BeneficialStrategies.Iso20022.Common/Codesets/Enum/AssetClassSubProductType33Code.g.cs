﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType33Code.  ISO2002 ID# _yGUxcVrfEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Construction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yGUxcVrfEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Construction.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType33Code
{
    /// <summary>
    /// Commodity of type construction.
    /// Encoded/decoded by serializers as "CSTR".
    /// </summary>
    [EnumMember(Value = "CSTR")]
    [IsoId("_yRs7A1rfEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type construction.")]
    Construction = AssetClassSubProductTypeCode.Construction, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType33CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType33CodeDropdownSource _dropdownSource = new AssetClassSubProductType33CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType33CodeDropdownRow GetMetadata(this AssetClassSubProductType33Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


