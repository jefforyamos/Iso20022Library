﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionStatus1Code.  ISO2002 ID# _zdcnZQ93EeGeV5vP7Mvdig_-110011060.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the processing status of an investment fund transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zdcnZQ93EeGeV5vP7Mvdig_-110011060")]
[Description(@"Specifies the processing status of an investment fund transaction.")]
[DerivedFrom(typeof(TransactionStatusCode))]
public enum TransactionStatus1Code
{
    /// <summary>
    /// Transaction has been reversed.
    /// Encoded/decoded by serializers as "Reversal".
    /// </summary>
    [EnumMember(Value = "RVSL")]
    [IsoId("_zdmYYA93EeGeV5vP7Mvdig_-1941849246")]
    [Description(@"Transaction has been reversed.")]
    Reversal,
    
    /// <summary>
    /// Transaction has been rebooked.
    /// Encoded/decoded by serializers as "Rebooked".
    /// </summary>
    [EnumMember(Value = "REBO")]
    [IsoId("_zdmYYQ93EeGeV5vP7Mvdig_-595137067")]
    [Description(@"Transaction has been rebooked.")]
    Rebooked,
    
    /// <summary>
    /// Transaction has been cancelled.
    /// Encoded/decoded by serializers as "Cancelled".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_zdmYYg93EeGeV5vP7Mvdig_880282350")]
    [Description(@"Transaction has been cancelled.")]
    Cancelled,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionStatus1CodeMetadataExtensions
{
    private static readonly TransactionStatus1CodeDropdownSource _dropdownSource = new TransactionStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionStatus1CodeDropdownRow GetMetadata(this TransactionStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


