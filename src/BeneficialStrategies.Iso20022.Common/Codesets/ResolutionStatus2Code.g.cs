﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResolutionStatus2Code.  ISO2002 ID# _D8wF4F64EeSjaerr_EM7AQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a resolution in a meeting agenda.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_D8wF4F64EeSjaerr_EM7AQ")]
[Description(@"Specifies the status of a resolution in a meeting agenda.")]
[DerivedFrom(typeof(ResolutionStatusCode))]
public enum ResolutionStatus2Code
{
    /// <summary>
    /// Meeting resolution has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_S5RIgV64EeSjaerr_EM7AQ")]
    [Description(@"Meeting resolution has been accepted.")]
    Accepted = ResolutionStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Meeting resolution has been rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_TCMbAV64EeSjaerr_EM7AQ")]
    [Description(@"Meeting resolution has been rejected.")]
    Rejected = ResolutionStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Meeting resolution has been withdrawn.
    /// Encoded/decoded by serializers as &quot;WDRA&quot;.
    /// </summary>
    [EnumMember(Value = "WDRA")]
    [IsoId("_TK-jkV64EeSjaerr_EM7AQ")]
    [Description(@"Meeting resolution has been withdrawn.")]
    Withdrawn = ResolutionStatusCode.Withdrawn, // same ordinal as derivation source for type conversions
    
}
