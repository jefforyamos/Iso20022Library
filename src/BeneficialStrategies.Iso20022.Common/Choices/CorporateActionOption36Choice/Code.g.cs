﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _DkeR6QVSEeqjd8n6wD9JVw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionOption36Choice;

/// <summary>
/// Standard code to specify the type of corporate action options.
/// </summary>
public partial record Code : CorporateActionOption36Choice_
{
    public required CorporateActionOption11Code Value { get; init; }
}
