﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for VotingParticipationMethodV2Code.  ISO2002 ID# _JD_2QBrkEeyhRdHRjakS2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JD_2QBrkEeyhRdHRjakS2w")]
[Description(@"Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.")]
public enum VotingParticipationMethodV2Code
{
    /// <summary>
    /// Vote participation is via documents sent through physical post / mail.
    /// Encoded/decoded by serializers as "MAIL".
    /// </summary>
    [EnumMember(Value = "MAIL")]
    [IsoId("_VmIhJhrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is via documents sent through physical post / mail.")]
    Correspondence,
    
    /// <summary>
    /// Vote participation is through electronic means like dedicated standards messaging or web based voting applications.
    /// Encoded/decoded by serializers as "EVOT".
    /// </summary>
    [EnumMember(Value = "EVOT")]
    [IsoId("_VmIhJxrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is through electronic means like dedicated standards messaging or web based voting applications.")]
    ElectronicVoting,
    
    /// <summary>
    /// Vote participation is through physical attendance.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_VmIhKBrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is through physical attendance.")]
    InPerson,
    
    /// <summary>
    /// Participation to the meeting is in person but the person is not voting.
    /// Encoded/decoded by serializers as "PHNV".
    /// </summary>
    [EnumMember(Value = "PHNV")]
    [IsoId("_VmIhKRrkEeyhRdHRjakS2w")]
    [Description(@"Participation to the meeting is in person but the person is not voting.")]
    NotVoting,
    
    /// <summary>
    /// Vote participation is through a proxy person.
    /// Encoded/decoded by serializers as "PRXY".
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_VmIhKhrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is through a proxy person.")]
    Proxy,
    
    /// <summary>
    /// Vote participation is through virtual meeting attendance method like multimedia and web based video or audio conferencing. 
    /// Encoded/decoded by serializers as "VIRT".
    /// </summary>
    [EnumMember(Value = "VIRT")]
    [IsoId("_VmIhKxrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is through virtual meeting attendance method like multimedia and web based video or audio conferencing. ")]
    Virtual,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class VotingParticipationMethodV2CodeMetadataExtensions
{
    private static readonly VotingParticipationMethodV2CodeDropdownSource _dropdownSource = new VotingParticipationMethodV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IVotingParticipationMethodV2CodeDropdownRow GetMetadata(this VotingParticipationMethodV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


