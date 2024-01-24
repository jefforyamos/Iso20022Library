﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeTransactionTotals1Code.  ISO2002 ID# _TUJ9PwEcEeCQm6a_G2yO_w_592182673.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of the type of transactions which are included in the totals.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUJ9PwEcEeCQm6a_G2yO_w_592182673")]
[Description(@"Identification of the type of transactions which are included in the totals.")]
[DerivedFrom(typeof(TypeTransactionTotalsCode))]
public enum TypeTransactionTotals1Code
{
    /// <summary>
    /// Debit transactions on the cardholder account.
    /// Encoded/decoded by serializers as "DEBT".
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_TUJ9QAEcEeCQm6a_G2yO_w_-1120595523")]
    [Description(@"Debit transactions on the cardholder account.")]
    Debit = TypeTransactionTotalsCode.Debit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal of debit transactions (cancellation).
    /// Encoded/decoded by serializers as "DBTR".
    /// </summary>
    [EnumMember(Value = "DBTR")]
    [IsoId("_TUTHIAEcEeCQm6a_G2yO_w_-2003828810")]
    [Description(@"Reversal of debit transactions (cancellation).")]
    DebitReverse = TypeTransactionTotalsCode.DebitReverse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit transactions (refund, account, cash service, as defined in the transaction service type).
    /// Encoded/decoded by serializers as "CRDT".
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_TUTHIQEcEeCQm6a_G2yO_w_1152384112")]
    [Description(@"Credit transactions (refund, account, cash service, as defined in the transaction service type).")]
    Credit = TypeTransactionTotalsCode.Credit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal of credit transactions (cancellation).
    /// Encoded/decoded by serializers as "CRDR".
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_TUTHIgEcEeCQm6a_G2yO_w_-1205358011")]
    [Description(@"Reversal of credit transactions (cancellation).")]
    CreditReverse = TypeTransactionTotalsCode.CreditReverse, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeTransactionTotals1CodeMetadataExtensions
{
    private static readonly TypeTransactionTotals1CodeDropdownSource _dropdownSource = new TypeTransactionTotals1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeTransactionTotals1CodeDropdownRow GetMetadata(this TypeTransactionTotals1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


