﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Proposal5.  ISO2002 ID# _rL_T8YpIEeaNTaanBSMWmg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the type of proposal and if the proposal is for the variation margin and the segregated independent amount, or the segregated independent amount only.
/// </summary>
public partial record Proposal5
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether this is an initial or counter proposal.
    /// </summary>
    public required ProposalType1Code CollateralProposalType { get; init; } 
    /// <summary>
    /// Provides details about the proposal for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    public required ICollateralProposal5Choice CollateralProposal { get; init; } 
    
    #nullable disable
}
