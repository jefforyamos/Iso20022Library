﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Status7Code.  ISO2002 ID# _WMNrgF6uEeSyc4g_pm5hbw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an instruction/vote.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WMNrgF6uEeSyc4g_pm5hbw")]
[Description(@"Specifies the status of an instruction/vote.")]
[DerivedFrom(typeof(StatusCode))]
public enum Status7Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancelledBySubcustodian".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YyZqoF6uEeSyc4g_pm5hbw")]
    [Description(@"??")]
    CancelledBySubcustodian,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aCL3gV6uEeSyc4g_pm5hbw")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_agtmkV6uEeSyc4g_pm5hbw")]
    [Description(@"??")]
    Cancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Completed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a88PkV6uEeSyc4g_pm5hbw")]
    [Description(@"??")]
    Completed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotReceived".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_b10_YV6uEeSyc4g_pm5hbw")]
    [Description(@"??")]
    NotReceived,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivedByIssuerOrRegistrar".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_c1-00V6uEeSyc4g_pm5hbw")]
    [Description(@"??")]
    ReceivedByIssuerOrRegistrar,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StandingInstruction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dTZJkV6uEeSyc4g_pm5hbw")]
    [Description(@"??")]
    StandingInstruction,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Status7CodeMetadataExtensions
{
    private static readonly Status7CodeDropdownSource _dropdownSource = new Status7CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatus7CodeDropdownRow GetMetadata(this Status7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


