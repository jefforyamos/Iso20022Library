﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _cw1Iw-XmEemEj48jhmlA0Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType84Choice;

/// <summary>
/// Event type expressed as a code.
/// </summary>
public partial record Code : ICorporateActionEventType84Choice
{
    public required CorporateActionEventType31Code Value { get; init; }
}
