﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _n3S3JQtKEeWkxvNyFrBT8Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ContractBalanceType1Choice;

/// <summary>
/// Specifies the nature of a balance, in a proprietary form.
/// </summary>
public partial record Proprietary : IContractBalanceType1Choice
{
    public required IsoMax35Text Value { get; init; }
}
