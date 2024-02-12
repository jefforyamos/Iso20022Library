﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ICCFallbackReasonCode.  ISO2002 ID# _Hq2KwDHJEeyTT91yHXSlSQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// A code that provides the reason of ICC fallback.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Hq2KwDHJEeyTT91yHXSlSQ")]
[Description(@"A code that provides the reason of ICC fallback.")]
[Derivations(typeof(ICCFallbackReason1Code))]
public enum ICCFallbackReasonCode
{
    /// <summary>
    /// Choosing incorrect IC application.
    /// Encoded/decoded by serializers as "CIIA".
    /// </summary>
    [EnumMember(Value = "CIIA")]
    [IsoId("_UmgI4DHJEeyTT91yHXSlSQ")]
    [Description(@"Choosing incorrect IC application.")]
    ChoosingIncorrectICApplication,
    
    /// <summary>
    /// Error during IC app processing.
    /// Encoded/decoded by serializers as "EDIP".
    /// </summary>
    [EnumMember(Value = "EDIP")]
    [IsoId("_c46rADHJEeyTT91yHXSlSQ")]
    [Description(@"Error during IC app processing.|")]
    ErrorDuringICAppProcessing,
    
    /// <summary>
    /// Terminal error reading IC data.
    /// Encoded/decoded by serializers as "TERI".
    /// </summary>
    [EnumMember(Value = "TERI")]
    [IsoId("_tJRUEDHJEeyTT91yHXSlSQ")]
    [Description(@"Terminal error reading IC data.|")]
    TerminalErrorReadingICData,
    
    /// <summary>
    /// Other ICC fallback reason defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_0dWlsDHJEeyTT91yHXSlSQ")]
    [Description(@"Other ICC fallback reason defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other ICC fallback reason defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_67REUDHJEeyTT91yHXSlSQ")]
    [Description(@"Other ICC fallback reason defined at private level.")]
    OtherPrivate,
    
}
