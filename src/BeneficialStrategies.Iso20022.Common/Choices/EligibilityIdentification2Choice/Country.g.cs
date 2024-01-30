﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Country.  ISO2002 ID# _oOzV8eLXEeWFtOV72FbX9w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.EligibilityIdentification2Choice;

/// <summary>
/// Country code used to identify the issuance country to be defined as eligible.
/// </summary>
public partial record Country : IEligibilityIdentification2Choice
{
    public required CountryCode Value { get; init; }
}
