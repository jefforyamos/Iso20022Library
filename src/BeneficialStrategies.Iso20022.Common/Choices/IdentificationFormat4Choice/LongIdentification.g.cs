﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LongIdentification.  ISO2002 ID# _c5VTP5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationFormat4Choice;

/// <summary>
/// Format expressed as a long identification.
/// </summary>
public partial record LongIdentification : IdentificationFormat4Choice_
{
    public required IsoRestrictedFINXMax30Text Value { get; init; }
}
