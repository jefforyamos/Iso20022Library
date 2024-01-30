﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralTransactionIdentification.  ISO2002 ID# _AcY2gNokEeC60axPepSq7g_791307389.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference8Choice;

/// <summary>
/// Unambiguous identification of a collateral transaction as assigned by the instructing party.
/// </summary>
public partial record CollateralTransactionIdentification : IIdentificationReference8Choice
{
    public required IsoMax35Text Value { get; init; }
}
