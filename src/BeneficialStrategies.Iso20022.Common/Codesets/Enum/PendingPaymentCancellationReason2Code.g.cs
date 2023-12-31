﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingPaymentCancellationReason2Code.  ISO2002 ID# _37XkMCCMEei5H9PsIMzTkw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the reason as to why a payment cancellation request is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_37XkMCCMEei5H9PsIMzTkw")]
[Description(@"Provides the reason as to why a payment cancellation request is pending.")]
[DerivedFrom(typeof(PendingPaymentCancellationReasonCode))]
public enum PendingPaymentCancellationReason2Code
{
    /// <summary>
    /// Cancellation indemnity is required. 
    /// 
    /// Encoded/decoded by serializers as "CancellationIndemnityRequired".
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_8g490SCMEei5H9PsIMzTkw")]
    [Description(@"Cancellation indemnity is required.  ")]
    CancellationIndemnityRequired,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingPaymentCancellationReason2CodeMetadataExtensions
{
    private static readonly PendingPaymentCancellationReason2CodeDropdownSource _dropdownSource = new PendingPaymentCancellationReason2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingPaymentCancellationReason2CodeDropdownRow GetMetadata(this PendingPaymentCancellationReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


