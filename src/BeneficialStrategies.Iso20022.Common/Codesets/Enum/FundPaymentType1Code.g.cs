﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundPaymentType1Code.  ISO2002 ID# _vDyvUF8xEeicg40_9gK9vQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of payment instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vDyvUF8xEeicg40_9gK9vQ")]
[Description(@"Specifies a type of payment instrument.")]
[DerivedFrom(typeof(FundPaymentTypeCode))]
public enum FundPaymentType1Code
{
    /// <summary>
    /// Payment instrument is a bankers draft.
    /// Encoded/decoded by serializers as "DRAF".
    /// </summary>
    [EnumMember(Value = "DRAF")]
    [IsoId("_wli18V8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a bankers draft.")]
    BankersDraft = FundPaymentTypeCode.BankersDraft, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instrument is a cash account.
    /// Encoded/decoded by serializers as "CACC".
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_wqTaIV8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a cash account.")]
    CashAccount = FundPaymentTypeCode.CashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instrument is a cheque.
    /// Encoded/decoded by serializers as "CHEQ".
    /// </summary>
    [EnumMember(Value = "CHEQ")]
    [IsoId("_w1dhQV8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a cheque.")]
    Cheque = FundPaymentTypeCode.Cheque, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instrument is a credit transfer.
    /// Encoded/decoded by serializers as "CRDT".
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_w9Cv8V8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a credit transfer.")]
    CreditTransfer = FundPaymentTypeCode.CreditTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instrument is a direct debit.
    /// Encoded/decoded by serializers as "DDEB".
    /// </summary>
    [EnumMember(Value = "DDEB")]
    [IsoId("_xC2dAV8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a direct debit.")]
    DirectDebit = FundPaymentTypeCode.DirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instrument is a payment card.
    /// Encoded/decoded by serializers as "CARD".
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_xIzUAV8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a payment card.")]
    PaymentCard = FundPaymentTypeCode.PaymentCard, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundPaymentType1CodeMetadataExtensions
{
    private static readonly FundPaymentType1CodeDropdownSource _dropdownSource = new FundPaymentType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundPaymentType1CodeDropdownRow GetMetadata(this FundPaymentType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


