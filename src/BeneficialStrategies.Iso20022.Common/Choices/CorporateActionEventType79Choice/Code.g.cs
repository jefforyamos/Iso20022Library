﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _OLYZ2c3xEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType79Choice;

/// <summary>
/// Event type expressed as a code.
/// </summary>
public partial record Code : CorporateActionEventType79Choice_
{
    public required CorporateActionEventType27Code Value { get; init; }
}
