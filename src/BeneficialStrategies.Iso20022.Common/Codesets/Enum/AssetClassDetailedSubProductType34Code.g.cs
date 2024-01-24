﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassDetailedSubProductType34Code.  ISO2002 ID# _zzyMMbv6EeiLRYqS-r-R-A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Further sub product code list for commodity derivative Wet.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zzyMMbv6EeiLRYqS-r-R-A")]
[Description(@"Further sub product code list for commodity derivative Wet.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType34Code
{
    /// <summary>
    /// Commodity attribute of type tanker.
    /// Encoded/decoded by serializers as "TNKR".
    /// </summary>
    [EnumMember(Value = "TNKR")]
    [IsoId("_0Dk7sbv6EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type tanker.")]
    Tanker = AssetClassDetailedSubProductTypeCode.Tanker, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_2cukYbv6EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassDetailedSubProductType34CodeMetadataExtensions
{
    private static readonly AssetClassDetailedSubProductType34CodeDropdownSource _dropdownSource = new AssetClassDetailedSubProductType34CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassDetailedSubProductType34CodeDropdownRow GetMetadata(this AssetClassDetailedSubProductType34Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


