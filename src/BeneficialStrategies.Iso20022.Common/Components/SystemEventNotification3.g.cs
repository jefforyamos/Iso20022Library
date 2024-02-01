﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SystemEventNotification3.  ISO2002 ID# _7jfqcQ1TEeqjM-rxn3HuXQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of system service to be used with this message.
/// </summary>
public partial record SystemEventNotification3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment75 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public required CardPaymentContext28 Context { get; init; } 
    /// <summary>
    /// Content of the EventNotification message.
    /// </summary>
    public required EventNotificationData2 EventNotification { get; init; } 
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
