﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Domestic.  ISO2002 ID# _RCMa1dp-Ed-ak6NoX_4Aeg_-1064528879.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationSource1Choice;

/// <summary>
/// Country of the proprietary identification scheme.
/// </summary>
public partial record Domestic : IIdentificationSource1Choice
{
    public required CountryCode Value { get; init; }
}
