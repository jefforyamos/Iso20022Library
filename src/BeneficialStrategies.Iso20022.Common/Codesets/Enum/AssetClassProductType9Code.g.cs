﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassProductType9Code.  ISO2002 ID# _YnMwgAnyEeWnS-yHF1QhNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Commodity derivative base product code list for Polypropylene.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YnMwgAnyEeWnS-yHF1QhNQ")]
[Description(@"Commodity derivative base product code list for Polypropylene.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType9Code
{
    /// <summary>
    /// Commodity of type polypropylene.
    /// Encoded/decoded by serializers as "POLY".
    /// </summary>
    [EnumMember(Value = "POLY")]
    [IsoId("_sc03IQnyEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type polypropylene.")]
    Polypropylene = AssetClassProductTypeCode.Polypropylene, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassProductType9CodeMetadataExtensions
{
    private static readonly AssetClassProductType9CodeDropdownSource _dropdownSource = new AssetClassProductType9CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassProductType9CodeDropdownRow GetMetadata(this AssetClassProductType9Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


