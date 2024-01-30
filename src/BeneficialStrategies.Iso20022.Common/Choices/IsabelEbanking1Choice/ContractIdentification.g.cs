﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ContractIdentification.  ISO2002 ID# _oWi3kMm7EeWAGphE2LvqeA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IsabelEbanking1Choice;

/// <summary>
/// Identification of the e-banking through a contract identification.
/// </summary>
public partial record ContractIdentification : IIsabelEbanking1Choice
{
    public required IsoMax13AlphaNumericText Value { get; init; }
}
