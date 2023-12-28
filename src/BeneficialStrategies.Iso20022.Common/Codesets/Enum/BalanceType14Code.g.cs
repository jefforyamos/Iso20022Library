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
    /// ??
    /// Encoded/decoded by serializers as "AmountOnHold".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nrrV0X0kEemfrNOe0zHQyg")]
    [Description(@"??")]
    AmountOnHold,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AmountOwing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nrrV030kEemfrNOe0zHQyg")]
    [Description(@"??")]
    AmountOwing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AmountDue".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nrrV1X0kEemfrNOe0zHQyg")]
    [Description(@"??")]
    AmountDue,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CreditLine".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nrrV130kEemfrNOe0zHQyg")]
    [Description(@"??")]
    CreditLine,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nrrV2X0kEemfrNOe0zHQyg")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nrrV230kEemfrNOe0zHQyg")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Available".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nrrV3X0kEemfrNOe0zHQyg")]
    [Description(@"??")]
    Available,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClearedItem".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nrrV330kEemfrNOe0zHQyg")]
    [Description(@"??")]
    ClearedItem,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Ledger".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nrrV4X0kEemfrNOe0zHQyg")]
    [Description(@"??")]
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


