﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralSubstitutionRequestIdentification.  ISO2002 ID# _QmxqKNp-Ed-ak6NoX_4Aeg_738713165.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reference1Choice;

/// <summary>
/// Unique identifier of the collateral substitution request.
/// </summary>
public partial record CollateralSubstitutionRequestIdentification : IReference1Choice
{
    public required IsoMax35Text Value { get; init; }
}
