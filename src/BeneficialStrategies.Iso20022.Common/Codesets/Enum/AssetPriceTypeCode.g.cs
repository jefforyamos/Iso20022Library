﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetPriceTypeCode.  ISO2002 ID# _EnANEBsTEeWhp-Wous5jzA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price for an asset.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EnANEBsTEeWhp-Wous5jzA")]
[Description(@"Specifies the type of price for an asset.")]
[Derivations(typeof(AssetPriceType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum AssetPriceTypeCode
{
    /// <summary>
    /// Argus / Mc Closkey price.
    /// Encoded/decoded by serializers as "ARGM".
    /// </summary>
    [EnumMember(Value = "ARGM")]
    [IsoId("_N3C1EBsTEeWhp-Wous5jzA")]
    [Description(@"Argus / Mc Closkey price.")]
    ArgusMcCloskey,
    
    /// <summary>
    /// Baltic price.
    /// Encoded/decoded by serializers as "BLTC".
    /// </summary>
    [EnumMember(Value = "BLTC")]
    [IsoId("_N-VI0BsTEeWhp-Wous5jzA")]
    [Description(@"Baltic price.")]
    Baltic,
    
    /// <summary>
    /// Exchange price.
    /// Encoded/decoded by serializers as "EXOF".
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("_OARCgBsTEeWhp-Wous5jzA")]
    [Description(@"Exchange price.")]
    Exchange,
    
    /// <summary>
    /// Global coal price.
    /// Encoded/decoded by serializers as "GBCL".
    /// </summary>
    [EnumMember(Value = "GBCL")]
    [IsoId("_OCDLMBsTEeWhp-Wous5jzA")]
    [Description(@"Global coal price.")]
    GlobalCoal,
    
    /// <summary>
    /// IHS Mc Closkey price.
    /// Encoded/decoded by serializers as "IHSM".
    /// </summary>
    [EnumMember(Value = "IHSM")]
    [IsoId("_OD_E4BsTEeWhp-Wous5jzA")]
    [Description(@"IHS Mc Closkey price.")]
    IHSMcCloskey,
    
    /// <summary>
    /// Platts price.
    /// Encoded/decoded by serializers as "PLAT".
    /// </summary>
    [EnumMember(Value = "PLAT")]
    [IsoId("_OFnckBsTEeWhp-Wous5jzA")]
    [Description(@"Platts price.")]
    Platts,
    
    /// <summary>
    /// Other price.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_OHjWQBsTEeWhp-Wous5jzA")]
    [Description(@"Other price.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetPriceTypeCodeMetadataExtensions
{
    private static readonly AssetPriceTypeCodeDropdownSource _dropdownSource = new AssetPriceTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetPriceTypeCodeDropdownRow GetMetadata(this AssetPriceTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


