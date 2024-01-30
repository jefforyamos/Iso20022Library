﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TransferOutConfirmationDetails.  ISO2002 ID# _-5EuwBg3EeK-_89we2b-bA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reversal1Choice;

/// <summary>
/// Details of the transfer out confirmation to be reversed.
/// </summary>
public partial record TransferOutConfirmationDetails : IReversal1Choice
{
    #nullable enable
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    public Transfer24? TransferDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information related to the account from which the financial instrument was withdrawn.
    /// </summary>
    public required InvestmentAccount22 AccountDetails { get; init; } 
    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    public ReceiveInformation11? SettlementDetails { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public Extension1? Extension { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
