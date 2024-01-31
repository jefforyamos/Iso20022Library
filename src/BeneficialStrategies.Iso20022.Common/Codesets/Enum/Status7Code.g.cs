﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Status7Code.  ISO2002 ID# _WMNrgF6uEeSyc4g_pm5hbw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Instruction has been cancelled by the agent, for example, due to an event deadline extension.
    /// Encoded/decoded by serializers as "CSUB".
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_YyZqoF6uEeSyc4g_pm5hbw")]
    [Description(@"Instruction has been cancelled by the agent, for example, due to an event deadline extension.")]
    CancelledBySubcustodian = StatusCode.CancelledBySubcustodian, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been accepted and is validated for further processing.
    /// Encoded/decoded by serializers as "PACK".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_aCL3gV6uEeSyc4g_pm5hbw")]
    [Description(@"Instruction has been accepted and is validated for further processing.")]
    Accepted = StatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as "CAND".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_agtmkV6uEeSyc4g_pm5hbw")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled = StatusCode.Cancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Processing has been completed.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_a88PkV6uEeSyc4g_pm5hbw")]
    [Description(@"Processing has been completed.")]
    Completed = StatusCode.Completed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No instruction has been received (to be used in a reminder).
    /// Encoded/decoded by serializers as "NOIN".
    /// </summary>
    [EnumMember(Value = "NOIN")]
    [IsoId("_b10_YV6uEeSyc4g_pm5hbw")]
    [Description(@"No instruction has been received (to be used in a reminder).")]
    NotReceived = StatusCode.NotReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been received by Issuer.
    /// Encoded/decoded by serializers as "RCIS".
    /// </summary>
    [EnumMember(Value = "RCIS")]
    [IsoId("_c1-00V6uEeSyc4g_pm5hbw")]
    [Description(@"Instruction has been received by Issuer.")]
    ReceivedByIssuerOrRegistrar = StatusCode.ReceivedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Standing instruction is applied.
    /// Encoded/decoded by serializers as "STIN".
    /// </summary>
    [EnumMember(Value = "STIN")]
    [IsoId("_dTZJkV6uEeSyc4g_pm5hbw")]
    [Description(@"Standing instruction is applied.")]
    StandingInstruction = StatusCode.StandingInstruction, // same ordinal as derivation source for type conversions
    
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


