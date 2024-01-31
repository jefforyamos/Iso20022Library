﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundPaymentTypeCode.  ISO2002 ID# _WR9p4F8wEeicg40_9gK9vQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of payment instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WR9p4F8wEeicg40_9gK9vQ")]
[Description(@"Specifies a type of payment instrument.")]
[Derivations(typeof(FundPaymentType1Code))]
public enum FundPaymentTypeCode
{
    /// <summary>
    /// Payment instrument is a payment card.
    /// Encoded/decoded by serializers as "CARD".
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_Pw2Q0F8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a payment card.")]
    PaymentCard,
    
    /// <summary>
    /// Payment instrument is a credit transfer.
    /// Encoded/decoded by serializers as "CRDT".
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_TdQRIF8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a credit transfer.")]
    CreditTransfer,
    
    /// <summary>
    /// Payment instrument is a direct debit.
    /// Encoded/decoded by serializers as "DDEB".
    /// </summary>
    [EnumMember(Value = "DDEB")]
    [IsoId("_dac6EF8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a direct debit.")]
    DirectDebit,
    
    /// <summary>
    /// Payment instrument is a cheque.
    /// Encoded/decoded by serializers as "CHEQ".
    /// </summary>
    [EnumMember(Value = "CHEQ")]
    [IsoId("_iJzlIF8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a cheque.")]
    Cheque,
    
    /// <summary>
    /// Payment instrument is a bankers draft.
    /// Encoded/decoded by serializers as "DRAF".
    /// </summary>
    [EnumMember(Value = "DRAF")]
    [IsoId("_mZUSgF8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a bankers draft.")]
    BankersDraft,
    
    /// <summary>
    /// Payment instrument is a cash account.
    /// Encoded/decoded by serializers as "CACC".
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_qPsHIF8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a cash account.")]
    CashAccount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundPaymentTypeCodeMetadataExtensions
{
    private static readonly FundPaymentTypeCodeDropdownSource _dropdownSource = new FundPaymentTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundPaymentTypeCodeDropdownRow GetMetadata(this FundPaymentTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


