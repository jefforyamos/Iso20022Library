﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassDetailedSubProductType14Code.  ISO2002 ID# _clWEkFuVEeWyucVx3N7tNg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Further sub product code list for commodity derivative Dry.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_clWEkFuVEeWyucVx3N7tNg")]
[Description(@"Further sub product code list for commodity derivative Dry.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType14Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DryBulkCarrier".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_fntCUFuVEeWyucVx3N7tNg")]
    [Description(@"??")]
    DryBulkCarrier,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassDetailedSubProductType14CodeMetadataExtensions
{
    private static readonly AssetClassDetailedSubProductType14CodeDropdownSource _dropdownSource = new AssetClassDetailedSubProductType14CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassDetailedSubProductType14CodeDropdownRow GetMetadata(this AssetClassDetailedSubProductType14Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

