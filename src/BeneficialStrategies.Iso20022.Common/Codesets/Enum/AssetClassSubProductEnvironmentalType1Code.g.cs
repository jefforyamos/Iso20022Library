﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductEnvironmentalType1Code.  ISO2002 ID# _YuxOQM5AEeSc85GUbgBycw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code list for environmental related derivative contracts.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YuxOQM5AEeSc85GUbgBycw")]
[Description(@"Code list for environmental related derivative contracts.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductEnvironmentalType1Code
{
    /// <summary>
    /// Commodity of type emission.
    /// Encoded/decoded by serializers as "Emission".
    /// </summary>
    [EnumMember(Value = "EMIS")]
    [IsoId("_mjMYsc5GEeSc85GUbgBycw")]
    [Description(@"Commodity of type emission.")]
    Emission,
    
    /// <summary>
    /// Commodity of type weather.
    /// Encoded/decoded by serializers as "Weather".
    /// </summary>
    [EnumMember(Value = "WTHR")]
    [IsoId("_mzjv8c5GEeSc85GUbgBycw")]
    [Description(@"Commodity of type weather.")]
    Weather,
    
    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_jVjxIUDbEeWOL-OsSq2h6w")]
    [Description(@"Commodity of other type.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductEnvironmentalType1CodeMetadataExtensions
{
    private static readonly AssetClassSubProductEnvironmentalType1CodeDropdownSource _dropdownSource = new AssetClassSubProductEnvironmentalType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductEnvironmentalType1CodeDropdownRow GetMetadata(this AssetClassSubProductEnvironmentalType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


