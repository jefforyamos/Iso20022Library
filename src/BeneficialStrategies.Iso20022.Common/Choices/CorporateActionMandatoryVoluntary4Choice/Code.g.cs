﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _cdRCGZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionMandatoryVoluntary4Choice;

/// <summary>
/// Standard code to specify whether the event is mandatory, mandatory with options or voluntary.
/// </summary>
public partial record Code : ICorporateActionMandatoryVoluntary4Choice
{
    public required CorporateActionMandatoryVoluntary1Code Value { get; init; }
}
