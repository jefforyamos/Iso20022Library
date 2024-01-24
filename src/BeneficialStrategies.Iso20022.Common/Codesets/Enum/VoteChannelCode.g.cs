﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for VoteChannelCode.  ISO2002 ID# _9SiF8DT8Ee2tRf29bleifQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the network channel through which the vote should be sent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9SiF8DT8Ee2tRf29bleifQ")]
[Description(@"Specifies the network channel through which the vote should be sent.")]
[Derivations(typeof(VoteChannel1Code))]
public enum VoteChannelCode
{
    /// <summary>
    /// Vote is via the chain of intermediaries.
    /// Encoded/decoded by serializers as "VOCI".
    /// </summary>
    [EnumMember(Value = "VOCI")]
    [IsoId("_KyqDEDT9Ee2tRf29bleifQ")]
    [Description(@"Vote is via the chain of intermediaries.")]
    VoteThroughChain,
    
    /// <summary>
    /// Vote is as per described in the processing text for next intermediary information field.
    /// Encoded/decoded by serializers as "VOPI".
    /// </summary>
    [EnumMember(Value = "VOPI")]
    [IsoId("_TzLoYDT9Ee2tRf29bleifQ")]
    [Description(@"Vote is as per described in the processing text for next intermediary information field.")]
    VoteAsPerIntermediaryInformation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class VoteChannelCodeMetadataExtensions
{
    private static readonly VoteChannelCodeDropdownSource _dropdownSource = new VoteChannelCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IVoteChannelCodeDropdownRow GetMetadata(this VoteChannelCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


