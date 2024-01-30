﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LinkedCorporateActionIdentification.  ISO2002 ID# _4h3LqzncEeWLJsP1cO-amg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventReference3Choice;

/// <summary>
/// Reference assigned by the account servicer to unambiguously identify a related corporate action event.
/// </summary>
public partial record LinkedCorporateActionIdentification : ICorporateActionEventReference3Choice
{
    public required IsoMax35Text Value { get; init; }
}
