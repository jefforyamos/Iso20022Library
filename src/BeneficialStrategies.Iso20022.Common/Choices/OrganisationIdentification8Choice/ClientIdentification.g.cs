﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ClientIdentification.  ISO2002 ID# _86WnoZQEEeiILOjNP8ro1w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OrganisationIdentification8Choice;

/// <summary>
/// Client code used to identify the organisation.
/// </summary>
public partial record ClientIdentification : IOrganisationIdentification8Choice
{
    public required IsoMax50Text Value { get; init; }
}
