﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AlienRegistrationNumber.  ISO2002 ID# _QEW5l9p-Ed-ak6NoX_4Aeg_-1180196117.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PersonIdentificationType1Choice;

/// <summary>
/// Number assigned by a government agency to identify foreign nationals.
/// </summary>
public partial record AlienRegistrationNumber : IPersonIdentificationType1Choice
{
    public required IsoMax35Text Value { get; init; }
}
