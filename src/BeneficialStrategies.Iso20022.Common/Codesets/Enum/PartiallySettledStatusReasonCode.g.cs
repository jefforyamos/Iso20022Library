﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartiallySettledStatusReasonCode.  ISO2002 ID# _ZxcC49p-Ed-ak6NoX_4Aeg_-609114754.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a partially settled status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZxcC49p-Ed-ak6NoX_4Aeg_-609114754")]
[Description(@"Specifies the reason for a partially settled status.")]
[Derivations(typeof(PartiallySettledStatusReason1Code))]
// External derivations that should be provided by the proper interface are: 
public enum PartiallySettledStatusReasonCode
{
    /// <summary>
    /// Units are partially settled.
    /// Encoded/decoded by serializers as "UPST".
    /// </summary>
    [EnumMember(Value = "UPST")]
    [IsoId("_ZxcC5Np-Ed-ak6NoX_4Aeg_-536158421")]
    [Description(@"Units are partially settled.")]
    UnitsPartiallySettled,
    
    /// <summary>
    /// Cash is partially settled.
    /// Encoded/decoded by serializers as "CPST".
    /// </summary>
    [EnumMember(Value = "CPST")]
    [IsoId("_ZxcC5dp-Ed-ak6NoX_4Aeg_-536158386")]
    [Description(@"Cash is partially settled.")]
    CashPartiallySettled,
    
    /// <summary>
    /// Units and cash are both partially settled.
    /// Encoded/decoded by serializers as "UCPS".
    /// </summary>
    [EnumMember(Value = "UCPS")]
    [IsoId("_ZxcC5tp-Ed-ak6NoX_4Aeg_-536158096")]
    [Description(@"Units and cash are both partially settled.")]
    UnitsCashPartiallySettled,
    
    /// <summary>
    /// Final redemption proceeds are held back, pending annual financial audit approval.
    /// Encoded/decoded by serializers as "HOLA".
    /// </summary>
    [EnumMember(Value = "HOLA")]
    [IsoId("_ZxcC59p-Ed-ak6NoX_4Aeg_-107645612")]
    [Description(@"Final redemption proceeds are held back, pending annual financial audit approval.")]
    HoldBackPendingAudit,
    
    /// <summary>
    /// Final redemption proceeds are held back as the fund has been liquidated and is pending audit approval.
    /// Encoded/decoded by serializers as "HOLL".
    /// </summary>
    [EnumMember(Value = "HOLL")]
    [IsoId("_ZxcC6Np-Ed-ak6NoX_4Aeg_156481860")]
    [Description(@"Final redemption proceeds are held back as the fund has been liquidated and is pending audit approval.")]
    HoldBackLiquidation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartiallySettledStatusReasonCodeMetadataExtensions
{
    private static readonly PartiallySettledStatusReasonCodeDropdownSource _dropdownSource = new PartiallySettledStatusReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartiallySettledStatusReasonCodeDropdownRow GetMetadata(this PartiallySettledStatusReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


