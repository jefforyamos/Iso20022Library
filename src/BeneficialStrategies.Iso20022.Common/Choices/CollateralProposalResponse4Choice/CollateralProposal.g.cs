﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralProposal.  ISO2002 ID# _wFtHkStIEeyOa655cLd-DQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CollateralProposalResponse4Choice;

/// <summary>
/// Provides the collateral proposal response for the variation margin and optionally the segregated independent amount.
/// </summary>
public partial record CollateralProposal : ICollateralProposalResponse4Choice
{
    #nullable enable
    /// <summary>
    /// Provides the collateral proposal response for the variation margin.
    /// </summary>
    public required CollateralProposalResponseType4 VariationMargin { get; init; } 
    /// <summary>
    /// Provides the collateral proposal response for the segregated independent amount.
    /// </summary>
    public CollateralProposalResponseType4? SegregatedIndependentAmount { get; init; } 
    #nullable disable
}
