﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentStatus5.  ISO2002 ID# _Gkqk8KXXEeaBtJ1HvhzRtg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the payment transaction status and optionally the reason for that status. 
/// </summary>
public partial record PaymentStatus5
{
    #nullable enable
    
    /// <summary>
    /// Provides more details on the status in process.
    /// </summary>
    public required TransactionIndividualStatus4Code Status { get; init; } 
    /// <summary>
    /// Contains optionally the reason for the status of a payment transaction.
    /// </summary>
    public PaymentStatusReason2Code? Reason { get; init; } 
    
    #nullable disable
}
