﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _bP-EdYr-EeaNFeVGetd6Xw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType53Choice;

/// <summary>
/// Event types expressed as a code.
/// </summary>
public partial record Code : ICorporateActionEventType53Choice
{
    public required CorporateActionEventType21Code Value { get; init; }
}
