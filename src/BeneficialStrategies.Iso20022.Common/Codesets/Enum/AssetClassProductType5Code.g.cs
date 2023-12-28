﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassProductType5Code.  ISO2002 ID# _WMBukAnyEeWnS-yHF1QhNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Commodity derivative base product code list for Fertilizer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WMBukAnyEeWnS-yHF1QhNQ")]
[Description(@"Commodity derivative base product code list for Fertilizer.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType5Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Fertilizer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ie4nUQnyEeWnS-yHF1QhNQ")]
    [Description(@"??")]
    Fertilizer,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassProductType5CodeMetadataExtensions
{
    private static readonly AssetClassProductType5CodeDropdownSource _dropdownSource = new AssetClassProductType5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassProductType5CodeDropdownRow GetMetadata(this AssetClassProductType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


