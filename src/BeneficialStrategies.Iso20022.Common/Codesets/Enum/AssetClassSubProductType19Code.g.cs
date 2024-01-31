﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType19Code.  ISO2002 ID# _R3EAsA3oEeWc7_0KPiuk6w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Other C10.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_R3EAsA3oEeWc7_0KPiuk6w")]
[Description(@"Defines the sub-product of type Other C10.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType19Code
{
    /// <summary>
    /// Commodity of type deliverable.
    /// Encoded/decoded by serializers as "DLVR".
    /// </summary>
    [EnumMember(Value = "DLVR")]
    [IsoId("_TB5cIQ3oEeWc7_0KPiuk6w")]
    [Description(@"Commodity of type deliverable.")]
    Deliverable = AssetClassSubProductTypeCode.Deliverable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of type non deliverable.
    /// Encoded/decoded by serializers as "NDLV".
    /// </summary>
    [EnumMember(Value = "NDLV")]
    [IsoId("_T0xqkQ3oEeWc7_0KPiuk6w")]
    [Description(@"Commodity of type non deliverable.")]
    NonDeliverable = AssetClassSubProductTypeCode.NonDeliverable, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType19CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType19CodeDropdownSource _dropdownSource = new AssetClassSubProductType19CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType19CodeDropdownRow GetMetadata(this AssetClassSubProductType19Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


