﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Status9Code.  ISO2002 ID# _2GrRoPNvEeqRfth943bvEA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2GrRoPNvEeqRfth943bvEA")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(StatusV2Code))]
public enum Status9Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Accepted".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_8eAnIfNvEeqRfth943bvEA")]
    [Description(@"??")]
    Accepted,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AttendanceConfirmed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9EsMofNvEeqRfth943bvEA")]
    [Description(@"??")]
    AttendanceConfirmed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9qfBUfNvEeqRfth943bvEA")]
    [Description(@"??")]
    Cancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancelledBySubcustodian".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_94UpAfNvEeqRfth943bvEA")]
    [Description(@"??")]
    CancelledBySubcustodian,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Forwarded".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-fmEYfNvEeqRfth943bvEA")]
    [Description(@"??")]
    Forwarded,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReceivedByIssuerOrRegistrar".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__E8NIfNvEeqRfth943bvEA")]
    [Description(@"??")]
    ReceivedByIssuerOrRegistrar,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegisteredToParticipateAtMeeting".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__qkpwfNvEeqRfth943bvEA")]
    [Description(@"??")]
    RegisteredToParticipateAtMeeting,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StandingInstruction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_AMfrEfNwEeqRfth943bvEA")]
    [Description(@"??")]
    StandingInstruction,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Status9CodeMetadataExtensions
{
    private static readonly Status9CodeDropdownSource _dropdownSource = new Status9CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatus9CodeDropdownRow GetMetadata(this Status9Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

