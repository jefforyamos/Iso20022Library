﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralProposalResponseIdentification.  ISO2002 ID# _d0qV5ALyEeutW5-TpeYJhA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Reference3Choice;

/// <summary>
/// Unique identifier of the collateral proposal response.
/// </summary>
public partial record CollateralProposalResponseIdentification : IReference3Choice
{
    public required IsoMax35Text Value { get; init; }
}
