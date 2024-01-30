﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PhytosanitaryIndication.  ISO2002 ID# _TnTb4dp-Ed-ak6NoX_4Aeg_-2016555095.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics1Choice;

/// <summary>
/// Indicates if the goods have passed the phytosanitary check.
/// </summary>
public partial record PhytosanitaryIndication : ICertifiedCharacteristics1Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
