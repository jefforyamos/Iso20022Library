﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType1Code.  ISO2002 ID# _6aFcMAnyEeWnS-yHF1QhNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Grain Oil Seeds.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6aFcMAnyEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Grain Oil Seeds.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType1Code
{
    /// <summary>
    /// Commodity of type grain oil seeds.
    /// Encoded/decoded by serializers as "GROS".
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_LOvsMQnzEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type grain oil seeds.")]
    GrainOilSeeds = AssetClassSubProductTypeCode.GrainOilSeeds, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType1CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType1CodeDropdownSource _dropdownSource = new AssetClassSubProductType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType1CodeDropdownRow GetMetadata(this AssetClassSubProductType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


