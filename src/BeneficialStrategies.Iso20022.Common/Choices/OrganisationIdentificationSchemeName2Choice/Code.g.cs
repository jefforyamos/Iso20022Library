﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _WgN0RRBBEeGyZLI6olyk-Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrganisationIdentificationSchemeName2Choice;

/// <summary>
/// Name of the identification scheme, in a coded form as published in an external list.
/// </summary>
public partial record Code : IOrganisationIdentificationSchemeName2Choice
{
    public required ExternalOrganisationIdentification1Code Value { get; init; }
}
