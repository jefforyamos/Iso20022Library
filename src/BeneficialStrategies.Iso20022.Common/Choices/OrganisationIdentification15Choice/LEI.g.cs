﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LEI.  ISO2002 ID# _TYKAUMgnEeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OrganisationIdentification15Choice;

/// <summary>
/// Identification is done through the use of legal entity identifier code.
/// </summary>
public partial record LEI : IOrganisationIdentification15Choice
{
    public required IsoLEIIdentifier Value { get; init; }
}
