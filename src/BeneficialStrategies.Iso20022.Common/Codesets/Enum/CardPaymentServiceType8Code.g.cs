﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardPaymentServiceType8Code.  ISO2002 ID# _CPqhwHsvEeSTS7uHCe8FPQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Main card service transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CPqhwHsvEeSTS7uHCe8FPQ")]
[Description(@"Main card service transaction.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
public enum CardPaymentServiceType8Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Aggregation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_LBMBwXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    Aggregation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashBack".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_LlfosXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    CashBack,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ChosenWithdrawal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_L0wMsXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    ChosenWithdrawal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DCC".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NKkJEXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    DCC,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Gratuity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NYAvMXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    Gratuity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcceptorInstalment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NtmksXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    AcceptorInstalment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IssuerInstalment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ROSdMXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    IssuerInstalment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Loyalty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_SVeHsXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    Loyalty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoShow".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_S7FWMXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    NoShow,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreAuthorisedWithdrawal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Te2xoXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    PreAuthorisedWithdrawal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProfileWithdrawal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UwHlMXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    ProfileWithdrawal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PurchaseCorporate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U4bzsXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    PurchaseCorporate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RecurringPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxRgMXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    RecurringPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SolicitedAvailableFunds".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_V9jBoXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    SolicitedAvailableFunds,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StandardWithdrawal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_W3BAQXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    StandardWithdrawal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VoiceAuthorisation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XGMEsXsvEeSTS7uHCe8FPQ")]
    [Description(@"??")]
    VoiceAuthorisation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonRefundable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PZpogYIOEeSvPp7yXrNQIw")]
    [Description(@"??")]
    NonRefundable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Instant".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_qWNyQS-JEeWfYucYWs4iQg")]
    [Description(@"??")]
    Instant,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardPaymentServiceType8CodeMetadataExtensions
{
    private static readonly CardPaymentServiceType8CodeDropdownSource _dropdownSource = new CardPaymentServiceType8CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardPaymentServiceType8CodeDropdownRow GetMetadata(this CardPaymentServiceType8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


