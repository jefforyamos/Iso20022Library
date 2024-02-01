﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FinancialInstrumentIdentification.  ISO2002 ID# _jBJ_9O5NEeCisYr99QEiWA_1649661981.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EligibilityIdentification1Choice;

/// <summary>
/// ISIN used to identify the security to be defined as eligible.
/// </summary>
public partial record FinancialInstrumentIdentification : EligibilityIdentification1Choice_
{
    public required IsoISINIdentifier Value { get; init; }
}
