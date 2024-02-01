﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentStatus6.  ISO2002 ID# _P_d5gdEdEei798TPbKJMuw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment status details.
/// </summary>
public partial record PaymentStatus6
{
    #nullable enable
    
    /// <summary>
    /// Status of a transfer, in coded form, as assigned by the transaction administrator.
    /// </summary>
    public PaymentStatusCode6Choice_? Code { get; init; } 
    /// <summary>
    /// Date and time at which the status was assigned to the transfer.
    /// </summary>
    public DateAndDateTime2Choice_? DateTime { get; init; } 
    /// <summary>
    /// Reason provided for the status of a transfer.
    /// </summary>
    public PaymentStatusReason1Choice_[] Reason { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
