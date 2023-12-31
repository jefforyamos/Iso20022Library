﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResultDetail3Code.  ISO2002 ID# _Z3kk4I4YEeW6h7rGyYlyTg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Detail of the response.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z3kk4I4YEeW6h7rGyYlyTg")]
[Description(@"Detail of the response.")]
[DerivedFrom(typeof(ResultDetailCode))]
public enum ResultDetail3Code
{
    /// <summary>
    /// The certificate is unknown.
    /// Encoded/decoded by serializers as "UnknownCertificate".
    /// </summary>
    [EnumMember(Value = "CRTU")]
    [IsoId("_dRl0sY4YEeW6h7rGyYlyTg")]
    [Description(@"The certificate is unknown.")]
    UnknownCertificate,
    
    /// <summary>
    /// Requested service not supported.
    /// Encoded/decoded by serializers as "UnsupportedService".
    /// </summary>
    [EnumMember(Value = "SVSU")]
    [IsoId("_eBK3g44YEeW6h7rGyYlyTg")]
    [Description(@"Requested service not supported.")]
    UnsupportedService,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ResultDetail3CodeMetadataExtensions
{
    private static readonly ResultDetail3CodeDropdownSource _dropdownSource = new ResultDetail3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResultDetail3CodeDropdownRow GetMetadata(this ResultDetail3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


