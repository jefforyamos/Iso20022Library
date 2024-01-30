﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BICFI.  ISO2002 ID# _kpLGoO5NEeCisYr99QEiWA_531980910.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TechnicalIdentification1Choice;

/// <summary>
/// Technical address of the party is defined as a financial institution business identifier code.
/// </summary>
public partial record BICFI : ITechnicalIdentification1Choice
{
    public required IsoBICFIIdentifier Value { get; init; }
}
