﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrderCancellationStatusCode.  ISO2002 ID# _aQk189p-Ed-ak6NoX_4Aeg_85357733.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the current status of the order cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQk189p-Ed-ak6NoX_4Aeg_85357733")]
[Description(@"Specifies the current status of the order cancellation request.")]
public enum OrderCancellationStatusCode
{
    /// <summary>
    /// Order cancellation request has been sent to the next party, eg, the next intermediary.
    /// Encoded/decoded by serializers as "STNP".
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_aQk19Np-Ed-ak6NoX_4Aeg_117683450")]
    [Description(@"Order cancellation request has been sent to the next party, eg, the next intermediary.")]
    SentToNextParty,
    
    /// <summary>
    /// Order cancellation request is pending, The order cancellation request has been received but this does not indicate the order has been cancelled.
    /// Encoded/decoded by serializers as "CANP".
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_aQk19dp-Ed-ak6NoX_4Aeg_131534414")]
    [Description(@"Order cancellation request is pending, The order cancellation request has been received but this does not indicate the order has been cancelled.")]
    CancellationPending,
    
    /// <summary>
    /// Status of the order cancellation request is completed. The cancellation request has been accepted and processed; the order has been cancelled.
    /// Encoded/decoded by serializers as "CAND".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_aQk19tp-Ed-ak6NoX_4Aeg_573306707")]
    [Description(@"Status of the order cancellation request is completed. The cancellation request has been accepted and processed; the order has been cancelled.")]
    CancellationCompleted,
    
    /// <summary>
    /// Status of the order cancellation request is received, that is, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as "RECE".
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_XxrFEdcPEeaX5rvhR0a-OQ")]
    [Description(@"Status of the order cancellation request is received, that is, technical validation of the message is ok, and the message is now at the receiving side.")]
    Received,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OrderCancellationStatusCodeMetadataExtensions
{
    private static readonly OrderCancellationStatusCodeDropdownSource _dropdownSource = new OrderCancellationStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOrderCancellationStatusCodeDropdownRow GetMetadata(this OrderCancellationStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

