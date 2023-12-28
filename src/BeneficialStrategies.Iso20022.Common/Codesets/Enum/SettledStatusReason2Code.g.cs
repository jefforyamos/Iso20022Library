﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettledStatusReason2Code.  ISO2002 ID# __AyMYEgWEea9YuSvQGoi-w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Partial settlement status information or information about gating.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__AyMYEgWEea9YuSvQGoi-w")]
[Description(@"Partial settlement status information or information about gating.")]
[DerivedFrom(typeof(SettledStatusReasonCode))]
public enum SettledStatusReason2Code
{
    /// <summary>
    /// Cash is partially settled.
    /// Encoded/decoded by serializers as "CashPartiallySettled".
    /// </summary>
    [EnumMember(Value = "CPST")]
    [IsoId("_Bf1BsUgXEea9YuSvQGoi-w")]
    [Description(@"Cash is partially settled.")]
    CashPartiallySettled,
    
    /// <summary>
    /// Redemption has been gated. Multiple redemptions and multiple prices will be required.
    /// Encoded/decoded by serializers as "GatedMultipleNAV".
    /// </summary>
    [EnumMember(Value = "GATM")]
    [IsoId("_BlVMwUgXEea9YuSvQGoi-w")]
    [Description(@"Redemption has been gated. Multiple redemptions and multiple prices will be required.")]
    GatedMultipleNAV,
    
    /// <summary>
    /// Redemption has been gated, all settlement will be done at the same price.
    /// Encoded/decoded by serializers as "GatedOneNAV".
    /// </summary>
    [EnumMember(Value = "GAT1")]
    [IsoId("_BrbNsUgXEea9YuSvQGoi-w")]
    [Description(@"Redemption has been gated, all settlement will be done at the same price.")]
    GatedOneNAV,
    
    /// <summary>
    /// Units and cash are both partially settled.
    /// Encoded/decoded by serializers as "UnitsCashPartiallySettled".
    /// </summary>
    [EnumMember(Value = "UCPS")]
    [IsoId("_BwfT4UgXEea9YuSvQGoi-w")]
    [Description(@"Units and cash are both partially settled.")]
    UnitsCashPartiallySettled,
    
    /// <summary>
    /// Units are partially settled.
    /// Encoded/decoded by serializers as "UnitsPartiallySettled".
    /// </summary>
    [EnumMember(Value = "UPST")]
    [IsoId("_B11t8UgXEea9YuSvQGoi-w")]
    [Description(@"Units are partially settled.")]
    UnitsPartiallySettled,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettledStatusReason2CodeMetadataExtensions
{
    private static readonly SettledStatusReason2CodeDropdownSource _dropdownSource = new SettledStatusReason2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettledStatusReason2CodeDropdownRow GetMetadata(this SettledStatusReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


