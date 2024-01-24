﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ICCFallbackReason1Code.  ISO2002 ID# _CIijUDHKEeyTT91yHXSlSQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// A code that provides the reason of ICC fallback.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CIijUDHKEeyTT91yHXSlSQ")]
[Description(@"A code that provides the reason of ICC fallback.")]
[DerivedFrom(typeof(ICCFallbackReasonCode))]
public enum ICCFallbackReason1Code
{
    /// <summary>
    /// Choosing incorrect IC application.
    /// Encoded/decoded by serializers as "CIIA".
    /// </summary>
    [EnumMember(Value = "CIIA")]
    [IsoId("_P4yAATxSEeyuG4d2lhAp-w")]
    [Description(@"Choosing incorrect IC application.")]
    ChoosingIncorrectICApplication = ICCFallbackReasonCode.ChoosingIncorrectICApplication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Error during IC app processing.
    /// Encoded/decoded by serializers as "EDIP".
    /// </summary>
    [EnumMember(Value = "EDIP")]
    [IsoId("_P96-sTxSEeyuG4d2lhAp-w")]
    [Description(@"Error during IC app processing.|")]
    ErrorDuringICAppProcessing = ICCFallbackReasonCode.ErrorDuringICAppProcessing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other ICC fallback reason defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_QCJXYTxSEeyuG4d2lhAp-w")]
    [Description(@"Other ICC fallback reason defined at national level.")]
    OtherNational = ICCFallbackReasonCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other ICC fallback reason defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_QJDQoTxSEeyuG4d2lhAp-w")]
    [Description(@"Other ICC fallback reason defined at private level.")]
    OtherPrivate = ICCFallbackReasonCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Terminal error reading IC data.
    /// Encoded/decoded by serializers as "TERI".
    /// </summary>
    [EnumMember(Value = "TERI")]
    [IsoId("_QPGOQTxSEeyuG4d2lhAp-w")]
    [Description(@"Terminal error reading IC data.|")]
    TerminalErrorReadingICData = ICCFallbackReasonCode.TerminalErrorReadingICData, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ICCFallbackReason1CodeMetadataExtensions
{
    private static readonly ICCFallbackReason1CodeDropdownSource _dropdownSource = new ICCFallbackReason1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IICCFallbackReason1CodeDropdownRow GetMetadata(this ICCFallbackReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


