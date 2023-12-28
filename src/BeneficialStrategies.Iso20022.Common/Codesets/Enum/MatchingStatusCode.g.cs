﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MatchingStatusCode.  ISO2002 ID# _aVDGRtp-Ed-ak6NoX_4Aeg_162716149.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the matching status of the instruction at the time the settlement instruction was sent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aVDGRtp-Ed-ak6NoX_4Aeg_162716149")]
[Description(@"Provides the matching status of the instruction at the time the settlement instruction was sent.")]
public enum MatchingStatusCode
{
    /// <summary>
    /// Instruction has been matched.
    /// Encoded/decoded by serializers as "MACH".
    /// </summary>
    [EnumMember(Value = "MACH")]
    [IsoId("_aVDGR9p-Ed-ak6NoX_4Aeg_162716174")]
    [Description(@"Instruction has been matched.")]
    Matched,
    
    /// <summary>
    /// Instruction has not been matched.
    /// Encoded/decoded by serializers as "NMAT".
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_aVDGSNp-Ed-ak6NoX_4Aeg_162716175")]
    [Description(@"Instruction has not been matched.")]
    Unmatched,
    
    /// <summary>
    /// Instruction has been alleged matched.
    /// Encoded/decoded by serializers as "ALGE".
    /// </summary>
    [EnumMember(Value = "ALGE")]
    [IsoId("_LpX2YdUbEeOpzo6bWCQeYA")]
    [Description(@"Instruction has been alleged matched.")]
    MatchingAlleged,
    
    /// <summary>
    /// Instruction has been mis-matched.
    /// Encoded/decoded by serializers as "MMAT".
    /// </summary>
    [EnumMember(Value = "MMAT")]
    [IsoId("_OSFlEdUbEeOpzo6bWCQeYA")]
    [Description(@"Instruction has been mis-matched.")]
    MisMatched,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MatchingStatusCodeMetadataExtensions
{
    private static readonly MatchingStatusCodeDropdownSource _dropdownSource = new MatchingStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMatchingStatusCodeDropdownRow GetMetadata(this MatchingStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


