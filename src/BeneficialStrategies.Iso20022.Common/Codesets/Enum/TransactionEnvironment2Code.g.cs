﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionEnvironment2Code.  ISO2002 ID# _cb7FAHsIEeSR68OJvMfxJQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the environment of the transaction location.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cb7FAHsIEeSR68OJvMfxJQ")]
[Description(@"Indicates the environment of the transaction location.")]
[DerivedFrom(typeof(TransactionEnvironmentCode))]
public enum TransactionEnvironment2Code
{
    /// <summary>
    /// Private environment.
    /// Encoded/decoded by serializers as "Private".
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_d7rAgXsIEeSR68OJvMfxJQ")]
    [Description(@"Private environment.")]
    Private,
    
    /// <summary>
    /// Public environment.
    /// Encoded/decoded by serializers as "Public".
    /// </summary>
    [EnumMember(Value = "PUBL")]
    [IsoId("_eDeRoXsIEeSR68OJvMfxJQ")]
    [Description(@"Public environment.")]
    Public,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionEnvironment2CodeMetadataExtensions
{
    private static readonly TransactionEnvironment2CodeDropdownSource _dropdownSource = new TransactionEnvironment2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionEnvironment2CodeDropdownRow GetMetadata(this TransactionEnvironment2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


