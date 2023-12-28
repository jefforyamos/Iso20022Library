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
    /// Amount put on hold.
    /// Encoded/decoded by serializers as "AmountOnHold".
    /// </summary>
    [EnumMember(Value = "AMOH")]
    [IsoId("_r_HcwcSqEeuBjv5G5kw00g")]
    [Description(@"Amount put on hold.")]
    AmountOnHold,
    
    /// <summary>
    /// Amount of money owed
    /// Encoded/decoded by serializers as "AmountOwing".
    /// </summary>
    [EnumMember(Value = "AMTO")]
    [IsoId("_r_Hcw8SqEeuBjv5G5kw00g")]
    [Description(@"Amount of money owed")]
    AmountOwing,
    
    /// <summary>
    /// Amount of money due.
    /// Encoded/decoded by serializers as "AmountDue".
    /// </summary>
    [EnumMember(Value = "AMTD")]
    [IsoId("_r_HcxcSqEeuBjv5G5kw00g")]
    [Description(@"Amount of money due.")]
    AmountDue,
    
    /// <summary>
    /// Credit line available.
    /// Encoded/decoded by serializers as "CreditLine".
    /// </summary>
    [EnumMember(Value = "CRDL")]
    [IsoId("_r_Hcx8SqEeuBjv5G5kw00g")]
    [Description(@"Credit line available.")]
    CreditLine,
    
    /// <summary>
    /// Other type of balance defined at national level
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_r_HcycSqEeuBjv5G5kw00g")]
    [Description(@"Other type of balance defined at national level")]
    OtherNational,
    
    /// <summary>
    /// Other type of balance defined at private level.
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_r_ID0cSqEeuBjv5G5kw00g")]
    [Description(@"Other type of balance defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "Available".
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_r_ID08SqEeuBjv5G5kw00g")]
    [Description(@"Balance of money or securities that is at the disposal of the account owner on the date specified.")]
    Available,
    
    /// <summary>
    /// Cleared items balance. 
    /// Encoded/decoded by serializers as "ClearedItem".
    /// </summary>
    [EnumMember(Value = "CLRI")]
    [IsoId("_r_ID1cSqEeuBjv5G5kw00g")]
    [Description(@"Cleared items balance. ")]
    ClearedItem,
    
    /// <summary>
    /// Ledger balance refers to posted transactions (e.g. limit authorisation amount - posted transactions).
    /// Encoded/decoded by serializers as "Ledger".
    /// </summary>
    [EnumMember(Value = "LDGR")]
    [IsoId("_r_ID18SqEeuBjv5G5kw00g")]
    [Description(@"Ledger balance refers to posted transactions (e.g. limit authorisation amount - posted transactions).")]
    Ledger,
    
    /// <summary>
    /// Value expressed in points.
    /// Encoded/decoded by serializers as "Points".
    /// </summary>
    [EnumMember(Value = "PNTS")]
    [IsoId("_y5o-4cSqEeuBjv5G5kw00g")]
    [Description(@"Value expressed in points.")]
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


