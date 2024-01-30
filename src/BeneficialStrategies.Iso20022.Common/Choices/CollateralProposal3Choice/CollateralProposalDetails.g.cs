﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralProposalDetails.  ISO2002 ID# _P0F1UV9-EeSMgPeFpRHeJw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CollateralProposal3Choice;

/// <summary>
/// Provides details about the proposal for the variation margin and optionaly the segregated independent amount.
/// </summary>
public partial record CollateralProposalDetails : ICollateralProposal3Choice
{
    #nullable enable
    /// <summary>
    /// Provides details about the proposal for the variation margin.
    /// </summary>
    public required CollateralMovement5 VariationMargin { get; init; } 
    /// <summary>
    /// Provides details about the proposal for the segregated independent amount.
    /// </summary>
    public CollateralMovement5? SegregatedIndependentAmount { get; init; } 
    #nullable disable
}
