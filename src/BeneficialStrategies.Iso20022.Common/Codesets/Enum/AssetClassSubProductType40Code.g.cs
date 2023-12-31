﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType40Code.  ISO2002 ID# _VCgwEVr3EeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Diammonium Phosphate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VCgwEVr3EeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Diammonium Phosphate.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType40Code
{
    /// <summary>
    /// Commodity of type diammonium phosphate.
    /// Encoded/decoded by serializers as "DiammoniumPhosphate".
    /// </summary>
    [EnumMember(Value = "DAPH")]
    [IsoId("_VOFt81r3EeWN79Bl6BUd3g")]
    [Description(@"Commodity of type diammonium phosphate.")]
    DiammoniumPhosphate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType40CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType40CodeDropdownSource _dropdownSource = new AssetClassSubProductType40CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType40CodeDropdownRow GetMetadata(this AssetClassSubProductType40Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


