﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Algorithm4Code.  ISO2002 ID# _wCmXsAiqEeKn9O5oyej_zw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Cryptographic algorithms for digital signatures.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wCmXsAiqEeKn9O5oyej_zw")]
[Description(@"Cryptographic algorithms for digital signatures.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA256WithRSA".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3MPT4QiqEeKn9O5oyej_zw")]
    [Description(@"??")]
    SHA256WithRSA,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Algorithm4CodeMetadataExtensions
{
    private static readonly Algorithm4CodeDropdownSource _dropdownSource = new Algorithm4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAlgorithm4CodeDropdownRow GetMetadata(this Algorithm4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


