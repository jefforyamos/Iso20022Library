﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TrackerEventType1Code.  ISO2002 ID# _wQDn0HlAEei6J5_ka3EtUg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of payment event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wQDn0HlAEei6J5_ka3EtUg")]
[Description(@"Indicates the type of payment event.")]
[DerivedFrom(typeof(TrackerEventTypeCode))]
public enum TrackerEventType1Code
{
    /// <summary>
    /// Indicates a cover payment.
    /// Encoded/decoded by serializers as "CoverPayment".
    /// </summary>
    [EnumMember(Value = "COPT")]
    [IsoId("_itKQkYaTEeiMm4lwapNmDA")]
    [Description(@"Indicates a cover payment.")]
    CoverPayment,
    
    /// <summary>
    /// Indicates a customer credit transfer payment.
    /// Encoded/decoded by serializers as "CustomerCreditTransferPayment".
    /// </summary>
    [EnumMember(Value = "CTPT")]
    [IsoId("_i4nSoYaTEeiMm4lwapNmDA")]
    [Description(@"Indicates a customer credit transfer payment.")]
    CustomerCreditTransferPayment,
    
    /// <summary>
    /// Indicates a cancellation request related to a credit transfer payment.
    /// Encoded/decoded by serializers as "CreditTransferPaymentCancellationRequest".
    /// </summary>
    [EnumMember(Value = "CTCA")]
    [IsoId("_jAWSUYaTEeiMm4lwapNmDA")]
    [Description(@"Indicates a cancellation request related to a credit transfer payment.")]
    CreditTransferPaymentCancellationRequest,
    
    /// <summary>
    /// Indicates the tracking status of a cancellation request related to a credit transfer payment.
    /// Encoded/decoded by serializers as "CreditTransferPaymentCancellationRequestTrackingStatus".
    /// </summary>
    [EnumMember(Value = "CTTS")]
    [IsoId("_jIh98YaTEeiMm4lwapNmDA")]
    [Description(@"Indicates the tracking status of a cancellation request related to a credit transfer payment.")]
    CreditTransferPaymentCancellationRequestTrackingStatus,
    
    /// <summary>
    /// Indicates a cancellation response related to a credit transfer payment.
    /// Encoded/decoded by serializers as "CreditTransferPaymentCancellationResponse".
    /// </summary>
    [EnumMember(Value = "CTCR")]
    [IsoId("_jPrHwYaTEeiMm4lwapNmDA")]
    [Description(@"Indicates a cancellation response related to a credit transfer payment.")]
    CreditTransferPaymentCancellationResponse,
    
    /// <summary>
    /// Indicates a cover payment status update.
    /// Encoded/decoded by serializers as "StatusUpdateCoverPayment".
    /// </summary>
    [EnumMember(Value = "COSU")]
    [IsoId("_jWN0oYaTEeiMm4lwapNmDA")]
    [Description(@"Indicates a cover payment status update.")]
    StatusUpdateCoverPayment,
    
    /// <summary>
    /// Indicates a customer credit transfer payment status update.
    /// Encoded/decoded by serializers as "StatusUpdateCustomerCreditTransferPayment".
    /// </summary>
    [EnumMember(Value = "CTSU")]
    [IsoId("_jdzqYYaTEeiMm4lwapNmDA")]
    [Description(@"Indicates a customer credit transfer payment status update.")]
    StatusUpdateCustomerCreditTransferPayment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TrackerEventType1CodeMetadataExtensions
{
    private static readonly TrackerEventType1CodeDropdownSource _dropdownSource = new TrackerEventType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITrackerEventType1CodeDropdownRow GetMetadata(this TrackerEventType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


