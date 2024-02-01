﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LinkedCorporateActionIdentification.  ISO2002 ID# _chUcY5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventReference4Choice;

/// <summary>
/// Reference assigned by the account servicer to unambiguously identify a related corporate action event.
/// </summary>
public partial record LinkedCorporateActionIdentification : CorporateActionEventReference4Choice_
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
