﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FinancialInstrumentIdentification.  ISO2002 ID# _oOzV8-LXEeWFtOV72FbX9w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EligibilityIdentification2Choice;

/// <summary>
/// ISIN used to identify the security to be defined as eligible.
/// </summary>
public partial record FinancialInstrumentIdentification : IEligibilityIdentification2Choice
{
    public required IsoISINOct2015Identifier Value { get; init; }
}
