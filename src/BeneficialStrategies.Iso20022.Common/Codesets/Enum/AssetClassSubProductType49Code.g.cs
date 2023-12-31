﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType49Code.  ISO2002 ID# _LNGI4bvjEeiLRYqS-r-R-A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type as Other.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LNGI4bvjEeiLRYqS-r-R-A")]
[Description(@"Defines the sub-product of type as Other.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType49Code
{
    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_QA-HkbvjEeiLRYqS-r-R-A")]
    [Description(@"Commodity of other type.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType49CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType49CodeDropdownSource _dropdownSource = new AssetClassSubProductType49CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType49CodeDropdownRow GetMetadata(this AssetClassSubProductType49Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


