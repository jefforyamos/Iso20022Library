﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SegregatedIndependentAmount.  ISO2002 ID# _QmU-N9p-Ed-ak6NoX_4Aeg_-277145962.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralProposalResponse1Choice;

/// <summary>
/// Provides the collateral proposal response for the segregated independent amount only.
/// </summary>
public partial record SegregatedIndependentAmount : CollateralProposalResponse1Choice_
{
    #nullable enable
    /// <summary>
    /// Unique identifier for a collateral proposal.
    /// </summary>
    public required IsoMax35Text CollateralProposalIdentification { get; init; } 
    /// <summary>
    /// Indicates whether the collateral proposal is an initial or a counter proposal.
    /// </summary>
    public required CollateralProposalResponse1Code Type { get; init; } 
    /// <summary>
    /// Specifies the status of the collateral proposal.
    /// </summary>
    public required Status4Code ResponseType { get; init; } 
    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    public RejectionReasonV021Code? RejectionReason { get; init; } 
    /// <summary>
    /// Additional information regarding why the collateral proposal has a rejected status.
    /// </summary>
    public IsoMax35Text? RejectionInformation { get; init; } 
    #nullable disable
}
