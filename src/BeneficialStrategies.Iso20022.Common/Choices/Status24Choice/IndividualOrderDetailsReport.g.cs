﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndividualOrderDetailsReport.  ISO2002 ID# _bpQwZEHPEeazV4RAqPV71g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Status24Choice;

/// <summary>
/// Status report details of an individual order.
/// </summary>
public partial record IndividualOrderDetailsReport : IStatus24Choice
{
    #nullable enable
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text OrderReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    public IsoMax35Text? DealReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for the order cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// Status of the individual order.
    /// </summary>
    public required IOrderStatus5Choice OrderStatus { get; init; } 
    /// <summary>
    /// Elements from the original individual order that have been repaired so that the order can be accepted.
    /// </summary>
    // public IReadOnlyCollection<Fee3> RepairedFee { get; init; }
    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    public PartyIdentification113? StatusInitiator { get; init; } 
    /// <summary>
    /// Order data.
    /// </summary>
    public FundOrderData5? OrderData { get; init; } 
    /// <summary>
    /// Expected execution information.
    /// </summary>
    public ExpectedExecutionDetails4? NewDetails { get; init; } 
    /// <summary>
    /// Information about gating and hold back of redemption proceeds.
    /// </summary>
    public HoldBackInformation3? GatingOrHoldBackDetails { get; init; } 
    #nullable disable
}
