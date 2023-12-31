﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardPaymentServiceType13Code.  ISO2002 ID# __bL2gNueEeiB5uLfkg9ZJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Additional attribute of the service type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__bL2gNueEeiB5uLfkg9ZJA")]
[Description(@"Additional attribute of the service type.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
public enum CardPaymentServiceType13Code
{
    /// <summary>
    /// Card payment.
    /// Encoded/decoded by serializers as "CardPayment".
    /// </summary>
    [EnumMember(Value = "CRDP")]
    [IsoId("_CzZIcdufEeiB5uLfkg9ZJA")]
    [Description(@"Card payment.")]
    CardPayment,
    
    /// <summary>
    /// Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.
    /// Encoded/decoded by serializers as "CashAdvance".
    /// </summary>
    [EnumMember(Value = "CSHW")]
    [IsoId("_Dda84dufEeiB5uLfkg9ZJA")]
    [Description(@"Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.")]
    CashAdvance,
    
    /// <summary>
    /// Cash deposit.
    /// Encoded/decoded by serializers as "CashDeposit".
    /// </summary>
    [EnumMember(Value = "CSHD")]
    [IsoId("_ELN3AdufEeiB5uLfkg9ZJA")]
    [Description(@"Cash deposit.")]
    CashDeposit,
    
    /// <summary>
    /// Initial reservation.
    /// Encoded/decoded by serializers as "InitialReservation".
    /// </summary>
    [EnumMember(Value = "IRES")]
    [IsoId("_FayBcdufEeiB5uLfkg9ZJA")]
    [Description(@"Initial reservation.")]
    InitialReservation,
    
    /// <summary>
    /// Deferred payment.
    /// Encoded/decoded by serializers as "DeferredPayment".
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("_GD6eAdufEeiB5uLfkg9ZJA")]
    [Description(@"Deferred payment.")]
    DeferredPayment,
    
    /// <summary>
    /// Update reservation.
    /// Encoded/decoded by serializers as "UpdateReservation".
    /// </summary>
    [EnumMember(Value = "URES")]
    [IsoId("_HMJ4cdufEeiB5uLfkg9ZJA")]
    [Description(@"Update reservation.")]
    UpdateReservation,
    
    /// <summary>
    /// Payment after reservation.
    /// Encoded/decoded by serializers as "PaymentReservation".
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_J2hM8dufEeiB5uLfkg9ZJA")]
    [Description(@"Payment after reservation.")]
    PaymentReservation,
    
    /// <summary>
    /// Recurring payment.
    /// Encoded/decoded by serializers as "RecurringPayment".
    /// </summary>
    [EnumMember(Value = "RECP")]
    [IsoId("_Khy-kdufEeiB5uLfkg9ZJA")]
    [Description(@"Recurring payment.")]
    RecurringPayment,
    
    /// <summary>
    /// Instalment payment.
    /// Encoded/decoded by serializers as "Instalment".
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_MAr-cdufEeiB5uLfkg9ZJA")]
    [Description(@"Instalment payment.")]
    Instalment,
    
    /// <summary>
    /// Instalment payment transaction performed by the card issuer.
    /// Encoded/decoded by serializers as "IssuerInstalment".
    /// </summary>
    [EnumMember(Value = "INSI")]
    [IsoId("_MZUg4dufEeiB5uLfkg9ZJA")]
    [Description(@"Instalment payment transaction performed by the card issuer.")]
    IssuerInstalment,
    
    /// <summary>
    /// Refund transaction.
    /// Encoded/decoded by serializers as "Refund".
    /// </summary>
    [EnumMember(Value = "RFND")]
    [IsoId("_NeARAdufEeiB5uLfkg9ZJA")]
    [Description(@"Refund transaction.")]
    Refund,
    
    /// <summary>
    /// Voice authorisation.
    /// Encoded/decoded by serializers as "VoiceAuthorisation".
    /// </summary>
    [EnumMember(Value = "VCAU")]
    [IsoId("_OpXQ4dufEeiB5uLfkg9ZJA")]
    [Description(@"Voice authorisation.")]
    VoiceAuthorisation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardPaymentServiceType13CodeMetadataExtensions
{
    private static readonly CardPaymentServiceType13CodeDropdownSource _dropdownSource = new CardPaymentServiceType13CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardPaymentServiceType13CodeDropdownRow GetMetadata(this CardPaymentServiceType13Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


