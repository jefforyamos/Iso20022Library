﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrderCancellationStatus2Code.  ISO2002 ID# _2Zfi8NcPEeaX5rvhR0a-OQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of the order cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2Zfi8NcPEeaX5rvhR0a-OQ")]
[Description(@"Specifies the current status of the order cancellation request.")]
[DerivedFrom(typeof(OrderCancellationStatusCode))]
public enum OrderCancellationStatus2Code
{
    /// <summary>
    /// Order cancellation request has been sent to the next party, eg, the next intermediary.
    /// Encoded/decoded by serializers as "STNP".
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_9vuJodcPEeaX5rvhR0a-OQ")]
    [Description(@"Order cancellation request has been sent to the next party, eg, the next intermediary.")]
    SentToNextParty = OrderCancellationStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status of the order cancellation request is received, that is, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as "RECE".
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_95Dr0dcPEeaX5rvhR0a-OQ")]
    [Description(@"Status of the order cancellation request is received, that is, technical validation of the message is ok, and the message is now at the receiving side.")]
    Received = OrderCancellationStatusCode.Received, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order cancellation request is pending, The order cancellation request has been received but this does not indicate the order has been cancelled.
    /// Encoded/decoded by serializers as "CANP".
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_-BQlkdcPEeaX5rvhR0a-OQ")]
    [Description(@"Order cancellation request is pending, The order cancellation request has been received but this does not indicate the order has been cancelled.")]
    CancellationPending = OrderCancellationStatusCode.CancellationPending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status of the order cancellation request is completed. The cancellation request has been accepted and processed; the order has been cancelled.
    /// Encoded/decoded by serializers as "CAND".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_-JLLcdcPEeaX5rvhR0a-OQ")]
    [Description(@"Status of the order cancellation request is completed. The cancellation request has been accepted and processed; the order has been cancelled.")]
    CancellationCompleted = OrderCancellationStatusCode.CancellationCompleted, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OrderCancellationStatus2CodeMetadataExtensions
{
    private static readonly OrderCancellationStatus2CodeDropdownSource _dropdownSource = new OrderCancellationStatus2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOrderCancellationStatus2CodeDropdownRow GetMetadata(this OrderCancellationStatus2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


