﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Country.  ISO2002 ID# _QQ3rmdp-Ed-ak6NoX_4Aeg_1655680090.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification12Choice;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
public partial record Country : IPartyIdentification12Choice
{
    public required CountryCode Value { get; init; }
}
