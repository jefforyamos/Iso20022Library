﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardPaymentServiceType14Code.  ISO2002 ID# _dMN6wU7DEeyGi9JAv6wq7Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Additional attributes of the service provided by the card payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dMN6wU7DEeyGi9JAv6wq7Q")]
[Description(@"Additional attributes of the service provided by the card payment transaction.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
public enum CardPaymentServiceType14Code
{
    /// <summary>
    /// Initial reservation.
    /// Encoded/decoded by serializers as "IRES".
    /// </summary>
    [EnumMember(Value = "IRES")]
    [IsoId("_dSuycU7DEeyGi9JAv6wq7Q")]
    [Description(@"Initial reservation.")]
    InitialReservation = CardPaymentServiceTypeCode.InitialReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update reservation.
    /// Encoded/decoded by serializers as "URES".
    /// </summary>
    [EnumMember(Value = "URES")]
    [IsoId("_dSuyc07DEeyGi9JAv6wq7Q")]
    [Description(@"Update reservation.")]
    UpdateReservation = CardPaymentServiceTypeCode.UpdateReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment after reservation.
    /// Encoded/decoded by serializers as "PRES".
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_dSuydU7DEeyGi9JAv6wq7Q")]
    [Description(@"Payment after reservation.")]
    PaymentReservation = CardPaymentServiceTypeCode.PaymentReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Additional payment after reservation.
    /// Encoded/decoded by serializers as "ARES".
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_dSuyd07DEeyGi9JAv6wq7Q")]
    [Description(@"Additional payment after reservation.")]
    AdditionalPayment = CardPaymentServiceTypeCode.AdditionalPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Initial recurring payment.
    /// Encoded/decoded by serializers as "FREC".
    /// </summary>
    [EnumMember(Value = "FREC")]
    [IsoId("_dSuyeU7DEeyGi9JAv6wq7Q")]
    [Description(@"Initial recurring payment.")]
    FirstRecurring = CardPaymentServiceTypeCode.FirstRecurring, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Repeat recurring payment.
    /// Encoded/decoded by serializers as "RREC".
    /// </summary>
    [EnumMember(Value = "RREC")]
    [IsoId("_dSuye07DEeyGi9JAv6wq7Q")]
    [Description(@"Repeat recurring payment.")]
    FollowingRecurring = CardPaymentServiceTypeCode.FollowingRecurring, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Acceptor claims for guarantee of payment.
    /// Encoded/decoded by serializers as "GOPT".
    /// </summary>
    [EnumMember(Value = "GOPT")]
    [IsoId("_r4DdEU7DEeyGi9JAv6wq7Q")]
    [Description(@"Acceptor claims for guarantee of payment.")]
    GuaranteeOfPayment = CardPaymentServiceTypeCode.GuaranteeOfPayment, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardPaymentServiceType14CodeMetadataExtensions
{
    private static readonly CardPaymentServiceType14CodeDropdownSource _dropdownSource = new CardPaymentServiceType14CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardPaymentServiceType14CodeDropdownRow GetMetadata(this CardPaymentServiceType14Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


