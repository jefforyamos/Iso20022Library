﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassTransactionType1Code.  ISO2002 ID# _Sv15QNDTEeSv_Pll20DdbA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code list of transaction type as specified by the trading venue.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Sv15QNDTEeSv_Pll20DdbA")]
[Description(@"Code list of transaction type as specified by the trading venue.")]
[DerivedFrom(typeof(AssetClassTransactionTypeCode))]
public enum AssetClassTransactionType1Code
{
    /// <summary>
    /// Crack.
    /// Encoded/decoded by serializers as "Crack".
    /// </summary>
    [EnumMember(Value = "CRCK")]
    [IsoId("_T3s5MdDTEeSv_Pll20DdbA")]
    [Description(@"Crack.")]
    Crack,
    
    /// <summary>
    /// Differential.
    /// Encoded/decoded by serializers as "Differential".
    /// </summary>
    [EnumMember(Value = "DIFF")]
    [IsoId("_T-YwAdDTEeSv_Pll20DdbA")]
    [Description(@"Differential.")]
    Differential,
    
    /// <summary>
    /// Futures.
    /// Encoded/decoded by serializers as "Futures".
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_UHUCgdDTEeSv_Pll20DdbA")]
    [Description(@"Futures.")]
    Futures,
    
    /// <summary>
    /// Minis.
    /// Encoded/decoded by serializers as "Minis".
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_UPMzMdDTEeSv_Pll20DdbA")]
    [Description(@"Minis.")]
    Minis,
    
    /// <summary>
    /// Options.
    /// 
    /// Encoded/decoded by serializers as "Options".
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_UWMMAdDTEeSv_Pll20DdbA")]
    [Description(@"Options. ")]
    Options,
    
    /// <summary>
    /// Over-The-Counter.
    /// Encoded/decoded by serializers as "OTC".
    /// </summary>
    [EnumMember(Value = "OTCT")]
    [IsoId("_UcS0AdDTEeSv_Pll20DdbA")]
    [Description(@"Over-The-Counter.")]
    OTC,
    
    /// <summary>
    /// Outright.
    /// Encoded/decoded by serializers as "Outright".
    /// </summary>
    [EnumMember(Value = "ORIT")]
    [IsoId("_UiF6AdDTEeSv_Pll20DdbA")]
    [Description(@"Outright.")]
    Outright,
    
    /// <summary>
    /// Swaps.
    /// Encoded/decoded by serializers as "Swaps".
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_Uo8I4dDTEeSv_Pll20DdbA")]
    [Description(@"Swaps.")]
    Swaps,
    
    /// <summary>
    /// TAPOS.
    /// Encoded/decoded by serializers as "TAPOS".
    /// </summary>
    [EnumMember(Value = "TAPO")]
    [IsoId("_UwYNodDTEeSv_Pll20DdbA")]
    [Description(@"TAPOS.")]
    TAPOS,
    
    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_RVvyYVCOEeWchIYf-qgDzg")]
    [Description(@"Other.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassTransactionType1CodeMetadataExtensions
{
    private static readonly AssetClassTransactionType1CodeDropdownSource _dropdownSource = new AssetClassTransactionType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassTransactionType1CodeDropdownRow GetMetadata(this AssetClassTransactionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


