﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyBIC.  ISO2002 ID# _ML-TZZQMEeiILOjNP8ro1w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrganisationIdentification9Choice;

/// <summary>
/// Business identifier code used to identify the organisation.
/// </summary>
public partial record AnyBIC : IOrganisationIdentification9Choice
{
    public required IsoAnyBICDec2014Identifier Value { get; init; }
}
