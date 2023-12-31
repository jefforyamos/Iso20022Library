﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionEnvironmentCode.  ISO2002 ID# _TVWQCwEcEeCQm6a_G2yO_w_1815843099.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the environment of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVWQCwEcEeCQm6a_G2yO_w_1815843099")]
[Description(@"Indicates the environment of the transaction.")]
[Derivations(typeof(TransactionEnvironment1Code),typeof(TransactionEnvironment3Code),typeof(TransactionEnvironment2Code))]
// External derivations that should be provided by the proper interface are: 
public enum TransactionEnvironmentCode
{
    /// <summary>
    /// Merchant environment.
    /// Encoded/decoded by serializers as "MERC".
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_TVWQDAEcEeCQm6a_G2yO_w_-194113759")]
    [Description(@"Merchant environment.")]
    Merchant,
    
    /// <summary>
    /// Private environment.
    /// Encoded/decoded by serializers as "PRIV".
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_TVWQDQEcEeCQm6a_G2yO_w_1617784466")]
    [Description(@"Private environment.")]
    Private,
    
    /// <summary>
    /// Public environment.
    /// Encoded/decoded by serializers as "PUBL".
    /// </summary>
    [EnumMember(Value = "PUBL")]
    [IsoId("_TVWQDgEcEeCQm6a_G2yO_w_-226084523")]
    [Description(@"Public environment.")]
    Public,
    
    /// <summary>
    /// Bank environment.
    /// Encoded/decoded by serializers as "BRCH".
    /// </summary>
    [EnumMember(Value = "BRCH")]
    [IsoId("_qPp6oHsIEeSR68OJvMfxJQ")]
    [Description(@"Bank environment.")]
    Branch,
    
    /// <summary>
    /// Other environments, for instance a mall or an airport.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ttxAQHsIEeSR68OJvMfxJQ")]
    [Description(@"Other environments, for instance a mall or an airport.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionEnvironmentCodeMetadataExtensions
{
    private static readonly TransactionEnvironmentCodeDropdownSource _dropdownSource = new TransactionEnvironmentCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionEnvironmentCodeDropdownRow GetMetadata(this TransactionEnvironmentCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


