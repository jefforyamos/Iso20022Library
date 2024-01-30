﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesAccountIdentification.  ISO2002 ID# _Rjkpmdp-Ed-ak6NoX_4Aeg_136863972.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification2Choice;

/// <summary>
/// Identification of a securities account.
/// </summary>
public partial record SecuritiesAccountIdentification : IAccountIdentification2Choice
{
    public required IsoMax35Text Value { get; init; }
}
