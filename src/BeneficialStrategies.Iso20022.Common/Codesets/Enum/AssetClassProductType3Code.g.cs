﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassProductType3Code.  ISO2002 ID# _VrcxEAnyEeWnS-yHF1QhNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Commodity derivative base product code list for Environmental.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VrcxEAnyEeWnS-yHF1QhNQ")]
[Description(@"Commodity derivative base product code list for Environmental.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType3Code
{
    /// <summary>
    /// Commodity of type environmental.
    /// Encoded/decoded by serializers as "Environmental".
    /// </summary>
    [EnumMember(Value = "ENVR")]
    [IsoId("_hLbbYQnyEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type environmental.")]
    Environmental,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassProductType3CodeMetadataExtensions
{
    private static readonly AssetClassProductType3CodeDropdownSource _dropdownSource = new AssetClassProductType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassProductType3CodeDropdownRow GetMetadata(this AssetClassProductType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


