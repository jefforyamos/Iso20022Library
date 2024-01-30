﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OrderStatusAndReason3.  ISO2002 ID# _Uvkrg9p-Ed-ak6NoX_4Aeg_-1625631905.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of a bulk or multiple or switch order that was previously received.
/// </summary>
public partial record OrderStatusAndReason3
{
    #nullable enable
    
    /// <summary>
    /// Status of the order is accepted or already executed or sent to next party or received. There is no reason attached.
    /// </summary>
    public required OrderStatus2Code Status { get; init; } 
    /// <summary>
    /// Status of the order details is cancelled. This status is used for orders that have been accepted or that have been entered in an order book but that can not be executed.
    /// </summary>
    public required CancelledStatus1 Cancelled { get; init; } 
    /// <summary>
    /// Status of the order details is conditionally accepted.
    /// </summary>
    public required ConditionallyAcceptedStatus1 ConditionallyAccepted { get; init; } 
    /// <summary>
    /// Status of the order details is rejected. This status is used for orders that have not been accepted or entered in an order book.
    /// </summary>
    public required RejectedStatus3 Rejected { get; init; } 
    /// <summary>
    /// Status of the order details is suspended.
    /// </summary>
    public required SuspendedStatus1 Suspended { get; init; } 
    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    public IPartyIdentification2Choice? StatusInitiator { get; init; } 
    /// <summary>
    /// Unique and unambiguous technical identification of an instance of a leg within a switch.
    /// </summary>
    public IsoMax35Text? SwitchOrderLegIdentification { get; init; } 
    
    #nullable disable
}
