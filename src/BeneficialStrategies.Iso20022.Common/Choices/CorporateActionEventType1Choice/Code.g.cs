﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QwUAoNp-Ed-ak6NoX_4Aeg_2018145477.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType1Choice;

/// <summary>
/// Corporate action event type expressed as an ISO 20022 code.
/// </summary>
public partial record Code : CorporateActionEventType1Choice_
{
    public required CorporateActionEventType3Code Value { get; init; }
}
