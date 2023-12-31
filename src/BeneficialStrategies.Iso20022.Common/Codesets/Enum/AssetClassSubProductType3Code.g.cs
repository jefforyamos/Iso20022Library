﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType3Code.  ISO2002 ID# _70F8EAnyEeWnS-yHF1QhNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Olive Oil.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_70F8EAnyEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Olive Oil.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType3Code
{
    /// <summary>
    /// Commodity of type olive oil.
    /// Encoded/decoded by serializers as "OliveOil".
    /// </summary>
    [EnumMember(Value = "OOLI")]
    [IsoId("_OOrBAQnzEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type olive oil.")]
    OliveOil,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType3CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType3CodeDropdownSource _dropdownSource = new AssetClassSubProductType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType3CodeDropdownRow GetMetadata(this AssetClassSubProductType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


