﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SwitchOrderStatusAndReason2.  ISO2002 ID# _FXOE-zbtEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of the individual orders of a bulk or multiple order that was previously received.
/// </summary>
public partial record SwitchOrderStatusAndReason2
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
    /// Status of the switch order.
    /// </summary>
    public required IOrderStatus4Choice OrderStatus { get; init; } 
    /// <summary>
    /// Information about a switch leg that is rejected or repaired.
    /// </summary>
    public SwitchLegReferences2? LegInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    public PartyIdentification113? StatusInitiator { get; init; } 
    /// <summary>
    /// Order data.
    /// </summary>
    public FundOrderData6? OrderData { get; init; } 
    /// <summary>
    /// Expected execution information.
    /// </summary>
    public ExpectedExecutionDetails2? NewDetails { get; init; } 
    
    #nullable disable
}
