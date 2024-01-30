﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndividualOrderStatusAndReason2.  ISO2002 ID# _TR_TNtp-Ed-ak6NoX_4Aeg_-1985802937.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of the individual orders of a bulk or multiple order that was previously received.
/// </summary>
public partial record IndividualOrderStatusAndReason2
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text OrderReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    public IsoMax35Text? DealReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// Status of the individual order is accepted or already executed or sent to next party or received. There is no reason attached.
    /// </summary>
    public required OrderStatus4Code Status { get; init; } 
    /// <summary>
    /// Status of the individual order is cancelled. This status is used for an order that has been accepted or that has been entered in an order book but that can not be executed.
    /// </summary>
    public required CancelledStatus2 Cancelled { get; init; } 
    /// <summary>
    /// Status of the individual order is conditionally accepted.
    /// </summary>
    public required ConditionallyAcceptedStatus2 ConditionallyAccepted { get; init; } 
    /// <summary>
    /// Status of the individual order is rejected. This status is used for an order that has not been accepted or entered in an order book.
    /// </summary>
    // public IReadOnlyCollection<RejectedStatus6> Rejected { get; init; }
    /// <summary>
    /// Status of the individual order is suspended.
    /// </summary>
    public required SuspendedStatus2 Suspended { get; init; } 
    /// <summary>
    /// Status of the individual order is in repair.
    /// </summary>
    public required InRepairStatus2 InRepair { get; init; } 
    /// <summary>
    /// Status of the individual order is partially settled.
    /// </summary>
    public required PartiallySettledStatus1 PartiallySettled { get; init; } 
    /// <summary>
    /// Elements from the original individual order that have been repaired so that the order can be accepted.
    /// </summary>
    public RepairedConditions3? RepairedConditions { get; init; } 
    /// <summary>
    /// Party that initiates the status of the order cancellation.
    /// </summary>
    public IPartyIdentification2Choice? StatusInitiator { get; init; } 
    /// <summary>
    /// Order data.
    /// </summary>
    public FundOrderData1? OrderData { get; init; } 
    /// <summary>
    /// Information that has been added to the original order.
    /// </summary>
    public ExpectedExecutionDetails2? NewDetails { get; init; } 
    
    #nullable disable
}
