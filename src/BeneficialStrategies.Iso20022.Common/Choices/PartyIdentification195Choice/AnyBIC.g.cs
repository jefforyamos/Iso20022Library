﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyBIC.  ISO2002 ID# _4aFsyjqdEemL_ewJY9QP1g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification195Choice;

/// <summary>
/// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
/// </summary>
public partial record AnyBIC : IPartyIdentification195Choice
{
    public required IsoAnyBICDec2014Identifier Value { get; init; }
}
