﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _2C5p8-XmEemEj48jhmlA0Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType85Choice;

/// <summary>
/// Event types expressed as a code.
/// </summary>
public partial record Code : CorporateActionEventType85Choice_
{
    public required CorporateActionEventType29Code Value { get; init; }
}
