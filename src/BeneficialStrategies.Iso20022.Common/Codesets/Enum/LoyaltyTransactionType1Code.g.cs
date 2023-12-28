﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LoyaltyTransactionType1Code.  ISO2002 ID# _2TFZoNuKEeiB5uLfkg9ZJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of loyalty transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2TFZoNuKEeiB5uLfkg9ZJA")]
[Description(@"Type of loyalty transaction.")]
[DerivedFrom(typeof(LoyaltyTransactionTypeCode))]
public enum LoyaltyTransactionType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Award".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4dBhoduKEeiB5uLfkg9ZJA")]
    [Description(@"??")]
    Award,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AwardRefund".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4hLB0duKEeiB5uLfkg9ZJA")]
    [Description(@"??")]
    AwardRefund,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RebateRefund".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4ltjkduKEeiB5uLfkg9ZJA")]
    [Description(@"??")]
    RebateRefund,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rebate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4sHtkduKEeiB5uLfkg9ZJA")]
    [Description(@"??")]
    Rebate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Redemption".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4yUcMduKEeiB5uLfkg9ZJA")]
    [Description(@"??")]
    Redemption,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RedemptionRefund".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_45L5MduKEeiB5uLfkg9ZJA")]
    [Description(@"??")]
    RedemptionRefund,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LoyaltyTransactionType1CodeMetadataExtensions
{
    private static readonly LoyaltyTransactionType1CodeDropdownSource _dropdownSource = new LoyaltyTransactionType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILoyaltyTransactionType1CodeDropdownRow GetMetadata(this LoyaltyTransactionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

