﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceType14Code.  ISO2002 ID# _xzEMQFKTEeeFcfYfFkVztg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xzEMQFKTEeeFcfYfFkVztg")]
[Description(@"Type of balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
public enum BalanceType14Code
{
    /// <summary>
    /// Amount put on hold.
    /// Encoded/decoded by serializers as "AmountOnHold".
    /// </summary>
    [EnumMember(Value = "AMOH")]
    [IsoId("_nrrV0X0kEemfrNOe0zHQyg")]
    [Description(@"Amount put on hold.")]
    AmountOnHold,
    
    /// <summary>
    /// Amount of money owed
    /// Encoded/decoded by serializers as "AmountOwing".
    /// </summary>
    [EnumMember(Value = "AMTO")]
    [IsoId("_nrrV030kEemfrNOe0zHQyg")]
    [Description(@"Amount of money owed")]
    AmountOwing,
    
    /// <summary>
    /// Amount of money due.
    /// Encoded/decoded by serializers as "AmountDue".
    /// </summary>
    [EnumMember(Value = "AMTD")]
    [IsoId("_nrrV1X0kEemfrNOe0zHQyg")]
    [Description(@"Amount of money due.")]
    AmountDue,
    
    /// <summary>
    /// Credit line available.
    /// Encoded/decoded by serializers as "CreditLine".
    /// </summary>
    [EnumMember(Value = "CRDL")]
    [IsoId("_nrrV130kEemfrNOe0zHQyg")]
    [Description(@"Credit line available.")]
    CreditLine,
    
    /// <summary>
    /// Other type of balance defined at national level
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_nrrV2X0kEemfrNOe0zHQyg")]
    [Description(@"Other type of balance defined at national level")]
    OtherNational,
    
    /// <summary>
    /// Other type of balance defined at private level.
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_nrrV230kEemfrNOe0zHQyg")]
    [Description(@"Other type of balance defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "Available".
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_nrrV3X0kEemfrNOe0zHQyg")]
    [Description(@"Balance of money or securities that is at the disposal of the account owner on the date specified.")]
    Available,
    
    /// <summary>
    /// Cleared items balance. 
    /// Encoded/decoded by serializers as "ClearedItem".
    /// </summary>
    [EnumMember(Value = "CLRI")]
    [IsoId("_nrrV330kEemfrNOe0zHQyg")]
    [Description(@"Cleared items balance. ")]
    ClearedItem,
    
    /// <summary>
    /// Ledger balance refers to posted transactions (e.g. limit authorisation amount - posted transactions).
    /// Encoded/decoded by serializers as "Ledger".
    /// </summary>
    [EnumMember(Value = "LDGR")]
    [IsoId("_nrrV4X0kEemfrNOe0zHQyg")]
    [Description(@"Ledger balance refers to posted transactions (e.g. limit authorisation amount - posted transactions).")]
    Ledger,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BalanceType14CodeMetadataExtensions
{
    private static readonly BalanceType14CodeDropdownSource _dropdownSource = new BalanceType14CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBalanceType14CodeDropdownRow GetMetadata(this BalanceType14Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


