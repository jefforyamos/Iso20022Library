﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BICOrBEI.  ISO2002 ID# _QRUXhNp-Ed-ak6NoX_4Aeg_923150051.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification4Choice;

/// <summary>
/// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
/// </summary>
public partial record BICOrBEI : IPartyIdentification4Choice
{
    public required IsoAnyBICIdentifier Value { get; init; }
}
