﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for EntitlementRatio.  ISO2002 ID# _RDrol9p-Ed-ak6NoX_4Aeg_362471814.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Entitlement1Choice;

/// <summary>
/// Number of votes assigned to one security.
/// </summary>
public partial record EntitlementRatio : IEntitlement1Choice
{
    public required IsoDecimalNumber Value { get; init; }
}
