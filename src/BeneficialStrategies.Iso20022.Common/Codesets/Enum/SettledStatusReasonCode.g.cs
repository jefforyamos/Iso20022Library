﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettledStatusReasonCode.  ISO2002 ID# _ZKsL9dp-Ed-ak6NoX_4Aeg_-13240435.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a partially settled status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZKsL9dp-Ed-ak6NoX_4Aeg_-13240435")]
[Description(@"Specifies the reason for a partially settled status.")]
public enum SettledStatusReasonCode
{
    /// <summary>
    /// Units are partially settled.
    /// </summary>
    [EnumMember(Value = "UPST")]
    [IsoId("_ZKsL9tp-Ed-ak6NoX_4Aeg_606549659")]
    [Description(@"Units are partially settled.")]
    UPST,
    
    /// <summary>
    /// Cash is partially settled.
    /// </summary>
    [EnumMember(Value = "CPST")]
    [IsoId("_ZKsL99p-Ed-ak6NoX_4Aeg_606549702")]
    [Description(@"Cash is partially settled.")]
    CPST,
    
    /// <summary>
    /// Units and cash are both partially settled.
    /// </summary>
    [EnumMember(Value = "UCPS")]
    [IsoId("_ZKsL-Np-Ed-ak6NoX_4Aeg_606549719")]
    [Description(@"Units and cash are both partially settled.")]
    UCPS,
    
    /// <summary>
    /// Redemption has been gated, all settlement will be done at the same price.
    /// </summary>
    [EnumMember(Value = "GAT1")]
    [IsoId("_1jZr8EgWEea9YuSvQGoi-w")]
    [Description(@"Redemption has been gated, all settlement will be done at the same price.")]
    GAT1,
    
    /// <summary>
    /// Redemption has been gated. Multiple redemptions and multiple prices will be required.
    /// </summary>
    [EnumMember(Value = "GATM")]
    [IsoId("_4wRQkEgWEea9YuSvQGoi-w")]
    [Description(@"Redemption has been gated. Multiple redemptions and multiple prices will be required.")]
    GATM,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettledStatusReasonCodeMetadataExtensions
{
    private static readonly SettledStatusReasonCodeDropdownSource _dropdownSource = new SettledStatusReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettledStatusReasonCodeDropdownRow GetMetadata(this SettledStatusReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


