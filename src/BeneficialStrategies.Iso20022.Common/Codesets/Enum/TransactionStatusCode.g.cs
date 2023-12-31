﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionStatusCode.  ISO2002 ID# _YuO5ddp-Ed-ak6NoX_4Aeg_-163376568.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the processing status of an investment fund transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YuO5ddp-Ed-ak6NoX_4Aeg_-163376568")]
[Description(@"Specifies the processing status of an investment fund transaction.")]
[Derivations(typeof(TransactionStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum TransactionStatusCode
{
    /// <summary>
    /// Transaction has been reversed.
    /// Encoded/decoded by serializers as "RVSL".
    /// </summary>
    [EnumMember(Value = "RVSL")]
    [IsoId("_YuO5dtp-Ed-ak6NoX_4Aeg_-163376564")]
    [Description(@"Transaction has been reversed.")]
    Reversal,
    
    /// <summary>
    /// Transaction has been rebooked.
    /// Encoded/decoded by serializers as "REBO".
    /// </summary>
    [EnumMember(Value = "REBO")]
    [IsoId("_YuO5d9p-Ed-ak6NoX_4Aeg_-163376563")]
    [Description(@"Transaction has been rebooked.")]
    Rebooked,
    
    /// <summary>
    /// Transaction has been cancelled.
    /// Encoded/decoded by serializers as "CANC".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_YuYqcNp-Ed-ak6NoX_4Aeg_-163376562")]
    [Description(@"Transaction has been cancelled.")]
    Cancelled,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionStatusCodeMetadataExtensions
{
    private static readonly TransactionStatusCodeDropdownSource _dropdownSource = new TransactionStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionStatusCodeDropdownRow GetMetadata(this TransactionStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


