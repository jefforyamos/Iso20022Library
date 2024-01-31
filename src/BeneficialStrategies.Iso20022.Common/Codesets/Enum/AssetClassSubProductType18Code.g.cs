﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType18Code.  ISO2002 ID# _G2wYQAnzEeWnS-yHF1QhNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Plastic.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_G2wYQAnzEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Plastic.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType18Code
{
    /// <summary>
    /// Commodity of type plastic.
    /// Encoded/decoded by serializers as "PLST".
    /// </summary>
    [EnumMember(Value = "PLST")]
    [IsoId("_AZyv0Q2sEeW72qLtWESimw")]
    [Description(@"Commodity of type plastic.")]
    Plastic = AssetClassSubProductTypeCode.Plastic, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType18CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType18CodeDropdownSource _dropdownSource = new AssetClassSubProductType18CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType18CodeDropdownRow GetMetadata(this AssetClassSubProductType18Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


