﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingPaymentCancellationReason1Code.  ISO2002 ID# _BIXosB0_EeiYoZGjIMHr2A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the reason as to why a payment cancellation request is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BIXosB0_EeiYoZGjIMHr2A")]
[Description(@"Provides the reason as to why a payment cancellation request is pending.")]
[DerivedFrom(typeof(PendingPaymentCancellationReasonCode))]
public enum PendingPaymentCancellationReason1Code
{
    /// <summary>
    /// Cancellation indemnity is required. 
    /// Encoded/decoded by serializers as "INDM".
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_DXz7wR0_EeiYoZGjIMHr2A")]
    [Description(@"Cancellation indemnity is required. |")]
    CancellationIndemnityRequired = PendingPaymentCancellationReasonCode.CancellationIndemnityRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The cancellation has been forwarded to the next agent in the payment chain.
    /// Encoded/decoded by serializers as "PTNA".
    /// </summary>
    [EnumMember(Value = "PTNA")]
    [IsoId("_Dfnz8h0_EeiYoZGjIMHr2A")]
    [Description(@"The cancellation has been forwarded to the next agent in the payment chain.")]
    PassedToNextAgent = PendingPaymentCancellationReasonCode.PassedToNextAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor authorisation is required to return the payment.
    /// Encoded/decoded by serializers as "RQDA".
    /// </summary>
    [EnumMember(Value = "RQDA")]
    [IsoId("_Dmi7Uh0_EeiYoZGjIMHr2A")]
    [Description(@"Creditor authorisation is required to return the payment.")]
    RequestedDebitAuthority = PendingPaymentCancellationReasonCode.RequestedDebitAuthority, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingPaymentCancellationReason1CodeMetadataExtensions
{
    private static readonly PendingPaymentCancellationReason1CodeDropdownSource _dropdownSource = new PendingPaymentCancellationReason1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingPaymentCancellationReason1CodeDropdownRow GetMetadata(this PendingPaymentCancellationReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


