﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassProductType6Code.  ISO2002 ID# _W0WS0AnyEeWnS-yHF1QhNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Commodity derivative base product code list for Industrial Product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_W0WS0AnyEeWnS-yHF1QhNQ")]
[Description(@"Commodity derivative base product code list for Industrial Product.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType6Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IndustrialProduct".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_lpqhQQnyEeWnS-yHF1QhNQ")]
    [Description(@"??")]
    IndustrialProduct,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassProductType6CodeMetadataExtensions
{
    private static readonly AssetClassProductType6CodeDropdownSource _dropdownSource = new AssetClassProductType6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassProductType6CodeDropdownRow GetMetadata(this AssetClassProductType6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

