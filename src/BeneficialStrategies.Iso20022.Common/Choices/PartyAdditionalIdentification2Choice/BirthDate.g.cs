﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BirthDate.  ISO2002 ID# _Qo3U0tp-Ed-ak6NoX_4Aeg_-86602673.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyAdditionalIdentification2Choice;

/// <summary>
/// Date of birth of an individual person.
/// </summary>
public partial record BirthDate : IPartyAdditionalIdentification2Choice
{
    public required IsoISODate Value { get; init; }
}
