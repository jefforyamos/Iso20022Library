﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _RYGZYdp-Ed-ak6NoX_4Aeg_603460919.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InformationType1Choice;

/// <summary>
/// Type of additional information not catered for by the available codes.
/// </summary>
public partial record Proprietary : IInformationType1Choice
{
    public required IsoMax140Text Value { get; init; }
}
