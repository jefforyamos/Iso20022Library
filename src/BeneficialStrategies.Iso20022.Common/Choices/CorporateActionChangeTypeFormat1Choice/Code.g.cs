﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q3Unltp-Ed-ak6NoX_4Aeg_941345591.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionChangeTypeFormat1Choice;

/// <summary>
/// Standard code to specify the type of changes.
/// </summary>
public partial record Code : ICorporateActionChangeTypeFormat1Choice
{
    public required CorporateActionChangeType1Code Value { get; init; }
}
