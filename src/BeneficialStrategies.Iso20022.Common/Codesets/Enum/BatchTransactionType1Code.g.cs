﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BatchTransactionType1Code.  ISO2002 ID# _KUq-g31DEeCF8NjrBemJWQ_-2092931546.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Encoded/decoded by serializers as "DTCT".
    /// </summary>
    [EnumMember(Value = "DTCT")]
    [IsoId("_KUq-hH1DEeCF8NjrBemJWQ_-819708143")]
    [Description(@"Debit and credit transactions.")]
    DebitCredit = BatchTransactionTypeCode.DebitCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation of a previous transaction.
    /// Encoded/decoded by serializers as "CNCL".
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_KUq-hX1DEeCF8NjrBemJWQ_-538462037")]
    [Description(@"Cancellation of a previous transaction.")]
    Cancellation = BatchTransactionTypeCode.Cancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Failed transactions.
    /// Encoded/decoded by serializers as "FAIL".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_KUq-hn1DEeCF8NjrBemJWQ_-111331682")]
    [Description(@"Failed transactions.")]
    Failed = BatchTransactionTypeCode.Failed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Declined transactions.
    /// Encoded/decoded by serializers as "DCLN".
    /// </summary>
    [EnumMember(Value = "DCLN")]
    [IsoId("_KUq-h31DEeCF8NjrBemJWQ_1581782246")]
    [Description(@"Declined transactions.")]
    Declined = BatchTransactionTypeCode.Declined, // same ordinal as derivation source for type conversions
    
}
