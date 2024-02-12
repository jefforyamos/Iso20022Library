﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardPaymentServiceType4Code.  ISO2002 ID# _43pE4B0mEeK5OKMB21JFBg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Main service provided during the card payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_43pE4B0mEeK5OKMB21JFBg")]
[Description(@"Main service provided during the card payment transaction.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
public enum CardPaymentServiceType4Code
{
    /// <summary>
    /// Card payment transaction transfer from person to person.
    /// Encoded/decoded by serializers as "TP2P".
    /// </summary>
    [EnumMember(Value = "TP2P")]
    [IsoId("_DAJl8R0nEeK5OKMB21JFBg")]
    [Description(@"Card payment transaction transfer from person to person.")]
    PersonToPerson = CardPaymentServiceTypeCode.PersonToPerson, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card payment transaction transfer from person to business.
    /// Encoded/decoded by serializers as "TP2B".
    /// </summary>
    [EnumMember(Value = "TP2B")]
    [IsoId("_DO3-cR0nEeK5OKMB21JFBg")]
    [Description(@"Card payment transaction transfer from person to business.")]
    PersonToBusiness = CardPaymentServiceTypeCode.PersonToBusiness, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance enquiry.
    /// Encoded/decoded by serializers as "BALC".
    /// </summary>
    [EnumMember(Value = "BALC")]
    [IsoId("_GWYh8R0nEeK5OKMB21JFBg")]
    [Description(@"Balance enquiry.")]
    Balance = CardPaymentServiceTypeCode.Balance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card activation.
    /// Encoded/decoded by serializers as "CACT".
    /// </summary>
    [EnumMember(Value = "CACT")]
    [IsoId("_GuL98x0nEeK5OKMB21JFBg")]
    [Description(@"Card activation.")]
    CardActivation = CardPaymentServiceTypeCode.CardActivation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card payment.
    /// Encoded/decoded by serializers as "CRDP".
    /// </summary>
    [EnumMember(Value = "CRDP")]
    [IsoId("_HJahYR0nEeK5OKMB21JFBg")]
    [Description(@"Card payment.")]
    CardPayment = CardPaymentServiceTypeCode.CardPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer of funds to and/or from a card account.
    /// Encoded/decoded by serializers as "CAFT".
    /// </summary>
    [EnumMember(Value = "CAFT")]
    [IsoId("_HmbNgR0nEeK5OKMB21JFBg")]
    [Description(@"Transfer of funds to and/or from a card account.")]
    CardsFundTransfer = CardPaymentServiceTypeCode.CardsFundTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card verification.
    /// Encoded/decoded by serializers as "CAVR".
    /// </summary>
    [EnumMember(Value = "CAVR")]
    [IsoId("_H9VRox0nEeK5OKMB21JFBg")]
    [Description(@"Card verification.")]
    CardVerification = CardPaymentServiceTypeCode.CardVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.
    /// Encoded/decoded by serializers as "CSHW".
    /// </summary>
    [EnumMember(Value = "CSHW")]
    [IsoId("_IS55AR0nEeK5OKMB21JFBg")]
    [Description(@"Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.")]
    CashAdvance = CardPaymentServiceTypeCode.CashAdvance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card payment with cash-back.
    /// Encoded/decoded by serializers as "CSHB".
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_JaUNAR0nEeK5OKMB21JFBg")]
    [Description(@"Card payment with cash-back.")]
    CashBack = CardPaymentServiceTypeCode.CashBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash deposit.
    /// Encoded/decoded by serializers as "CSHD".
    /// </summary>
    [EnumMember(Value = "CSHD")]
    [IsoId("_JtNT0x0nEeK5OKMB21JFBg")]
    [Description(@"Cash deposit.")]
    CashDeposit = CardPaymentServiceTypeCode.CashDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deferred payment.
    /// Encoded/decoded by serializers as "DEFR".
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("_KGf9kR0nEeK5OKMB21JFBg")]
    [Description(@"Deferred payment.")]
    DeferredPayment = CardPaymentServiceTypeCode.DeferredPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Loading or reloading non-financial account.
    /// Encoded/decoded by serializers as "LOAD".
    /// </summary>
    [EnumMember(Value = "LOAD")]
    [IsoId("_Kxy9Ux0nEeK5OKMB21JFBg")]
    [Description(@"Loading or reloading non-financial account.")]
    Loading = CardPaymentServiceTypeCode.Loading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original credit.
    /// Encoded/decoded by serializers as "ORCR".
    /// </summary>
    [EnumMember(Value = "ORCR")]
    [IsoId("_LXlK8R0nEeK5OKMB21JFBg")]
    [Description(@"Original credit.")]
    OriginalCredit = CardPaymentServiceTypeCode.OriginalCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN (Personal Identification Number) change.
    /// Encoded/decoded by serializers as "PINC".
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_MTYr4R0nEeK5OKMB21JFBg")]
    [Description(@"PIN (Personal Identification Number) change.")]
    PINChange = CardPaymentServiceTypeCode.PINChange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quasi-cash.
    /// Encoded/decoded by serializers as "QUCH".
    /// </summary>
    [EnumMember(Value = "QUCH")]
    [IsoId("_Mx4lwR0nEeK5OKMB21JFBg")]
    [Description(@"Quasi-cash.")]
    QuasiCash = CardPaymentServiceTypeCode.QuasiCash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Refund transaction.
    /// Encoded/decoded by serializers as "RFND".
    /// </summary>
    [EnumMember(Value = "RFND")]
    [IsoId("_NHnlMR0nEeK5OKMB21JFBg")]
    [Description(@"Refund transaction.")]
    Refund = CardPaymentServiceTypeCode.Refund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reservation (pre-authorisation).
    /// Encoded/decoded by serializers as "RESA".
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("_NoWTsx0nEeK5OKMB21JFBg")]
    [Description(@"Reservation (pre-authorisation).")]
    Reservation = CardPaymentServiceTypeCode.Reservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card validity check.
    /// Encoded/decoded by serializers as "VALC".
    /// </summary>
    [EnumMember(Value = "VALC")]
    [IsoId("_N2xxQR0nEeK5OKMB21JFBg")]
    [Description(@"Card validity check.")]
    ValidityCheck = CardPaymentServiceTypeCode.ValidityCheck, // same ordinal as derivation source for type conversions
    
}
