﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralProposalIdentification.  ISO2002 ID# _TYW3kaerEeCq2KR6DaC1kQ_-1115881405.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Reference2Choice;

/// <summary>
/// Unique identifier of the collateral proposal.
/// </summary>
public partial record CollateralProposalIdentification : IReference2Choice
{
    public required IsoMax35Text Value { get; init; }
}
