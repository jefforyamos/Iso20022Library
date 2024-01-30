﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BBAN.  ISO2002 ID# _e6Hl8watEe2phaVG0lYKTw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification55Choice;

/// <summary>
/// Basic Bank Account Number (BBAN) - identifier used nationally by financial institutions, ie, in individual countries, generally as part of a National Account Numbering Scheme(s), to uniquely identify the account of a customer.
/// </summary>
public partial record BBAN : IAccountIdentification55Choice
{
    public required IsoBBANIdentifier Value { get; init; }
}
