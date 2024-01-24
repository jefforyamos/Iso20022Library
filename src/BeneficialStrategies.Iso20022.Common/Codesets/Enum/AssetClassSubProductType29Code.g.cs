﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductType29Code.  ISO2002 ID# _eEGecVrNEeWN79Bl6BUd3g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product of type Carbon Related.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eEGecVrNEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Carbon Related.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType29Code
{
    /// <summary>
    /// Commodity of type carbon related.
    /// Encoded/decoded by serializers as "CRBR".
    /// </summary>
    [EnumMember(Value = "CRBR")]
    [IsoId("_ePRMoVrNEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type carbon related.")]
    CarbonRelated = AssetClassSubProductTypeCode.CarbonRelated, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductType29CodeMetadataExtensions
{
    private static readonly AssetClassSubProductType29CodeDropdownSource _dropdownSource = new AssetClassSubProductType29CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductType29CodeDropdownRow GetMetadata(this AssetClassSubProductType29Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


