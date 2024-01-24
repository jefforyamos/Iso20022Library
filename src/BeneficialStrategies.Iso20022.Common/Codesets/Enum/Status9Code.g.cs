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
    /// Instruction has been accepted and is validated for further processing.
    /// Encoded/decoded by serializers as "PACK".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_8eAnIfNvEeqRfth943bvEA")]
    [Description(@"Instruction has been accepted and is validated for further processing.")]
    Accepted = StatusV2Code.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Attendance is confirmed at the meeting.
    /// Encoded/decoded by serializers as "ATTC".
    /// </summary>
    [EnumMember(Value = "ATTC")]
    [IsoId("_9EsMofNvEeqRfth943bvEA")]
    [Description(@"Attendance is confirmed at the meeting.")]
    AttendanceConfirmed = StatusV2Code.AttendanceConfirmed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as "CAND".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_9qfBUfNvEeqRfth943bvEA")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled = StatusV2Code.Cancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been cancelled by the agent, for example, due to an event deadline extension.
    /// Encoded/decoded by serializers as "CSUB".
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_94UpAfNvEeqRfth943bvEA")]
    [Description(@"Instruction has been cancelled by the agent, for example, due to an event deadline extension.")]
    CancelledBySubcustodian = StatusV2Code.CancelledBySubcustodian, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accepted and sent along the chain.
    /// Encoded/decoded by serializers as "FRWD".
    /// </summary>
    [EnumMember(Value = "FRWD")]
    [IsoId("_-fmEYfNvEeqRfth943bvEA")]
    [Description(@"Accepted and sent along the chain.")]
    Forwarded = StatusV2Code.Forwarded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been received by Issuer, equivalent to the confirmation of receipt of votes cast electronically.
    /// Encoded/decoded by serializers as "RCIS".
    /// </summary>
    [EnumMember(Value = "RCIS")]
    [IsoId("__E8NIfNvEeqRfth943bvEA")]
    [Description(@"Instruction has been received by Issuer, equivalent to the confirmation of receipt of votes cast electronically.")]
    ReceivedByIssuerOrRegistrar = StatusV2Code.ReceivedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights holder has been registered to participate to the meeting.
    /// Encoded/decoded by serializers as "REGM".
    /// </summary>
    [EnumMember(Value = "REGM")]
    [IsoId("__qkpwfNvEeqRfth943bvEA")]
    [Description(@"Rights holder has been registered to participate to the meeting.")]
    RegisteredToParticipateAtMeeting = StatusV2Code.RegisteredToParticipateAtMeeting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Standing instruction is applied.
    /// Encoded/decoded by serializers as "STIN".
    /// </summary>
    [EnumMember(Value = "STIN")]
    [IsoId("_AMfrEfNwEeqRfth943bvEA")]
    [Description(@"Standing instruction is applied.")]
    StandingInstruction = StatusV2Code.StandingInstruction, // same ordinal as derivation source for type conversions
    
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


