﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StatusResponseCode.  ISO2002 ID# _Llp6Iz2yEeGXQ7zxoAIFpQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the response.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Llp6Iz2yEeGXQ7zxoAIFpQ")]
[Description(@"Specifies the status of the response.")]
[Derivations(typeof(StatusResponse1Code))]
// External derivations that should be provided by the proper interface are: 
public enum StatusResponseCode
{
    /// <summary>
    /// Response not provided yet.
    /// Encoded/decoded by serializers as "NRES".
    /// </summary>
    [EnumMember(Value = "NRES")]
    [IsoId("_Oh2ljT2yEeGXQ7zxoAIFpQ")]
    [Description(@"Response not provided yet.")]
    NoResponseYet,
    
    /// <summary>
    /// Response is partially provided.
    /// Encoded/decoded by serializers as "PART".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_b9g5bT2yEeGXQ7zxoAIFpQ")]
    [Description(@"Response is partially provided.")]
    PartialResponse,
    
    /// <summary>
    /// Response is complete.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_ilBY7T2yEeGXQ7zxoAIFpQ")]
    [Description(@"Response is complete.")]
    CompleteResponse,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StatusResponseCodeMetadataExtensions
{
    private static readonly StatusResponseCodeDropdownSource _dropdownSource = new StatusResponseCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatusResponseCodeDropdownRow GetMetadata(this StatusResponseCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


