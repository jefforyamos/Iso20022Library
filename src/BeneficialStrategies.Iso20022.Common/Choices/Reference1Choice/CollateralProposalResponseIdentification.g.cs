﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralProposalResponseIdentification.  ISO2002 ID# _QmxqJtp-Ed-ak6NoX_4Aeg_-296925814.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Reference1Choice;

/// <summary>
/// Unique identifier of the collateral proposal response.
/// </summary>
public partial record CollateralProposalResponseIdentification : IReference1Choice
{
    public required IsoMax35Text Value { get; init; }
}
