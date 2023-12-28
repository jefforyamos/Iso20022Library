﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BatchTransactionTypeCode.  ISO2002 ID# _KUq-iH1DEeCF8NjrBemJWQ_-1037208756.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of transactions to include in a batch transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KUq-iH1DEeCF8NjrBemJWQ_-1037208756")]
[Description(@"Type of transactions to include in a batch transfer.")]
[Derivations(typeof(BatchTransactionType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum BatchTransactionTypeCode
{
    /// <summary>
    /// Debit and credit transactions.
    /// Encoded/decoded by serializers as "DTCT".
    /// </summary>
    [EnumMember(Value = "DTCT")]
    [IsoId("_KU0vgH1DEeCF8NjrBemJWQ_-2001317413")]
    [Description(@"Debit and credit transactions.")]
    DebitCredit,
    
    /// <summary>
    /// Cancellation of a previous transaction.
    /// Encoded/decoded by serializers as "CNCL".
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_KU0vgX1DEeCF8NjrBemJWQ_-1823198741")]
    [Description(@"Cancellation of a previous transaction.")]
    Cancellation,
    
    /// <summary>
    /// Failed transactions.
    /// Encoded/decoded by serializers as "FAIL".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_KU0vgn1DEeCF8NjrBemJWQ_-2115156479")]
    [Description(@"Failed transactions.")]
    Failed,
    
    /// <summary>
    /// Declined transactions.
    /// Encoded/decoded by serializers as "DCLN".
    /// </summary>
    [EnumMember(Value = "DCLN")]
    [IsoId("_KU0vg31DEeCF8NjrBemJWQ_1142799055")]
    [Description(@"Declined transactions.")]
    Declined,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BatchTransactionTypeCodeMetadataExtensions
{
    private static readonly BatchTransactionTypeCodeDropdownSource _dropdownSource = new BatchTransactionTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBatchTransactionTypeCodeDropdownRow GetMetadata(this BatchTransactionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


