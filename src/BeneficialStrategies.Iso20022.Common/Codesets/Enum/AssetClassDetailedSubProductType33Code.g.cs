﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassDetailedSubProductType33Code.  ISO2002 ID# _Ged_Ibv6EeiLRYqS-r-R-A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Further sub product code list for commodity derivative Dry.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ged_Ibv6EeiLRYqS-r-R-A")]
[Description(@"Further sub product code list for commodity derivative Dry.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType33Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DryBulkCarrier".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Gov8gbv6EeiLRYqS-r-R-A")]
    [Description(@"??")]
    DryBulkCarrier,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Ktu04bv6EeiLRYqS-r-R-A")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassDetailedSubProductType33CodeMetadataExtensions
{
    private static readonly AssetClassDetailedSubProductType33CodeDropdownSource _dropdownSource = new AssetClassDetailedSubProductType33CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassDetailedSubProductType33CodeDropdownRow GetMetadata(this AssetClassDetailedSubProductType33Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

