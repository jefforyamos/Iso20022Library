﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _AdIdY9okEeC60axPepSq7g_-391783727.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChargeTaxBasisType1Choice;

/// <summary>
/// Securities transaction type expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IChargeTaxBasisType1Choice
{
    public required ChargeTaxBasis1Code Value { get; init; }
}
