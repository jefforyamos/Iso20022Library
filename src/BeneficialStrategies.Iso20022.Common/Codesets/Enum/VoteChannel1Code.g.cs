﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for VoteChannel1Code.  ISO2002 ID# _dQw9IDT9Ee2tRf29bleifQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the network channel through which the vote should be sent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dQw9IDT9Ee2tRf29bleifQ")]
[Description(@"Specifies the network channel through which the vote should be sent.")]
[DerivedFrom(typeof(VoteChannelCode))]
public enum VoteChannel1Code
{
    /// <summary>
    /// Vote is as per described in the processing text for next intermediary information field.
    /// Encoded/decoded by serializers as "VOPI".
    /// </summary>
    [EnumMember(Value = "VOPI")]
    [IsoId("_k3lkkTT9Ee2tRf29bleifQ")]
    [Description(@"Vote is as per described in the processing text for next intermediary information field.")]
    VoteAsPerIntermediaryInformation = VoteChannelCode.VoteAsPerIntermediaryInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote is via the chain of intermediaries.
    /// Encoded/decoded by serializers as "VOCI".
    /// </summary>
    [EnumMember(Value = "VOCI")]
    [IsoId("_k-cagTT9Ee2tRf29bleifQ")]
    [Description(@"Vote is via the chain of intermediaries.")]
    VoteThroughChain = VoteChannelCode.VoteThroughChain, // same ordinal as derivation source for type conversions
    
}
