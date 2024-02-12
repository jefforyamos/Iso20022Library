﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StatusResponse1Code.  ISO2002 ID# _saUqED2yEeGXQ7zxoAIFpQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the response.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_saUqED2yEeGXQ7zxoAIFpQ")]
[Description(@"Specifies the status of the response.")]
[DerivedFrom(typeof(StatusResponseCode))]
public enum StatusResponse1Code
{
    /// <summary>
    /// Response not provided yet.
    /// Encoded/decoded by serializers as "NRES".
    /// </summary>
    [EnumMember(Value = "NRES")]
    [IsoId("_tNlTBj2yEeGXQ7zxoAIFpQ")]
    [Description(@"Response not provided yet.")]
    NoResponseYet = StatusResponseCode.NoResponseYet, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response is partially provided.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_tTP2Jj2yEeGXQ7zxoAIFpQ")]
    [Description(@"Response is partially provided.")]
    PartialResponse = StatusResponseCode.PartialResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response is complete.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_tZXFNj2yEeGXQ7zxoAIFpQ")]
    [Description(@"Response is complete.")]
    CompleteResponse = StatusResponseCode.CompleteResponse, // same ordinal as derivation source for type conversions
    
}
