﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TechnicalAddress.  ISO2002 ID# _kpLGoe5NEeCisYr99QEiWA_1921350495.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TechnicalIdentification1Choice;

/// <summary>
/// Technical address of the party is defined in a free text format.
/// </summary>
public partial record TechnicalAddress : ITechnicalIdentification1Choice
{
    public required IsoMax256Text Value { get; init; }
}
