﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassProductType8Code.  ISO2002 ID# _YDowcAnyEeWnS-yHF1QhNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Paper.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YDowcAnyEeWnS-yHF1QhNQ")]
[Description(@"Commodity derivative base product code list for Paper.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType8Code
{
    /// <summary>
    /// Commodity of type paper.
    /// Encoded/decoded by serializers as "PAPR".
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_qdn_gQnyEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type paper.")]
    Paper = AssetClassProductTypeCode.Paper, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassProductType8CodeMetadataExtensions
{
    private static readonly AssetClassProductType8CodeDropdownSource _dropdownSource = new AssetClassProductType8CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassProductType8CodeDropdownRow GetMetadata(this AssetClassProductType8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


