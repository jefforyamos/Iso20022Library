﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LEI.  ISO2002 ID# _XUZ6AZQEEeiILOjNP8ro1w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrganisationIdentification7Choice;

/// <summary>
/// Identification is done through the use of legal entity identifier code.
/// </summary>
public partial record LEI : OrganisationIdentification7Choice_
{
    public required IsoLEIIdentifier Value { get; init; }
}
