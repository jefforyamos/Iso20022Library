﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ElAWsTqIEeWVrPy0StzzSg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Restriction5Choice;

/// <summary>
/// Restrictions expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IRestriction5Choice
{
    public required OwnershipLegalRestrictions1Code Value { get; init; }
}
