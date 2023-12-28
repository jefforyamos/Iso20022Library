﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeTransactionTotalsCode.  ISO2002 ID# _TVfZ-gEcEeCQm6a_G2yO_w_-334806911.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of the type of transactions which are included in the totals.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVfZ-gEcEeCQm6a_G2yO_w_-334806911")]
[Description(@"Identification of the type of transactions which are included in the totals.")]
public enum TypeTransactionTotalsCode
{
    /// <summary>
    /// Debit transactions on the cardholder account.
    /// Encoded/decoded by serializers as "DEBT".
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_TVfZ-wEcEeCQm6a_G2yO_w_847668388")]
    [Description(@"Debit transactions on the cardholder account.")]
    Debit,
    
    /// <summary>
    /// Reversal of debit transactions (cancellation).
    /// Encoded/decoded by serializers as "DBTR".
    /// </summary>
    [EnumMember(Value = "DBTR")]
    [IsoId("_TVfZ_AEcEeCQm6a_G2yO_w_-1805770177")]
    [Description(@"Reversal of debit transactions (cancellation).")]
    DebitReverse,
    
    /// <summary>
    /// Credit transactions (refund, account, cash service, as defined in the transaction service type).
    /// Encoded/decoded by serializers as "CRDT".
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_TVfZ_QEcEeCQm6a_G2yO_w_490339038")]
    [Description(@"Credit transactions (refund, account, cash service, as defined in the transaction service type).")]
    Credit,
    
    /// <summary>
    /// Reversal of credit transactions (cancellation).
    /// Encoded/decoded by serializers as "CRDR".
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_TVfZ_gEcEeCQm6a_G2yO_w_1638442145")]
    [Description(@"Reversal of credit transactions (cancellation).")]
    CreditReverse,
    
    /// <summary>
    /// Declined transactions.
    /// Encoded/decoded by serializers as "DECL".
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_sP2PAb4pEeKkGaJ0UrThyA_1695729139")]
    [Description(@"Declined transactions.")]
    Declined,
    
    /// <summary>
    /// Failed transactions.
    /// Encoded/decoded by serializers as "FAIL".
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_sP2PAr4pEeKkGaJ0UrThyA_1843086273")]
    [Description(@"Failed transactions.")]
    Failed,
    
    /// <summary>
    /// Outstanding Reservation transactions.
    /// Encoded/decoded by serializers as "RESV".
    /// </summary>
    [EnumMember(Value = "RESV")]
    [IsoId("__Fr_kGpUEemFuJNacM8hZA")]
    [Description(@"Outstanding Reservation transactions.")]
    Reservation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeTransactionTotalsCodeMetadataExtensions
{
    private static readonly TypeTransactionTotalsCodeDropdownSource _dropdownSource = new TypeTransactionTotalsCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeTransactionTotalsCodeDropdownRow GetMetadata(this TypeTransactionTotalsCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

