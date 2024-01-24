﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LoyaltyTypeTransactionTotalsCode.  ISO2002 ID# _1pKiwNxiEeioifFt1dhnJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of Loyalty transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1pKiwNxiEeioifFt1dhnJA")]
[Description(@"Type of Loyalty transaction.")]
[Derivations(typeof(LoyaltyTypeTransactionTotals1Code))]
public enum LoyaltyTypeTransactionTotalsCode
{
    /// <summary>
    /// Direct or payment related award on a loyalty account. Award alone, award associated to a payment (may be with an additional award alone), award because of a payment resulting on rebates.
    /// Encoded/decoded by serializers as "AWRD".
    /// </summary>
    [EnumMember(Value = "AWRD")]
    [IsoId("_4bncQNxiEeioifFt1dhnJA")]
    [Description(@"Direct or payment related award on a loyalty account. Award alone, award associated to a payment (may be with an additional award alone), award because of a payment resulting on rebates.")]
    Award,
    
    /// <summary>
    /// Refund of a loyalty award transaction.
    /// Encoded/decoded by serializers as "AWRR".
    /// </summary>
    [EnumMember(Value = "AWRR")]
    [IsoId("_A-y-QNxjEeioifFt1dhnJA")]
    [Description(@"Refund of a loyalty award transaction.")]
    ReverseAward,
    
    /// <summary>
    /// Redemption on a loyalty account.
    /// Encoded/decoded by serializers as "REDE".
    /// </summary>
    [EnumMember(Value = "REDE")]
    [IsoId("_CxPMQNxjEeioifFt1dhnJA")]
    [Description(@"Redemption on a loyalty account.")]
    Redemption,
    
    /// <summary>
    /// Refund of a loyalty redemption transaction.
    /// Encoded/decoded by serializers as "REDR".
    /// </summary>
    [EnumMember(Value = "REDR")]
    [IsoId("_EN27QNxjEeioifFt1dhnJA")]
    [Description(@"Refund of a loyalty redemption transaction.")]
    ReverseRedemption,
    
    /// <summary>
    /// Rebate on a total amount, sale item amount, or sale items.
    /// Encoded/decoded by serializers as "REBA".
    /// </summary>
    [EnumMember(Value = "REBA")]
    [IsoId("_F8GlwNxjEeioifFt1dhnJA")]
    [Description(@"Rebate on a total amount, sale item amount, or sale items.")]
    Rebate,
    
    /// <summary>
    /// Refund of a loyalty rebate transaction.
    /// Encoded/decoded by serializers as "REBR".
    /// </summary>
    [EnumMember(Value = "REBR")]
    [IsoId("_HatRwNxjEeioifFt1dhnJA")]
    [Description(@"Refund of a loyalty rebate transaction.")]
    ReverseRebate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LoyaltyTypeTransactionTotalsCodeMetadataExtensions
{
    private static readonly LoyaltyTypeTransactionTotalsCodeDropdownSource _dropdownSource = new LoyaltyTypeTransactionTotalsCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILoyaltyTypeTransactionTotalsCodeDropdownRow GetMetadata(this LoyaltyTypeTransactionTotalsCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


