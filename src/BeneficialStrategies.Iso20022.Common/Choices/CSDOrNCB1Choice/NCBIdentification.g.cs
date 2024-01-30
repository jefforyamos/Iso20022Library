﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NCBIdentification.  ISO2002 ID# _knY98u5NEeCisYr99QEiWA_251909135.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CSDOrNCB1Choice;

/// <summary>
/// Unique identification to unambiguously identify the national central bank within the system.
/// </summary>
public partial record NCBIdentification : ICSDOrNCB1Choice
{
    public required IsoBICFIIdentifier Value { get; init; }
}
