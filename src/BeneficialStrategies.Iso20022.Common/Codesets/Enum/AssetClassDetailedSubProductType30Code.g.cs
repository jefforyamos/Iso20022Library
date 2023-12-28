﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassDetailedSubProductType30Code.  ISO2002 ID# _TcElYbv3EeiLRYqS-r-R-A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Further sub product code list for commodity derivative Grain.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TcElYbv3EeiLRYqS-r-R-A")]
[Description(@"Further sub product code list for commodity derivative Grain.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType30Code
{
    /// <summary>
    /// Commodity attribute of type milled wheat.
    /// Encoded/decoded by serializers as "MillingWheat".
    /// </summary>
    [EnumMember(Value = "MWHT")]
    [IsoId("_Tlws4bv3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type milled wheat.")]
    MillingWheat,
    
    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VhCGwbv3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of other type.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassDetailedSubProductType30CodeMetadataExtensions
{
    private static readonly AssetClassDetailedSubProductType30CodeDropdownSource _dropdownSource = new AssetClassDetailedSubProductType30CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassDetailedSubProductType30CodeDropdownRow GetMetadata(this AssetClassDetailedSubProductType30Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


