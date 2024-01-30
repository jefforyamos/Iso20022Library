﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyBIC.  ISO2002 ID# _XDaS8ZjTEeW1SPbGMCLIOQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification114Choice;

/// <summary>
/// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
/// </summary>
public partial record AnyBIC : IPartyIdentification114Choice
{
    public required IsoAnyBICIdentifier Value { get; init; }
}
