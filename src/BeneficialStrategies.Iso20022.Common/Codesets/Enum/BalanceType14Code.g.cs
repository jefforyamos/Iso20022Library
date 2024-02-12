﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceType14Code.  ISO2002 ID# _xzEMQFKTEeeFcfYfFkVztg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Encoded/decoded by serializers as "AMOH".
    /// </summary>
    [EnumMember(Value = "AMOH")]
    [IsoId("_nrrV0X0kEemfrNOe0zHQyg")]
    [Description(@"Amount put on hold.")]
    AmountOnHold = BalanceTypeCode.AmountOnHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of money owed
    /// Encoded/decoded by serializers as "AMTO".
    /// </summary>
    [EnumMember(Value = "AMTO")]
    [IsoId("_nrrV030kEemfrNOe0zHQyg")]
    [Description(@"Amount of money owed")]
    AmountOwing = BalanceTypeCode.AmountOwing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of money due.
    /// Encoded/decoded by serializers as "AMTD".
    /// </summary>
    [EnumMember(Value = "AMTD")]
    [IsoId("_nrrV1X0kEemfrNOe0zHQyg")]
    [Description(@"Amount of money due.")]
    AmountDue = BalanceTypeCode.AmountDue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit line available.
    /// Encoded/decoded by serializers as "CRDL".
    /// </summary>
    [EnumMember(Value = "CRDL")]
    [IsoId("_nrrV130kEemfrNOe0zHQyg")]
    [Description(@"Credit line available.")]
    CreditLine = BalanceTypeCode.CreditLine, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of balance defined at national level
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_nrrV2X0kEemfrNOe0zHQyg")]
    [Description(@"Other type of balance defined at national level")]
    OtherNational = BalanceTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of balance defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_nrrV230kEemfrNOe0zHQyg")]
    [Description(@"Other type of balance defined at private level.")]
    OtherPrivate = BalanceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as "AVLB".
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_nrrV3X0kEemfrNOe0zHQyg")]
    [Description(@"Balance of money or securities that is at the disposal of the account owner on the date specified.")]
    Available = BalanceTypeCode.Available, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cleared items balance. 
    /// Encoded/decoded by serializers as "CLRI".
    /// </summary>
    [EnumMember(Value = "CLRI")]
    [IsoId("_nrrV330kEemfrNOe0zHQyg")]
    [Description(@"Cleared items balance. ")]
    ClearedItem = BalanceTypeCode.ClearedItem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ledger balance refers to posted transactions (e.g. limit authorisation amount - posted transactions).
    /// Encoded/decoded by serializers as "LDGR".
    /// </summary>
    [EnumMember(Value = "LDGR")]
    [IsoId("_nrrV4X0kEemfrNOe0zHQyg")]
    [Description(@"Ledger balance refers to posted transactions (e.g. limit authorisation amount - posted transactions).")]
    Ledger = BalanceTypeCode.Ledger, // same ordinal as derivation source for type conversions
    
}
