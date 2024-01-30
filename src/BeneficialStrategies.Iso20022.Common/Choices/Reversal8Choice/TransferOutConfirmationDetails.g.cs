﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TransferOutConfirmationDetails.  ISO2002 ID# _-GjFwyPvEeWQjryFgN2ITg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Reversal8Choice;

/// <summary>
/// Details of the transfer out confirmation to be reversed.
/// </summary>
public partial record TransferOutConfirmationDetails : IReversal8Choice
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    public Transfer31? TransferDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information related to the account from which the financial instrument was withdrawn.
    /// </summary>
    public required InvestmentAccount54 AccountDetails { get; init; } 
    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    public ReceiveInformation17? SettlementDetails { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public Extension1? Extension { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
