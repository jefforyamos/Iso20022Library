﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeTransactionTotals3Code.  ISO2002 ID# _4IQQ0NxhEeioifFt1dhnJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Additional attribute of the service type for totals.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4IQQ0NxhEeioifFt1dhnJA")]
[Description(@"Additional attribute of the service type for totals.")]
[DerivedFrom(typeof(TypeTransactionTotalsCode))]
public enum TypeTransactionTotals3Code
{
    /// <summary>
    /// Credit transactions (refund, account, cash service, as defined in the transaction service type).
    /// Encoded/decoded by serializers as "Credit".
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_56GB4dxhEeioifFt1dhnJA")]
    [Description(@"Credit transactions (refund, account, cash service, as defined in the transaction service type).")]
    Credit,
    
    /// <summary>
    /// Reversal of credit transactions (cancellation).
    /// Encoded/decoded by serializers as "CreditReverse".
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_59X_YdxhEeioifFt1dhnJA")]
    [Description(@"Reversal of credit transactions (cancellation).")]
    CreditReverse,
    
    /// <summary>
    /// Debit transactions on the cardholder account.
    /// Encoded/decoded by serializers as "Debit".
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_6ApV0dxhEeioifFt1dhnJA")]
    [Description(@"Debit transactions on the cardholder account.")]
    Debit,
    
    /// <summary>
    /// Reversal of debit transactions (cancellation).
    /// Encoded/decoded by serializers as "DebitReverse".
    /// </summary>
    [EnumMember(Value = "DBTR")]
    [IsoId("_6EFEUdxhEeioifFt1dhnJA")]
    [Description(@"Reversal of debit transactions (cancellation).")]
    DebitReverse,
    
    /// <summary>
    /// Declined transactions.
    /// Encoded/decoded by serializers as "Declined".
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_6HIYUdxhEeioifFt1dhnJA")]
    [Description(@"Declined transactions.")]
    Declined,
    
    /// <summary>
    /// Failed transactions.
    /// Encoded/decoded by serializers as "Failed".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_6KQk0dxhEeioifFt1dhnJA")]
    [Description(@"Failed transactions.")]
    Failed,
    
    /// <summary>
    /// Outstanding Reservation transactions.
    /// Encoded/decoded by serializers as "Reservation".
    /// </summary>
    [EnumMember(Value = "RESV")]
    [IsoId("_6NjwcdxhEeioifFt1dhnJA")]
    [Description(@"Outstanding Reservation transactions.")]
    Reservation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeTransactionTotals3CodeMetadataExtensions
{
    private static readonly TypeTransactionTotals3CodeDropdownSource _dropdownSource = new TypeTransactionTotals3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeTransactionTotals3CodeDropdownRow GetMetadata(this TypeTransactionTotals3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


