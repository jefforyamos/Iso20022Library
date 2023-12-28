﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceType15Code.  ISO2002 ID# _r56MocSqEeuBjv5G5kw00g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_r56MocSqEeuBjv5G5kw00g")]
[Description(@"Type of balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
public enum BalanceType15Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AmountOnHold".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_r_HcwcSqEeuBjv5G5kw00g")]
    [Description(@"??")]
    AmountOnHold,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AmountOwing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_r_Hcw8SqEeuBjv5G5kw00g")]
    [Description(@"??")]
    AmountOwing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AmountDue".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_r_HcxcSqEeuBjv5G5kw00g")]
    [Description(@"??")]
    AmountDue,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CreditLine".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_r_Hcx8SqEeuBjv5G5kw00g")]
    [Description(@"??")]
    CreditLine,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_r_HcycSqEeuBjv5G5kw00g")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_r_ID0cSqEeuBjv5G5kw00g")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Available".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_r_ID08SqEeuBjv5G5kw00g")]
    [Description(@"??")]
    Available,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClearedItem".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_r_ID1cSqEeuBjv5G5kw00g")]
    [Description(@"??")]
    ClearedItem,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Ledger".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_r_ID18SqEeuBjv5G5kw00g")]
    [Description(@"??")]
    Ledger,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Points".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_y5o-4cSqEeuBjv5G5kw00g")]
    [Description(@"??")]
    Points,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BalanceType15CodeMetadataExtensions
{
    private static readonly BalanceType15CodeDropdownSource _dropdownSource = new BalanceType15CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBalanceType15CodeDropdownRow GetMetadata(this BalanceType15Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


