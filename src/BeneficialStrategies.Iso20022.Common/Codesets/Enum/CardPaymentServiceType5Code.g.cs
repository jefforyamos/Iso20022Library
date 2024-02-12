﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardPaymentServiceType5Code.  ISO2002 ID# _o8xIATAUEeOqioR9srQH1g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Main service provided during the card payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_o8xIATAUEeOqioR9srQH1g")]
[Description(@"Main service provided during the card payment transaction.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
public enum CardPaymentServiceType5Code
{
    /// <summary>
    /// Balance enquiry.
    /// Encoded/decoded by serializers as "BALC".
    /// </summary>
    [EnumMember(Value = "BALC")]
    [IsoId("_pM_VVTAUEeOqioR9srQH1g")]
    [Description(@"Balance enquiry.")]
    Balance = CardPaymentServiceTypeCode.Balance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card activation.
    /// Encoded/decoded by serializers as "CACT".
    /// </summary>
    [EnumMember(Value = "CACT")]
    [IsoId("_pM_VVzAUEeOqioR9srQH1g")]
    [Description(@"Card activation.")]
    CardActivation = CardPaymentServiceTypeCode.CardActivation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card payment.
    /// Encoded/decoded by serializers as "CRDP".
    /// </summary>
    [EnumMember(Value = "CRDP")]
    [IsoId("_pM_VWTAUEeOqioR9srQH1g")]
    [Description(@"Card payment.")]
    CardPayment = CardPaymentServiceTypeCode.CardPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer of funds to a card or an account.
    /// Encoded/decoded by serializers as "CAFH".
    /// </summary>
    [EnumMember(Value = "CAFH")]
    [IsoId("_pM_VWzAUEeOqioR9srQH1g")]
    [Description(@"Transfer of funds to a card or an account.")]
    CardsFundTransferPush = CardPaymentServiceTypeCode.CardsFundTransferPush, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card verification.
    /// Encoded/decoded by serializers as "CAVR".
    /// </summary>
    [EnumMember(Value = "CAVR")]
    [IsoId("_pNIfQTAUEeOqioR9srQH1g")]
    [Description(@"Card verification.")]
    CardVerification = CardPaymentServiceTypeCode.CardVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.
    /// Encoded/decoded by serializers as "CSHW".
    /// </summary>
    [EnumMember(Value = "CSHW")]
    [IsoId("_pNIfQzAUEeOqioR9srQH1g")]
    [Description(@"Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.")]
    CashAdvance = CardPaymentServiceTypeCode.CashAdvance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash deposit.
    /// Encoded/decoded by serializers as "CSHD".
    /// </summary>
    [EnumMember(Value = "CSHD")]
    [IsoId("_pNIfRzAUEeOqioR9srQH1g")]
    [Description(@"Cash deposit.")]
    CashDeposit = CardPaymentServiceTypeCode.CashDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deferred payment.
    /// Encoded/decoded by serializers as "DEFR".
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("_pNIfSTAUEeOqioR9srQH1g")]
    [Description(@"Deferred payment.")]
    DeferredPayment = CardPaymentServiceTypeCode.DeferredPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Loading or reloading non-financial account.
    /// Encoded/decoded by serializers as "LOAD".
    /// </summary>
    [EnumMember(Value = "LOAD")]
    [IsoId("_pNIfSzAUEeOqioR9srQH1g")]
    [Description(@"Loading or reloading non-financial account.")]
    Loading = CardPaymentServiceTypeCode.Loading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original credit.
    /// Encoded/decoded by serializers as "ORCR".
    /// </summary>
    [EnumMember(Value = "ORCR")]
    [IsoId("_pNIfTTAUEeOqioR9srQH1g")]
    [Description(@"Original credit.")]
    OriginalCredit = CardPaymentServiceTypeCode.OriginalCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN (Personal Identification Number) change.
    /// Encoded/decoded by serializers as "PINC".
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_pNIfTzAUEeOqioR9srQH1g")]
    [Description(@"PIN (Personal Identification Number) change.")]
    PINChange = CardPaymentServiceTypeCode.PINChange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quasi-cash.
    /// Encoded/decoded by serializers as "QUCH".
    /// </summary>
    [EnumMember(Value = "QUCH")]
    [IsoId("_pNIfUTAUEeOqioR9srQH1g")]
    [Description(@"Quasi-cash.")]
    QuasiCash = CardPaymentServiceTypeCode.QuasiCash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Refund transaction.
    /// Encoded/decoded by serializers as "RFND".
    /// </summary>
    [EnumMember(Value = "RFND")]
    [IsoId("_pNIfUzAUEeOqioR9srQH1g")]
    [Description(@"Refund transaction.")]
    Refund = CardPaymentServiceTypeCode.Refund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reservation (pre-authorisation).
    /// Encoded/decoded by serializers as "RESA".
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("_pNIfVTAUEeOqioR9srQH1g")]
    [Description(@"Reservation (pre-authorisation).")]
    Reservation = CardPaymentServiceTypeCode.Reservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card validity check.
    /// Encoded/decoded by serializers as "VALC".
    /// </summary>
    [EnumMember(Value = "VALC")]
    [IsoId("_pNIfVzAUEeOqioR9srQH1g")]
    [Description(@"Card validity check.")]
    ValidityCheck = CardPaymentServiceTypeCode.ValidityCheck, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unloading non-financial account.
    /// Encoded/decoded by serializers as "UNLD".
    /// </summary>
    [EnumMember(Value = "UNLD")]
    [IsoId("_cjJaoTGuEeOAS49rwg4CIQ")]
    [Description(@"Unloading non-financial account.")]
    Unloading = CardPaymentServiceTypeCode.Unloading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer of funds to and/or from a card account.
    /// Encoded/decoded by serializers as "CAFT".
    /// </summary>
    [EnumMember(Value = "CAFT")]
    [IsoId("_gvYlsUuFEeOC3MFxIpMwug")]
    [Description(@"Transfer of funds to and/or from a card account.")]
    CardsFundTransfer = CardPaymentServiceTypeCode.CardsFundTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer of funds from a card or an account.
    /// Encoded/decoded by serializers as "CAFL".
    /// </summary>
    [EnumMember(Value = "CAFL")]
    [IsoId("_hBaw4UuFEeOC3MFxIpMwug")]
    [Description(@"Transfer of funds from a card or an account.")]
    CardsFundTransferPull = CardPaymentServiceTypeCode.CardsFundTransferPull, // same ordinal as derivation source for type conversions
    
}
