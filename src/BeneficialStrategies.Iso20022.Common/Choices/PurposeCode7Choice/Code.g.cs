﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _vCc80znaEeWV5sr121Fc8A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PurposeCode7Choice;

/// <summary>
/// Securities account purpose as an ISO 20022 code.
/// </summary>
public partial record Code : IPurposeCode7Choice
{
    public required SecuritiesAccountPurposeType1Code Value { get; init; }
}
