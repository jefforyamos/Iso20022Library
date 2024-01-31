﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for VotingParticipationMethod2Code.  ISO2002 ID# _Blwy0PNqEeqRfth943bvEA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Blwy0PNqEeqRfth943bvEA")]
[Description(@"Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.")]
[DerivedFrom(typeof(VotingParticipationMethodCode))]
public enum VotingParticipationMethod2Code
{
    /// <summary>
    /// Participation to the meeting is in person but the person is not voting.
    /// Encoded/decoded by serializers as "PHNV".
    /// </summary>
    [EnumMember(Value = "PHNV")]
    [IsoId("_F2nkAfNqEeqRfth943bvEA")]
    [Description(@"Participation to the meeting is in person but the person is not voting.")]
    NotVoting = VotingParticipationMethodCode.NotVoting, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class VotingParticipationMethod2CodeMetadataExtensions
{
    private static readonly VotingParticipationMethod2CodeDropdownSource _dropdownSource = new VotingParticipationMethod2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IVotingParticipationMethod2CodeDropdownRow GetMetadata(this VotingParticipationMethod2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


