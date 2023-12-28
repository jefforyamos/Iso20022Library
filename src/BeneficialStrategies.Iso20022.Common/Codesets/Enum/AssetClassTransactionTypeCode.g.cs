﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassTransactionTypeCode.  ISO2002 ID# _yNs5MNDREeSv_Pll20DdbA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code list of transaction type as specified by the trading venue.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yNs5MNDREeSv_Pll20DdbA")]
[Description(@"Code list of transaction type as specified by the trading venue.")]
[Derivations(typeof(AssetClassTransactionType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum AssetClassTransactionTypeCode
{
    /// <summary>
    /// Futures.
    /// Encoded/decoded by serializers as "FUTR".
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_r5UUkNDSEeSv_Pll20DdbA")]
    [Description(@"Futures.")]
    Futures,
    
    /// <summary>
    /// Options.
    /// 
    /// Encoded/decoded by serializers as "OPTN".
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_sN_kENDSEeSv_Pll20DdbA")]
    [Description(@"Options. ")]
    Options,
    
    /// <summary>
    /// TAPOS.
    /// Encoded/decoded by serializers as "TAPO".
    /// </summary>
    [EnumMember(Value = "TAPO")]
    [IsoId("_sPoi0NDSEeSv_Pll20DdbA")]
    [Description(@"TAPOS.")]
    TAPOS,
    
    /// <summary>
    /// Swaps.
    /// Encoded/decoded by serializers as "SWAP".
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_sRargNDSEeSv_Pll20DdbA")]
    [Description(@"Swaps.")]
    Swaps,
    
    /// <summary>
    /// Minis.
    /// Encoded/decoded by serializers as "MINI".
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_sS55QNDSEeSv_Pll20DdbA")]
    [Description(@"Minis.")]
    Minis,
    
    /// <summary>
    /// Over-The-Counter.
    /// Encoded/decoded by serializers as "OTCT".
    /// </summary>
    [EnumMember(Value = "OTCT")]
    [IsoId("_sUiQ8NDSEeSv_Pll20DdbA")]
    [Description(@"Over-The-Counter.")]
    OTC,
    
    /// <summary>
    /// Outright.
    /// Encoded/decoded by serializers as "ORIT".
    /// </summary>
    [EnumMember(Value = "ORIT")]
    [IsoId("_DBDFINDTEeSv_Pll20DdbA")]
    [Description(@"Outright.")]
    Outright,
    
    /// <summary>
    /// Crack.
    /// Encoded/decoded by serializers as "CRCK".
    /// </summary>
    [EnumMember(Value = "CRCK")]
    [IsoId("_Kn13YNDTEeSv_Pll20DdbA")]
    [Description(@"Crack.")]
    Crack,
    
    /// <summary>
    /// Differential.
    /// Encoded/decoded by serializers as "DIFF".
    /// </summary>
    [EnumMember(Value = "DIFF")]
    [IsoId("_Lz_hcNDTEeSv_Pll20DdbA")]
    [Description(@"Differential.")]
    Differential,
    
    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Kt5UoFCOEeWchIYf-qgDzg")]
    [Description(@"Other.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassTransactionTypeCodeMetadataExtensions
{
    private static readonly AssetClassTransactionTypeCodeDropdownSource _dropdownSource = new AssetClassTransactionTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassTransactionTypeCodeDropdownRow GetMetadata(this AssetClassTransactionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


