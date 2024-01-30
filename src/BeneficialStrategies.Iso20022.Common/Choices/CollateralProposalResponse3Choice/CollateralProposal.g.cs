﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralProposal.  ISO2002 ID# _sc8-0YpDEeaNTaanBSMWmg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralProposalResponse3Choice;

/// <summary>
/// Provides the collateral proposal response for the variation margin and optionally the segregated independent amount.
/// </summary>
public partial record CollateralProposal : ICollateralProposalResponse3Choice
{
    #nullable enable
    /// <summary>
    /// Provides the collateral proposal response for the variation margin.
    /// </summary>
    public required CollateralProposalResponseType3 VariationMargin { get; init; } 
    /// <summary>
    /// Provides the collateral proposal response for the segregated independent amount.
    /// </summary>
    public CollateralProposalResponseType3? SegregatedIndependentAmount { get; init; } 
    #nullable disable
}
