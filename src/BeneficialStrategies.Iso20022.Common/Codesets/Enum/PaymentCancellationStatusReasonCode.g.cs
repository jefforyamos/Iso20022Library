﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentCancellationStatusReasonCode.  ISO2002 ID# _OnEtsB04EeiYoZGjIMHr2A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides status reasons with regards to the cancellation of the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OnEtsB04EeiYoZGjIMHr2A")]
[Description(@"Provides status reasons with regards to the cancellation of the payment.")]
[Derivations(typeof(PaymentCancellationStatusReason3Code),typeof(PaymentCancellationStatusReason2Code))]
// External derivations that should be provided by the proper interface are: 
public enum PaymentCancellationStatusReasonCode
{
    /// <summary>
    /// Stop and recall request forwarded to processing/last agent but delivery acknowledgement not received.
    /// Encoded/decoded by serializers as "S003".
    /// </summary>
    [EnumMember(Value = "S003")]
    [IsoId("_eKFIkB04EeiYoZGjIMHr2A")]
    [Description(@"Stop and recall request forwarded to processing/last agent but delivery acknowledgement not received.")]
    ForwardedToAgent,
    
    /// <summary>
    /// Stop and recall request forwarded to processing/last agent and delivery acknowledgement received.
    /// Encoded/decoded by serializers as "S004".
    /// </summary>
    [EnumMember(Value = "S004")]
    [IsoId("_g-vokR04EeiYoZGjIMHr2A")]
    [Description(@"Stop and recall request forwarded to processing/last agent and delivery acknowledgement received.")]
    DeliveryAcknowledgementReceived,
    
    /// <summary>
    /// Payment instruction stopped because the UETR was cancelled.
    /// Encoded/decoded by serializers as "S002".
    /// </summary>
    [EnumMember(Value = "S002")]
    [IsoId("_Nk17gD4wEei1cqDe0mKAOg")]
    [Description(@"Payment instruction stopped because the UETR was cancelled.")]
    PaymentStopped,
    
    /// <summary>
    /// Stop and recall request sent to the tracking system.
    /// Encoded/decoded by serializers as "S000".
    /// </summary>
    [EnumMember(Value = "S000")]
    [IsoId("_zr5ksIEkEei51tn2YGQhvg")]
    [Description(@"Stop and recall request sent to the tracking system.")]
    SentToTrackingSystem,
    
    /// <summary>
    /// Stop and recall request added to cancellation list.
    /// Encoded/decoded by serializers as "S001".
    /// </summary>
    [EnumMember(Value = "S001")]
    [IsoId("_EDHqwIElEei51tn2YGQhvg")]
    [Description(@"Stop and recall request added to cancellation list.")]
    AddedToCancellationList,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentCancellationStatusReasonCodeMetadataExtensions
{
    private static readonly PaymentCancellationStatusReasonCodeDropdownSource _dropdownSource = new PaymentCancellationStatusReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentCancellationStatusReasonCodeDropdownRow GetMetadata(this PaymentCancellationStatusReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


