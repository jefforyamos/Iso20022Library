﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType6Code.  ISO2002 ID# _-FIKkAnyEeWnS-yHF1QhNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Electricity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-FIKkAnyEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Electricity.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType6Code
{
    /// <summary>
    /// Commodity of type electricity.
    /// Encoded/decoded by serializers as "ELEC".
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_61phYQnzEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type electricity.")]
    Electricity = AssetClassSubProductTypeCode.Electricity, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType6CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType6CodeDropdownSource _dropdownSource = new AssetClassSubProductType6CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType6CodeDropdownRow GetMetadata(this AssetClassSubProductType6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


