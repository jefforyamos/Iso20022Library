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
    /// Encoded/decoded by serializers as "CRCK".
    /// </summary>
    [EnumMember(Value = "CRCK")]
    [IsoId("_T3s5MdDTEeSv_Pll20DdbA")]
    [Description(@"Crack.")]
    Crack = AssetClassTransactionTypeCode.Crack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Differential.
    /// Encoded/decoded by serializers as "DIFF".
    /// </summary>
    [EnumMember(Value = "DIFF")]
    [IsoId("_T-YwAdDTEeSv_Pll20DdbA")]
    [Description(@"Differential.")]
    Differential = AssetClassTransactionTypeCode.Differential, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Futures.
    /// Encoded/decoded by serializers as "FUTR".
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_UHUCgdDTEeSv_Pll20DdbA")]
    [Description(@"Futures.")]
    Futures = AssetClassTransactionTypeCode.Futures, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Minis.
    /// Encoded/decoded by serializers as "MINI".
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_UPMzMdDTEeSv_Pll20DdbA")]
    [Description(@"Minis.")]
    Minis = AssetClassTransactionTypeCode.Minis, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Options.
    /// Encoded/decoded by serializers as "OPTN".
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_UWMMAdDTEeSv_Pll20DdbA")]
    [Description(@"Options.|")]
    Options = AssetClassTransactionTypeCode.Options, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Over-The-Counter.
    /// Encoded/decoded by serializers as "OTCT".
    /// </summary>
    [EnumMember(Value = "OTCT")]
    [IsoId("_UcS0AdDTEeSv_Pll20DdbA")]
    [Description(@"Over-The-Counter.")]
    OTC = AssetClassTransactionTypeCode.OTC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Outright.
    /// Encoded/decoded by serializers as "ORIT".
    /// </summary>
    [EnumMember(Value = "ORIT")]
    [IsoId("_UiF6AdDTEeSv_Pll20DdbA")]
    [Description(@"Outright.")]
    Outright = AssetClassTransactionTypeCode.Outright, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Swaps.
    /// Encoded/decoded by serializers as "SWAP".
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_Uo8I4dDTEeSv_Pll20DdbA")]
    [Description(@"Swaps.")]
    Swaps = AssetClassTransactionTypeCode.Swaps, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// TAPOS.
    /// Encoded/decoded by serializers as "TAPO".
    /// </summary>
    [EnumMember(Value = "TAPO")]
    [IsoId("_UwYNodDTEeSv_Pll20DdbA")]
    [Description(@"TAPOS.")]
    TAPOS = AssetClassTransactionTypeCode.TAPOS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_RVvyYVCOEeWchIYf-qgDzg")]
    [Description(@"Other.")]
    Other = AssetClassTransactionTypeCode.Other, // same ordinal as derivation source for type conversions
    
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


