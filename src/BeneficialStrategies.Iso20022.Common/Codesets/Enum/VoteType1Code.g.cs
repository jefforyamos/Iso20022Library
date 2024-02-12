﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for VoteType1Code.  ISO2002 ID# _yDgk8K37EemG7MmivSuE5g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the impact of a vote on an agenda resolution in general meetings.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yDgk8K37EemG7MmivSuE5g")]
[Description(@"Specifies the impact of a vote on an agenda resolution in general meetings.")]
[DerivedFrom(typeof(VoteTypeCode))]
public enum VoteType1Code
{
    /// <summary>
    /// Results of a vote on a proposal is for advice only.
    /// Encoded/decoded by serializers as "ADVI".
    /// </summary>
    [EnumMember(Value = "ADVI")]
    [IsoId("_5URc0a37EemG7MmivSuE5g")]
    [Description(@"Results of a vote on a proposal is for advice only.")]
    Advisory = VoteTypeCode.Advisory, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Results of a vote on a proposal is binding.
    /// Encoded/decoded by serializers as "BNDG".
    /// </summary>
    [EnumMember(Value = "BNDG")]
    [IsoId("_5fbj8q37EemG7MmivSuE5g")]
    [Description(@"Results of a vote on a proposal is binding.")]
    Binding = VoteTypeCode.Binding, // same ordinal as derivation source for type conversions
    
}
