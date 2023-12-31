﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardPaymentServiceType1Code.  ISO2002 ID# _TSg-gQEcEeCQm6a_G2yO_w_1098554220.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of service provided by the card payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSg-gQEcEeCQm6a_G2yO_w_1098554220")]
[Description(@"Type of service provided by the card payment transaction.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
public enum CardPaymentServiceType1Code
{
    /// <summary>
    /// Transfer of funds to and/or from a card account.
    /// Encoded/decoded by serializers as "CardsFundTransfer".
    /// </summary>
    [EnumMember(Value = "CAFT")]
    [IsoId("_TSg-ggEcEeCQm6a_G2yO_w_-897565888")]
    [Description(@"Transfer of funds to and/or from a card account.")]
    CardsFundTransfer,
    
    /// <summary>
    /// Original credit.
    /// Encoded/decoded by serializers as "OriginalCredit".
    /// </summary>
    [EnumMember(Value = "ORCR")]
    [IsoId("_TSqIYAEcEeCQm6a_G2yO_w_565206622")]
    [Description(@"Original credit.")]
    OriginalCredit,
    
    /// <summary>
    /// Card payment.
    /// Encoded/decoded by serializers as "CardPayment".
    /// </summary>
    [EnumMember(Value = "CRDP")]
    [IsoId("_TSqIYQEcEeCQm6a_G2yO_w_-717150152")]
    [Description(@"Card payment.")]
    CardPayment,
    
    /// <summary>
    /// Card payment with cash-back.
    /// Encoded/decoded by serializers as "CashBack".
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_TSqIYgEcEeCQm6a_G2yO_w_1357942539")]
    [Description(@"Card payment with cash-back.")]
    CashBack,
    
    /// <summary>
    /// Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.
    /// Encoded/decoded by serializers as "CashAdvance".
    /// </summary>
    [EnumMember(Value = "CSHW")]
    [IsoId("_TSqIYwEcEeCQm6a_G2yO_w_-1031105037")]
    [Description(@"Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.")]
    CashAdvance,
    
    /// <summary>
    /// Cash deposit.
    /// Encoded/decoded by serializers as "CashDeposit".
    /// </summary>
    [EnumMember(Value = "CSHD")]
    [IsoId("_TSqIZAEcEeCQm6a_G2yO_w_906120136")]
    [Description(@"Cash deposit.")]
    CashDeposit,
    
    /// <summary>
    /// Deferred payment.
    /// Encoded/decoded by serializers as "DeferredPayment".
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("_TSqIZQEcEeCQm6a_G2yO_w_2032417257")]
    [Description(@"Deferred payment.")]
    DeferredPayment,
    
    /// <summary>
    /// Reservation (pre-authorisation).
    /// Encoded/decoded by serializers as "Reservation".
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("_TSqIZgEcEeCQm6a_G2yO_w_-1249057676")]
    [Description(@"Reservation (pre-authorisation).")]
    Reservation,
    
    /// <summary>
    /// Loading or reloading non-financial account.
    /// Encoded/decoded by serializers as "Loading".
    /// </summary>
    [EnumMember(Value = "LOAD")]
    [IsoId("_TSqIZwEcEeCQm6a_G2yO_w_807680454")]
    [Description(@"Loading or reloading non-financial account.")]
    Loading,
    
    /// <summary>
    /// Refund transaction.
    /// Encoded/decoded by serializers as "Refund".
    /// </summary>
    [EnumMember(Value = "RFND")]
    [IsoId("_TSqIaAEcEeCQm6a_G2yO_w_1446470231")]
    [Description(@"Refund transaction.")]
    Refund,
    
    /// <summary>
    /// Quasi-cash.
    /// Encoded/decoded by serializers as "QuasiCash".
    /// </summary>
    [EnumMember(Value = "QUCH")]
    [IsoId("_TSqIaQEcEeCQm6a_G2yO_w_46915301")]
    [Description(@"Quasi-cash.")]
    QuasiCash,
    
    /// <summary>
    /// Balance enquiry.
    /// Encoded/decoded by serializers as "Balance".
    /// </summary>
    [EnumMember(Value = "BALC")]
    [IsoId("_TSqIagEcEeCQm6a_G2yO_w_14944537")]
    [Description(@"Balance enquiry.")]
    Balance,
    
    /// <summary>
    /// Card activation.
    /// Encoded/decoded by serializers as "CardActivation".
    /// </summary>
    [EnumMember(Value = "CACT")]
    [IsoId("_TSqIawEcEeCQm6a_G2yO_w_-1270792527")]
    [Description(@"Card activation.")]
    CardActivation,
    
    /// <summary>
    /// Card verification.
    /// Encoded/decoded by serializers as "CardVerification".
    /// </summary>
    [EnumMember(Value = "CAVR")]
    [IsoId("_TSqIbAEcEeCQm6a_G2yO_w_1319956496")]
    [Description(@"Card verification.")]
    CardVerification,
    
    /// <summary>
    /// PIN (Personal Identification Number) change.
    /// Encoded/decoded by serializers as "PINChange".
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_TSqIbQEcEeCQm6a_G2yO_w_554107845")]
    [Description(@"PIN (Personal Identification Number) change.")]
    PINChange,
    
    /// <summary>
    /// Card validity check.
    /// Encoded/decoded by serializers as "ValidityCheck".
    /// </summary>
    [EnumMember(Value = "VALC")]
    [IsoId("_TSqIbgEcEeCQm6a_G2yO_w_1086949596")]
    [Description(@"Card validity check.")]
    ValidityCheck,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardPaymentServiceType1CodeMetadataExtensions
{
    private static readonly CardPaymentServiceType1CodeDropdownSource _dropdownSource = new CardPaymentServiceType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardPaymentServiceType1CodeDropdownRow GetMetadata(this CardPaymentServiceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


