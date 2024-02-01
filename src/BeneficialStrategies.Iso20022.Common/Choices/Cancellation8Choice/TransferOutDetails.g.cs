﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TransferOutDetails.  ISO2002 ID# _hL6gAz8BEeSIqOPJHpnleA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cancellation8Choice;

/// <summary>
/// Details of the transfer out request to cancel.
/// </summary>
public partial record TransferOutDetails : Cancellation8Choice_
{
    #nullable enable
    /// <summary>
    /// Requested date at which the instructing party places the transfer instruction.
    /// </summary>
    public DateFormat1Choice_? RequestedTransferDate { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Details of the transfer and cancellation.
    /// </summary>
    public TransferOut13? TransferAndReferences { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information related to the account from which the financial instrument is to be withdrawn.
    /// </summary>
    public required InvestmentAccount40 AccountDetails { get; init; } 
    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    public ReceiveInformation15? SettlementDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public Extension1? Extension { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
