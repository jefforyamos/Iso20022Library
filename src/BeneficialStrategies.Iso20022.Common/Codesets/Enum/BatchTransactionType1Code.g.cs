﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BatchTransactionType1Code.  ISO2002 ID# _KUq-g31DEeCF8NjrBemJWQ_-2092931546.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of transactions to include in a batch transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KUq-g31DEeCF8NjrBemJWQ_-2092931546")]
[Description(@"Type of transactions to include in a batch transfer.")]
[DerivedFrom(typeof(BatchTransactionTypeCode))]
public enum BatchTransactionType1Code
{
    /// <summary>
    /// Debit and credit transactions.
    /// Encoded/decoded by serializers as "DebitCredit".
    /// </summary>
    [EnumMember(Value = "DTCT")]
    [IsoId("_KUq-hH1DEeCF8NjrBemJWQ_-819708143")]
    [Description(@"Debit and credit transactions.")]
    DebitCredit,
    
    /// <summary>
    /// Cancellation of a previous transaction.
    /// Encoded/decoded by serializers as "Cancellation".
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_KUq-hX1DEeCF8NjrBemJWQ_-538462037")]
    [Description(@"Cancellation of a previous transaction.")]
    Cancellation,
    
    /// <summary>
    /// Failed transactions.
    /// Encoded/decoded by serializers as "Failed".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_KUq-hn1DEeCF8NjrBemJWQ_-111331682")]
    [Description(@"Failed transactions.")]
    Failed,
    
    /// <summary>
    /// Declined transactions.
    /// Encoded/decoded by serializers as "Declined".
    /// </summary>
    [EnumMember(Value = "DCLN")]
    [IsoId("_KUq-h31DEeCF8NjrBemJWQ_1581782246")]
    [Description(@"Declined transactions.")]
    Declined,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BatchTransactionType1CodeMetadataExtensions
{
    private static readonly BatchTransactionType1CodeDropdownSource _dropdownSource = new BatchTransactionType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBatchTransactionType1CodeDropdownRow GetMetadata(this BatchTransactionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


