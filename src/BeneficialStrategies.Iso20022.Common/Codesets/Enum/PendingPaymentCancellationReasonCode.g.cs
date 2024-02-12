﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingPaymentCancellationReasonCode.  ISO2002 ID# _Rar2EB0-EeiYoZGjIMHr2A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the reason as to why a payment cancellation request is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Rar2EB0-EeiYoZGjIMHr2A")]
[Description(@"Provides the reason as to why a payment cancellation request is pending.")]
[Derivations(typeof(PendingPaymentCancellationReason1Code),typeof(PendingPaymentCancellationReason2Code))]
public enum PendingPaymentCancellationReasonCode
{
    /// <summary>
    /// The cancellation has been forwarded to the next agent in the payment chain.
    /// Encoded/decoded by serializers as "PTNA".
    /// </summary>
    [EnumMember(Value = "PTNA")]
    [IsoId("_aULmUB0-EeiYoZGjIMHr2A")]
    [Description(@"The cancellation has been forwarded to the next agent in the payment chain.")]
    PassedToNextAgent,
    
    /// <summary>
    /// Creditor authorisation is required to return the payment.
    /// Encoded/decoded by serializers as "RQDA".
    /// </summary>
    [EnumMember(Value = "RQDA")]
    [IsoId("_kfp70B0-EeiYoZGjIMHr2A")]
    [Description(@"Creditor authorisation is required to return the payment.")]
    RequestedDebitAuthority,
    
    /// <summary>
    /// Cancellation indemnity is required. 
    /// Encoded/decoded by serializers as "INDM".
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_1gtpEB0-EeiYoZGjIMHr2A")]
    [Description(@"Cancellation indemnity is required. |")]
    CancellationIndemnityRequired,
    
}
