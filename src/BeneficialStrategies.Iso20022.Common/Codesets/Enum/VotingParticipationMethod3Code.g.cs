﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for VotingParticipationMethod3Code.  ISO2002 ID# _eR8asBrkEeyhRdHRjakS2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eR8asBrkEeyhRdHRjakS2w")]
[Description(@"Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.")]
[DerivedFrom(typeof(VotingParticipationMethodV2Code))]
public enum VotingParticipationMethod3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Correspondence".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_lwIDgRrkEeyhRdHRjakS2w")]
    [Description(@"??")]
    Correspondence,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ElectronicVoting".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_l1o1oRrkEeyhRdHRjakS2w")]
    [Description(@"??")]
    ElectronicVoting,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InPerson".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_l6s70RrkEeyhRdHRjakS2w")]
    [Description(@"??")]
    InPerson,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotVoting".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_l_xpERrkEeyhRdHRjakS2w")]
    [Description(@"??")]
    NotVoting,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Proxy".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_mFIqMRrkEeyhRdHRjakS2w")]
    [Description(@"??")]
    Proxy,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Virtual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_mKgSYRrkEeyhRdHRjakS2w")]
    [Description(@"??")]
    Virtual,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class VotingParticipationMethod3CodeMetadataExtensions
{
    private static readonly VotingParticipationMethod3CodeDropdownSource _dropdownSource = new VotingParticipationMethod3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IVotingParticipationMethod3CodeDropdownRow GetMetadata(this VotingParticipationMethod3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

