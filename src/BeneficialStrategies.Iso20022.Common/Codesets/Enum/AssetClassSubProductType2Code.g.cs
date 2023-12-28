﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType2Code.  ISO2002 ID# _7HmpgAnyEeWnS-yHF1QhNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Softs.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7HmpgAnyEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Softs.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Softs".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_MkTJ4QnzEeWnS-yHF1QhNQ")]
    [Description(@"??")]
    Softs,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType2CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType2CodeDropdownSource _dropdownSource = new AssetClassSubProductType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType2CodeDropdownRow GetMetadata(this AssetClassSubProductType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

