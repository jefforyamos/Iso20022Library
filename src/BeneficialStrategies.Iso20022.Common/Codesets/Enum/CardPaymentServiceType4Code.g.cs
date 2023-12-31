﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardPaymentServiceType4Code.  ISO2002 ID# _43pE4B0mEeK5OKMB21JFBg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// Encoded/decoded by serializers as "PersonToPerson".
    /// </summary>
    [EnumMember(Value = "TP2P")]
    [IsoId("_DAJl8R0nEeK5OKMB21JFBg")]
    [Description(@"Card payment transaction transfer from person to person.")]
    PersonToPerson,
    
    /// <summary>
    /// Card payment transaction transfer from person to business.
    /// Encoded/decoded by serializers as "PersonToBusiness".
    /// </summary>
    [EnumMember(Value = "TP2B")]
    [IsoId("_DO3-cR0nEeK5OKMB21JFBg")]
    [Description(@"Card payment transaction transfer from person to business.")]
    PersonToBusiness,
    
    /// <summary>
    /// Balance enquiry.
    /// Encoded/decoded by serializers as "Balance".
    /// </summary>
    [EnumMember(Value = "BALC")]
    [IsoId("_GWYh8R0nEeK5OKMB21JFBg")]
    [Description(@"Balance enquiry.")]
    Balance,
    
    /// <summary>
    /// Card activation.
    /// Encoded/decoded by serializers as "CardActivation".
    /// </summary>
    [EnumMember(Value = "CACT")]
    [IsoId("_GuL98x0nEeK5OKMB21JFBg")]
    [Description(@"Card activation.")]
    CardActivation,
    
    /// <summary>
    /// Card payment.
    /// Encoded/decoded by serializers as "CardPayment".
    /// </summary>
    [EnumMember(Value = "CRDP")]
    [IsoId("_HJahYR0nEeK5OKMB21JFBg")]
    [Description(@"Card payment.")]
    CardPayment,
    
    /// <summary>
    /// Transfer of funds to and/or from a card account.
    /// Encoded/decoded by serializers as "CardsFundTransfer".
    /// </summary>
    [EnumMember(Value = "CAFT")]
    [IsoId("_HmbNgR0nEeK5OKMB21JFBg")]
    [Description(@"Transfer of funds to and/or from a card account.")]
    CardsFundTransfer,
    
    /// <summary>
    /// Card verification.
    /// Encoded/decoded by serializers as "CardVerification".
    /// </summary>
    [EnumMember(Value = "CAVR")]
    [IsoId("_H9VRox0nEeK5OKMB21JFBg")]
    [Description(@"Card verification.")]
    CardVerification,
    
    /// <summary>
    /// Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.
    /// Encoded/decoded by serializers as "CashAdvance".
    /// </summary>
    [EnumMember(Value = "CSHW")]
    [IsoId("_IS55AR0nEeK5OKMB21JFBg")]
    [Description(@"Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.")]
    CashAdvance,
    
    /// <summary>
    /// Card payment with cash-back.
    /// Encoded/decoded by serializers as "CashBack".
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_JaUNAR0nEeK5OKMB21JFBg")]
    [Description(@"Card payment with cash-back.")]
    CashBack,
    
    /// <summary>
    /// Cash deposit.
    /// Encoded/decoded by serializers as "CashDeposit".
    /// </summary>
    [EnumMember(Value = "CSHD")]
    [IsoId("_JtNT0x0nEeK5OKMB21JFBg")]
    [Description(@"Cash deposit.")]
    CashDeposit,
    
    /// <summary>
    /// Deferred payment.
    /// Encoded/decoded by serializers as "DeferredPayment".
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("_KGf9kR0nEeK5OKMB21JFBg")]
    [Description(@"Deferred payment.")]
    DeferredPayment,
    
    /// <summary>
    /// Loading or reloading non-financial account.
    /// Encoded/decoded by serializers as "Loading".
    /// </summary>
    [EnumMember(Value = "LOAD")]
    [IsoId("_Kxy9Ux0nEeK5OKMB21JFBg")]
    [Description(@"Loading or reloading non-financial account.")]
    Loading,
    
    /// <summary>
    /// Original credit.
    /// Encoded/decoded by serializers as "OriginalCredit".
    /// </summary>
    [EnumMember(Value = "ORCR")]
    [IsoId("_LXlK8R0nEeK5OKMB21JFBg")]
    [Description(@"Original credit.")]
    OriginalCredit,
    
    /// <summary>
    /// PIN (Personal Identification Number) change.
    /// Encoded/decoded by serializers as "PINChange".
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_MTYr4R0nEeK5OKMB21JFBg")]
    [Description(@"PIN (Personal Identification Number) change.")]
    PINChange,
    
    /// <summary>
    /// Quasi-cash.
    /// Encoded/decoded by serializers as "QuasiCash".
    /// </summary>
    [EnumMember(Value = "QUCH")]
    [IsoId("_Mx4lwR0nEeK5OKMB21JFBg")]
    [Description(@"Quasi-cash.")]
    QuasiCash,
    
    /// <summary>
    /// Refund transaction.
    /// Encoded/decoded by serializers as "Refund".
    /// </summary>
    [EnumMember(Value = "RFND")]
    [IsoId("_NHnlMR0nEeK5OKMB21JFBg")]
    [Description(@"Refund transaction.")]
    Refund,
    
    /// <summary>
    /// Reservation (pre-authorisation).
    /// Encoded/decoded by serializers as "Reservation".
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("_NoWTsx0nEeK5OKMB21JFBg")]
    [Description(@"Reservation (pre-authorisation).")]
    Reservation,
    
    /// <summary>
    /// Card validity check.
    /// Encoded/decoded by serializers as "ValidityCheck".
    /// </summary>
    [EnumMember(Value = "VALC")]
    [IsoId("_N2xxQR0nEeK5OKMB21JFBg")]
    [Description(@"Card validity check.")]
    ValidityCheck,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardPaymentServiceType4CodeMetadataExtensions
{
    private static readonly CardPaymentServiceType4CodeDropdownSource _dropdownSource = new CardPaymentServiceType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardPaymentServiceType4CodeDropdownRow GetMetadata(this CardPaymentServiceType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


