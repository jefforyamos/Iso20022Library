﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PassportNumber.  ISO2002 ID# _QEW5ktp-Ed-ak6NoX_4Aeg_-1180196056.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PersonIdentificationType1Choice;

/// <summary>
/// Number assigned by a passport authority to a passport.
/// </summary>
public partial record PassportNumber : PersonIdentificationType1Choice_
{
    public required IsoMax35Text Value { get; init; }
}
