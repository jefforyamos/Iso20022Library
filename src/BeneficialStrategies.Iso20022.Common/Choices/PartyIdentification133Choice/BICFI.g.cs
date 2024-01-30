﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BICFI.  ISO2002 ID# _H6i9c9XWEeiN28wlpBQScw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification133Choice;

/// <summary>
/// Code allocated to a financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
/// </summary>
public partial record BICFI : IPartyIdentification133Choice
{
    public required IsoBICFIDec2014Identifier Value { get; init; }
}
